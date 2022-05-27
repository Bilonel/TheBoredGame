using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;

namespace OOP_Lab_II.Game
{
    static class Client
    {
        private static Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        public static Menu.Form_Multiplayer multiplayerForm { get; set; }
        public static void ConnectToServer()
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
            SendRequest(dataTransfer.Instance.get_account().info[2]);
            ClientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveResponse, ClientSocket);
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding.
        /// </summary>
        public static void SendRequest(string text)
        {
            if (text.Equals(null))
                text = "";
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }
        /// <summary>
        /// Receive a string from the server with ASCII encoding.
        /// </summary>
        public static void ReceiveResponse(IAsyncResult AR)
        {
            if (!ClientSocket.Connected)
                return;
            Socket current = (Socket)AR.AsyncState;
            int received = current.EndReceive(AR);
            if (received != 0)
            {
                byte[] recBuf = new byte[received];
                Array.Copy(buffer, recBuf, received);
                string text = Encoding.ASCII.GetString(recBuf);
                if (text.Contains("vs"))
                {
                    string player2Name = text.Split(':').Last();
                    multiplayerForm.ConnectedToPlayer(player2Name);
                }
                else if(text.ToLower().Contains("exited")) // Match EXITED
                {
                    multiplayerForm.MatchOver();
                }
            }
            ClientSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveResponse, ClientSocket);
        }
       

        public static void exit()
        {
            SendRequest("exit");
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
        }
    }
}
