using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace server
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<player> AllPlayers = new List<player>();
        
        private Dictionary<player,player> Pairs = new Dictionary<player, player>();

        private player StandPlayer=null;


        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];


        private void SetupServer()
        {
            try
            {
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
                serverSocket.Listen(0);
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch(SocketException ex)
            {
                MessageBox.Show(ex.SocketErrorCode.ToString());
            }
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        
        private  void AcceptCallback(IAsyncResult AR)   // NEW CLIENT JOINED
        {
            player currentPlayer=new player();  // NEW CURRENT CLIENT

            try
            {
                currentPlayer.socket = serverSocket.EndAccept(AR); // CLIENT JOINED GET SOCKET AND CLOSE ACCEPT
                AllPlayers.Add(currentPlayer); 
                try { 
                currentPlayer.socket.EndReceive(AR);    // IF THERE IS A ACTIVE RECEIVE THEN CLOSE IT
                }
                catch (Exception) { }
                // BEGIN RECEIVE FOR PLAYER NAME AND ACCEPT PLAYERS
                currentPlayer.socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, recievePlayerName, currentPlayer.socket);
                while(String.IsNullOrEmpty(currentPlayer.name))
                {

                }
                // Send to socket a message about Server Socket's receive is available
                serverSocket.BeginAccept(AcceptCallback, null);

                if (StandPlayer == null)    // IF THERE IS NO STAND PLAYER, CURRENT PLAYER WILL STAND BY
                {
                    StandPlayer = currentPlayer;
                    if(!String.IsNullOrEmpty(StandPlayer.name))
                        standBox.Items.Add(StandPlayer.name);

                }
                else    // IF THERE IS A STAND PLAYER PAIR THEM (CURRENT PLAYER AND STAND PLAYER)
                {
                    Pairs.Add(StandPlayer, currentPlayer);
                    Pairs.Add(currentPlayer, StandPlayer);
                    if (!String.IsNullOrEmpty(StandPlayer.name)&& !String.IsNullOrEmpty(currentPlayer.name))
                        pairsBox.Items.Add(StandPlayer.name + "  vs  " + currentPlayer.name);
                    standBox.Items.Clear();
                    StandPlayer = null;
                }
                if (!String.IsNullOrEmpty(AllPlayers[AllPlayers.Count - 1].name))
                    playersBox.Items.Add(AllPlayers[AllPlayers.Count - 1].name);
                // PLAYER NAME TAKEN SO BEGIN RECEIVE FOR OTHER DATAS
                currentPlayer.socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, currentPlayer.socket);
            }
            catch (Exception ex) // 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void recievePlayerName(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received = current.EndReceive(AR);
            
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            AllPlayers[AllPlayers.Count - 1].name = text;
        }
        private  void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                MessageBox.Show("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            receviedMessage.Text= text;

            if (text.Contains("*")) // Client requested time
            {
                player CurrentPlayer = find(current);
                if (CurrentPlayer != null && Pairs.ContainsKey(CurrentPlayer))
                {
                    byte[] data = Encoding.ASCII.GetBytes(text);
                    Pairs[CurrentPlayer].socket.Send(data);
                }
            }
            //else if (text.ToLower() == "exit") // Client wants to exit gracefully
            //{
            //    // Always Shutdown before closing
            //    current.Shutdown(SocketShutdown.Both);
            //    current.Close();
            //    clientSockets.Remove(current);
            //    MessageBox.Show("Client disconnected");
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Text is an invalid request");
            //    byte[] data = Encoding.ASCII.GetBytes("Invalid request");
            //    current.Send(data);
            //    MessageBox.Show("Warning Sent");
            //}

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupServer();
        }
        private void remove(Socket current)
        {
            try
            {
                foreach(var p in AllPlayers)
                    if (p.socket == current)
                        AllPlayers.Remove(p);
            }
            catch (Exception) { }
        }
        private player find(Socket socket)
        {
            foreach (var p in AllPlayers)
            {
                if (p.socket == socket)
                    return p;
            }
            return null;
        }
        
        public class player
        {
            public Socket socket { get; set; }
            public String name { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupServer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player first = AllPlayers[0];
            player second = Pairs[find(first.socket)];
            MessageBox.Show(first.name+" -> " +second.name);
        }
    }
}

