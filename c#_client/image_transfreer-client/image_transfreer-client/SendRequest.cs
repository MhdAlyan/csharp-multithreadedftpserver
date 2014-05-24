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
using System.ServiceModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;



namespace Files_transfreer_client
{

    /// <summary>
    /// Send Requset To The Server To Connect With it By the Folowing Way , you neeed to:
    /// 1- Object Form TcpClient to connect to the Server that Have IP and Port number ;client = new TcpClient(server_ip,port_number);
    /// 2- reference form Networkstream and Get the stram from TcpClient Object ; mynetworkStream = client.GetStream();
    /// 3- Two  object from BinaryReader and BinaryWriter (That Encapsulate the mynetworkstream )To Read and Write on Network
    /// </summary>
    class SendRequest
    {

        #region DataMembers
        
            TcpClient client = null; // if the Name is Client it will be Wrong Because the Client is The Class Name 
            NetworkStream mynetworkStream;
            BinaryReader reader;
            BinaryWriter writer;

            byte[] arrFile;
            Thread readThread;
            int requestStatus = 1; // for Disconnecting the Connection
        #endregion 


        #region Properties
            public TcpClient Client
            {
                get { return client; }
                set { client = value; }
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

            public Thread ReadThread
            {
                get { return readThread; }
                set { readThread = value; }
            }

            public int RequestStatus
            {
                get { return requestStatus; }
                set { requestStatus = value; }
            }

        #endregion


        #region SendRequset Constuctor 
        /// <summary>
        /// Constructor
        /// </summary>
        public SendRequest()
        {
            readThread = new Thread(new ThreadStart(Run_client));
        }
        #endregion 


        #region public void start()
        /// <summary>
        /// Start Sending Request
        /// </summary>
        public void start()
        {
            try
            {
                readThread.Start();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }

        }
        #endregion


        #region public void AbortRequset()
        /// <summary>
        /// Abort Sending and Receiving Thread 
        /// </summary>
        public void AbortRequset()
        {
            try
            {
                readThread.Abort();
            }
            catch (Exception err) { MessageBox.Show(err.Message); }

        }
        #endregion


        #region public void Run_client()
        /// <summary>
        /// Connecting With Server ,and Receiving Data From it 
        /// </summary>
        public void Run_client()
        {
            try
            {
                if (requestStatus == 1) // if the ueser presses on the Disconnect Button  then requestStatus=0 
                {
                    if (client != null)
                    {
                        if (!(client.Connected))
                            client = new TcpClient(Files_transfreer_client.Client.user_TextBox_ServerIP.Text, Convert.ToInt32(Files_transfreer_client.Client.user_TextBox_portnmber.Text));

                    }
                    else
                        client = new TcpClient(Files_transfreer_client.Client.user_TextBox_ServerIP.Text, Convert.ToInt32(Files_transfreer_client.Client.user_TextBox_portnmber.Text));

                    Files_transfreer_client.Client.label_Server_info.Text = "Connect To Host That Has: " + client.Client.RemoteEndPoint.ToString();

                    mynetworkStream = client.GetStream();

                    while (client.Connected)//Creat Session 
                    {
                        reader = new BinaryReader(mynetworkStream);

                        byte flag = reader.ReadByte();

                        if (flag == 0)
                        {
                            //  string s = reader.ReadString();

                            Files_transfreer_client.Client.user_TextBox_Receive_Text_Data.Text += reader.ReadString() + "\r\n";
                        }
                        else if (flag == 1)
                        {
                            int file_size = reader.ReadInt32(); //Reading the file size from the stream
                            // 1
                            arrFile = reader.ReadBytes(file_size); // this Way is the best to improve performance 

                            Files_transfreer_client.Client.user_TextBox_Receive.Text = Convert.ToString(arrFile.Length);
                        }

                    }//End While ; End Session 
                }

            }
            catch (Exception ee)
            {
                // MessageBox.Show(ee.Message);  

                //Optional
                //if (requestStatus == 1) // if The Connection is Disconnected because Exception you Can Connect Again To the Server (*)
                //    Run_client(); //(*)
            }
        }
        #endregion

    }
}
