using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket ClientSocket = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ConnectToServer();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendRequest(messageText.Text);
        }
        private void ConnectToServer()
        {
            try
            {
                // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                ClientSocket.Connect(IPAddress.Loopback, PORT);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            connectState.Text = ("Connected");
            SendRequest(nameBox.Text);
            ClientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveResponse, ClientSocket);
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding.
        /// </summary>
        private void SendRequest(string text)
        {
            if (text.Equals(null))
                text = "EMPTY TEXT";
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void ReceiveResponse(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received = current.EndReceive(AR);
            if (received != 0)
            {
                byte[] recBuf = new byte[received];
                Array.Copy(buffer, recBuf, received);
                string text = Encoding.ASCII.GetString(recBuf);
                receivedText.Text = text;
            }
            ClientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveResponse, ClientSocket);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
        }
    }
    //private void Exit()
    //{
    //    SendString("exit"); // Tell the server we are exiting
    //    ClientSocket.Shutdown(SocketShutdown.Both);
    //    ClientSocket.Close();
    //    Environment.Exit(0);
    //}

}

