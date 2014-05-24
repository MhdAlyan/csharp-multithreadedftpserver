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
    public partial class Client : Form
    {
        #region DataMembers

           #region Static DataMember To Access the userControls on Form From SendRequset Class
                public static TextBox user_TextBox_Receive;

                public static TextBox user_TextBox_Receive_Text_Data;

                public static TextBox user_TextBox_ServerIP;

                public static TextBox user_TextBox_portnmber;

                public static ToolStripStatusLabel label_Server_info;
          #endregion 

            SendRequest clientSendRequset; // Camel Form 
        #endregion 

        #region public Client()
         /// <summary>
        /// initialization Datamember for Begin Connecting With Server 
        /// </summary>
        public Client()
        {
            InitializeComponent(); 

            user_TextBox_portnmber = TextBox_portNumber;

            user_TextBox_ServerIP = TextBox_serverIp;

            user_TextBox_Receive = textBox_Receive;

            user_TextBox_Receive_Text_Data = TextBox_Receive_Text_Data;

            label_Server_info = ToolStripStatusLabel_Server_ingo;

            clientSendRequset = new SendRequest();
        }
        #endregion


        //Send Button 
        #region private void Button_Send_Click_1(object sender, EventArgs e)
        private void Button_Send_Click_1(object sender, EventArgs e)
        {
            if (clientSendRequset.Client.Connected)
            {
                try
                {
                    OpenFileDialog.ShowDialog();

                    string path = OpenFileDialog.FileName;

                    clientSendRequset.Writer = new BinaryWriter(clientSendRequset.MynetworkStream);//**

                    clientSendRequset.Writer.Write((byte)1);

                    byte[] buffer = File.ReadAllBytes(path); 

                    clientSendRequset.Writer.Write(buffer.Length); //send the size of file  
                    
                    //Sending Data 
                    clientSendRequset.MynetworkStream.Write(buffer, 0, buffer.Length);  //same as above (2)

                    TextBox_Send.Text = buffer.Length.ToString(); // Show Size of File

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }
            else
                MessageBox.Show("the Client is Disconnected");
        }
        #endregion 


        //Save Button 
        #region private void Button_Save_Click_1(object sender, EventArgs e)
        private void Button_Save_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // You need to Try-catch-finally
                FileStream file=null;
                try
                {
                    file = new FileStream(saveFileDialog.FileName, FileMode.Create); ;
                    file.Write(clientSendRequset.ArrFile, 0, clientSendRequset.ArrFile.Length);
                    file.Flush();
                }
                catch (Exception Error) { MessageBox.Show(Error.Message); }
                finally
                {
                    try
                    {
                        file.Close();
                    }
                    catch (Exception err) { MessageBox.Show(err.Message); }
                }
            }
        }
        #endregion 


        //important 
        #region private void Client_FormClosing(object sender, FormClosingEventArgs e)
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
        #endregion 

        // Begin Connecting To the Server (Connect Button )
        #region private void Button_Connect_Click(object sender, EventArgs e)
        private void Button_Connect_Click(object sender, EventArgs e)
        {
            clientSendRequset.RequestStatus= 1;
            try
            {
                clientSendRequset = new SendRequest(); 

                clientSendRequset.start();
            }
            catch (Exception err) { MessageBox.Show(err.Message); } // if the user is Press on Connect button More Than One Time
          
        }
        #endregion 


        //Disconnect Button 
        #region private void Button_Disconnect_Click(object sender, EventArgs e)
        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            clientSendRequset.AbortRequset();

            clientSendRequset.RequestStatus= 0; // that Means the Client is not Connected with the Server anthor Time
            
            clientSendRequset.Client.Close();

            MessageBox.Show("Client is Disconnected");

            ToolStripStatusLabel_Server_ingo.Text = "";
        }
        #endregion 



        //Send Text Data To The Server
        #region private void TextBox_input_KeyDown(object sender, KeyEventArgs e)
        private void TextBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (clientSendRequset.Client.Connected)
            {
                if ((e.KeyCode == Keys.Enter))
                {
                    clientSendRequset.Writer = new BinaryWriter(clientSendRequset.MynetworkStream);

                    clientSendRequset.Writer.Write((byte)0); // 0 is Flag that Represent that the Client Send text Data

                    clientSendRequset.Writer.Write("client>>" + TextBox_Input.Text); // Send Text Data

                    TextBox_Input.Clear();
                }
            }
            else
            {
               // MessageBox.Show("Client is Diconnected");
                TextBox_Input.Clear();
            }
        }
        #endregion 





        //Send File Data To The Selected Client
        #region private void Button_Send_2_Client_Click(object sender, EventArgs e)
        private void Button_Send_2_Client_Click(object sender, EventArgs e)
        {
            if (TextBox_Remote_Client_IP.Text == "")
            {
                MessageBox.Show("Error: Pleas Enter Client IP To Send it", "Error at RemoteEndPoint IP ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clientSendRequset.Client.Connected)
            {
                try
                {
                    OpenFileDialog.ShowDialog();

                    string path = OpenFileDialog.FileName;

                    clientSendRequset.Writer = new BinaryWriter(clientSendRequset.MynetworkStream); 

                    //1: Send Flag to The Server
                    clientSendRequset.Writer.Write((byte)2);// 2 That Means : the Cleint Wants To Send File To  Selected Client By IP Address 

                    //2 :  Send  IP  To server
                    clientSendRequset.Writer.Write(TextBox_Remote_Client_IP.Text);// Very Important : Send IP Address of Client You Want To Send to it

                    byte[] buffer = File.ReadAllBytes(path); 

                    //3 :send the size of file  
                    clientSendRequset.Writer.Write(buffer.Length);

                    //4: Send Data To Server Then the Server Send To the Selected Client(By Destination IP)
                    clientSendRequset.MynetworkStream.Write(buffer, 0, buffer.Length);  

                    TextBox_Send_To_Client.Text = buffer.Length.ToString();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }
            else
                MessageBox.Show("the Client is Disconnected");
        }
        #endregion 




        //Send Text Data To The Selected Client
        #region private void TextBox_Input_Send_to_Client_KeyDown(object sender, KeyEventArgs e)
        private void TextBox_Input_Send_to_Client_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextBox_Remote_Client_IP.Text == "")
            {
                MessageBox.Show("Error: Pleas Enter Client IP To Send it", "Error at RemoteEndPoint IP ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clientSendRequset.Client.Connected)
            {
                if ((e.KeyCode == Keys.Enter))
                {
                    clientSendRequset.Writer = new BinaryWriter(clientSendRequset.MynetworkStream);

                    //1
                    clientSendRequset.Writer.Write((byte)3); // 3 is falg That means : the Cleint Wants To Send  To  Selected Client By IP Address 
                    //2
                    clientSendRequset.Writer.Write(TextBox_Remote_Client_IP.Text);// Very Important : Send IP Address of Client You Want To Send to it
                    
                   //3 : Sending  Text Data
                   clientSendRequset.Writer.Write("client>>" + TextBox_Input_Send_to_Client.Text);

                   TextBox_Input.Clear();
                }
            }
            else
            {
                // MessageBox.Show("Client is Diconnected");
                TextBox_Input.Clear();
            }
        }
        #endregion 

    }//End Client Class

}//End nameSpace
