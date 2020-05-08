using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace serverTCP
{
    public partial class Server : Form
    {
        List<Socket> ClientSocketsList = new List<Socket>();
        public Server()
        {
            InitializeComponent();
            string IPaddress = GetLocalIP();
            //this.appendTextToLog(string.Format("The service's IP is {0}", IPaddress));
            textBoxDisplay.AppendText(string.Format("The service's IP is {0}", IPaddress));
            labelIP.Text = IPaddress;
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            if(comboBoxListen.Text == "")
            {
                MessageBox.Show("Please select the maximum number of waiting clients.");
                return;
            }
            //1. create socket object
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

            //2. assign port
            socket.Bind(new IPEndPoint(IPAddress.Parse(labelIP.Text), int.Parse(textBoxPort.Text)));

            //3. start listening
            socket.Listen(int.Parse(comboBoxListen.Text));
            textBoxDisplay.AppendText(string.Format("\r\nMaximum number of waiting clients: {0}",comboBoxListen.Text));
            textBoxDisplay.AppendText("\r\nstart linstening...");
            //4. accept cilent's require
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptClientConnect),socket);

        }

        public void AcceptClientConnect(object socket)
        {
            var serverSocket = socket as Socket;

            while(true)
            {
                var proxSocket = serverSocket.Accept();
                this.appendTextToLog(string.Format("\r\nThe client {0} is connected", proxSocket.RemoteEndPoint.ToString()));
                ClientSocketsList.Add(proxSocket);

                //keep receving client's message
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.receiveClientData),proxSocket);
            }
        }

        public void receiveClientData(object socket)
        {
            var proxSocket = socket as Socket;
            byte[] data = new byte[1024 * 1024];
            while(true)
            {
                int length = 0;
                try
                {
                    length = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch(Exception)
                {
                    //not normal quit
                    this.appendTextToLog(string.Format("\r\n {0} Abnormally quits!", proxSocket.RemoteEndPoint.ToString()));
                    ClientSocketsList.Remove(proxSocket);
                    stopConnect(proxSocket);
                    return; //end this thread
                }

                //display the receieved data into the textBox
                if(length <= 0)
                {
                    //the client quits
                    this.appendTextToLog(string.Format("\r\n{0} normally quits!\n", proxSocket.RemoteEndPoint.ToString()));
                    ClientSocketsList.Remove(proxSocket);
                    stopConnect(proxSocket);
                    return; //end this thread
                }

                string receivedData = Encoding.Default.GetString(data, 0, length);
                this.appendTextToLog(string.Format("\r\nRecived massage from: {0}  {1}", proxSocket.RemoteEndPoint.ToString(),
                    receivedData));
            }
        }

        public void stopConnect(object socket)
        {
            var proxSocket = socket as Socket;
            try
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Shutdown(SocketShutdown.Both);
                    proxSocket.Close(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void appendTextToLog(string text)
        {
            if(textBoxDisplay.InvokeRequired)
            {
                textBoxDisplay.Invoke(new Action<string>(s => {
                    textBoxDisplay.AppendText(s);
                    //textBoxDisplay.Text = string.Format("{0}\r\n{1}", s, textBoxDisplay.Text);
                }), text);
            }
            else
            {
                textBoxDisplay.AppendText(text);
            }
        }

        public string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //ger the name of localhost
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //Filter out IPv4 type IP addresses from the IP address list
                    //AddressFamily.InterNetwork represents IPv4,
                    //AddressFamily.InterNetworkV6 represents IPv6
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP:" + ex.Message);
                return "";
            }
        }

        #region sendText
        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach(var proxSocket in ClientSocketsList)
            {
                if(proxSocket.Connected)
                {
                    byte[] data1 = Encoding.Default.GetBytes(textBoxSend.Text.ToString());
                    textBoxDisplay.AppendText(string.Format("\r\nMessage sent: {0}",textBoxSend.Text));
                    byte[] final = new byte[data1.Length + 1];
                    final[0] = 1;
                    Buffer.BlockCopy(data1, 0, final, 1, data1.Length);
                    proxSocket.Send(final, 0, final.Length,SocketFlags.None);
                }
            }
        }
        #endregion

        private void buttonFlash_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientSocketsList)
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Send(new byte[] {2}, SocketFlags.None);
                }
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            //1. select a file
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() != DialogResult.OK)
                    return;
                byte[] fileData = File.ReadAllBytes(file.FileName);

                byte[] final = new byte[fileData.Length + 1];
                final[0] = 3;
                Buffer.BlockCopy(fileData, 0, final, 1, fileData.Length);
           

                foreach (var proxSocket in ClientSocketsList)
                {
                    if (proxSocket.Connected)
                    {
                        proxSocket.Send(final, SocketFlags.None);
                    }
                }

            }
        }
    }


}
