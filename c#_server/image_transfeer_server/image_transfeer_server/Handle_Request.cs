using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace Files_transfeer_server
{

    /// <summary>
    ///  to build application As Server we have to :
    ///  1- object form Tcplistener(Class) 
    ///  2- object from Socket(Class) that takes object from Tcplistener By AcceptSocket() method ; 
    ///  3- object from Networkstream that tackes object from socket class 
    ///  4- two  object from streamreader and streamwriter  Or  BinaryReader and BinaryWritter ; each of this take object from newrorkstram(Class)    /// 
    /// </summary>
    class Handle_Request
    {

        #region DataMember
            
            // TcpListener is Represnet The Socket in Server  that Open Connection at  Selected  Port  and Listen to Clients Request 
            TcpListener listener;

            //Socket is Port and IP  : (Ex: mysocket=new TCplistener().Acceptsocket(); )
            Socket myscoket;//Socket is used to Link  Transport layer(TCPlistener OR TCPClient) With Network layer(NetworkStream)  

            NetworkStream mynetworkStream;// Encapsulate object from Socket Class(mysockets) 

            BinaryReader reader;// Encapsulate object from Networkstream(mynetworkStream)  and  Reading from Network  

            BinaryWriter writer;// Encapsulate object from Networkstream(mynetworkStream)  and  Writing on Network 

        
            byte[] arrFile; // Containing the file in the form of Bytes Array

            EndPoint remoteEndPoint; //Information About Remote EndPoint

            Thread serverThread = null; // // to Run this Process With anthor processes 

        #endregion


        #region Properties
            public TcpListener Listener
            {
                get { return listener; }
                set { listener = value; }
            }

            public Socket Myscoket
            {
                get { return myscoket; }
                set { myscoket = value; }
            }

            public NetworkStream MynetworkStream
            {
                get { return mynetworkStream; }
                set { mynetworkStream = value; }
            }

            public BinaryReader Reader
            {
                get { return reader; }
                set { reader = value; }
            }

            public BinaryWriter Writer
            {
                get { return writer; }
                set { writer = value; }
            }

            public byte[] ArrFile
            {
                get { return arrFile; }
                set { arrFile = value; }
            }

            public EndPoint RemoteEndPoint
            {
                get { return remoteEndPoint; }
                set { remoteEndPoint = value; }
            }

            public Thread ServerThread
            {
                get { return serverThread; }
                set { serverThread = value; }
            }

        #endregion


        #region   Handle_Request  Constuctor
        /// <summary>
        /// Costructor 
        /// </summary>
        /// <param name="port"> port number is Adderss of this  Aplication ; must be Uniq</param>
        /// <param name="listener"> </param>
        /// <param name="sock"> sock is Socket between Server And Client After the Server Accept the Clien Requset</param>
        public Handle_Request(TcpListener listener , Socket sock)
        {
            this.listener = listener;

            myscoket = sock;

            serverThread= new Thread(new ThreadStart(RunServer));
        }
        #endregion 


        #region public void start()
        /// <summary>
        /// Start Handle_Requset thread 
        /// </summary>
        public void start()
        {
            try
            {
                serverThread.Start();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }
        #endregion


        #region public void RunServer()
        /// <summary>
        /// The Most important method in this Class ;
        /// this Method is invoked by serverThread 
        /// </summary>
        public void RunServer()
        {
            int file_size = 0;

            try
            {
                // myscoket = listener.AcceptSocket(); //  Active in ThreadPool 

                remoteEndPoint = listener.LocalEndpoint;


                server.label_client_info.Text = "Connect To Host That Has:" + myscoket.RemoteEndPoint.ToString();

                mynetworkStream = new NetworkStream(myscoket);

                reader = new BinaryReader(mynetworkStream);
                writer = new BinaryWriter(mynetworkStream);

                while (myscoket.Connected)
                {
                    byte flage = reader.ReadByte();

                    if (flage == 0) //Receive Text Data 
                    {
                        //string s = reader.ReadString(); //For debuging
                        server.user_TextBox_Receive_Text_Data.Text += reader.ReadString() + "\r\n";
                    }
                    else if (flage == 1) //Receive File
                    {

                        file_size = reader.ReadInt32(); //Reading the file size from the stream
                        // 1
                        arrFile = reader.ReadBytes(file_size); // this Way is the best to improve performance 

                        server.user_TextBox_Receive.Text = arrFile.Length.ToString();

                    }
                    else if (flage == 2)// Client Want To Send File To Selected Client
                    {
                        string ip = reader.ReadString(); // Receive Client  IP  To Send to it 

                        // if Client is EXIST and Conncected To the Server Send File To it 

                        if ((server.clientsList[ip] != null)&& (server.clientsList[ip].Connected))
                        {
                            file_size = reader.ReadInt32(); //Reading the file size from the stream

                            // 1
                            byte [] temp_arrFile = reader.ReadBytes(file_size); // this Way is the best to improve performance 

                            //----------Send File to Client--------------------------

                            NetworkStream mynetworkstream1 = new NetworkStream(server.clientsList[ip]);

                            try
                            {
                                Writer = new BinaryWriter(mynetworkstream1);

                                Writer.Write((byte)1); // Sending Any  File 

                                Writer.Write(temp_arrFile.Length); //send the size of file  

                                //Writing Data
                                mynetworkstream1.Write(temp_arrFile, 0, temp_arrFile.Length);  //same as above (2)

                                temp_arrFile = null; // Run GC
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                        }//End If

                    }//End Else if
                    else if (flage == 3) // Client Want To Send TextData To Selected Client
                    {
                        string ip = reader.ReadString(); //First : Read IP Address 

                        if ((server.clientsList[ip] != null) && (server.clientsList[ip].Connected))
                        {
                            string s = reader.ReadString(); // Second: Read TextData from Client 


                            //----------Send Text Data to Client--------------------------

                            NetworkStream mynetworkstream1 = new NetworkStream(server.clientsList[ip]);

                            Writer = new BinaryWriter(mynetworkstream1);

                            Writer.Write((byte)0); //Sending Text Data 

                            Writer.Write(s);
                        }
                    }

                }//end While 

            }
            catch (Exception error)
            {
                // MessageBox.Show(error.Message);
            }

            myscoket.Close();

            mynetworkStream.Close();
        }
        #endregion 

    }
}
