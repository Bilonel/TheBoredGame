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
        private static List<player> AllPlayers = new List<player>();
        private static List<player> StandPlayers = new List<player>();
        private player player_readyToPlay = null;
        private Dictionary<player,player> Pairs = new Dictionary<player, player>();



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
                // BEGIN RECEIVE FOR PLAYER NAME
                currentPlayer.socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, recievePlayerName, currentPlayer.socket);
                while(String.IsNullOrEmpty(currentPlayer.name))
                {
                    // WAIT UNTIL PLAYER NAME SETTED
                }
                serverSocket.BeginAccept(AcceptCallback, null);
                // FINALLY ADD IT TO STAND PLAYERS
                StandPlayers.Add(currentPlayer);

                if (!String.IsNullOrEmpty(currentPlayer.name))
                {
                    playersBox.Items.Add(currentPlayer.name);
                    standBox.Items.Add(currentPlayer.name);
                }
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
            player _player = find((Socket)AR.AsyncState);
            int received;

            try
            {
                received = _player.socket.EndReceive(AR);
            }
            catch (SocketException)
            {
                _player.socket.Close();
                remove(_player);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            receviedMessage.Text= text;
            if (text.ToLower() == "exit") // Client wants to exit gracefully
            {
                // Always Shutdown before closing
                remove(_player);
                _player.socket.Shutdown(SocketShutdown.Both);
                _player.socket.Close();
                return;
            }
            else if (text.Contains("*")) // Client requested time
            {
                if (_player != null && Pairs.ContainsKey(_player))
                {
                    byte[] data = Encoding.ASCII.GetBytes(text);
                    Pairs[_player].socket.Send(data);
                }
            }
            else if(text.ToLower().Contains("ready"))
            {
                if(text.ToLower().Contains("not") && _player== player_readyToPlay)  // Player is not ready then move it to stand list
                {
                    player_readyToPlay = null;
                    readyBox.Items.Clear();
                    standBox.Items.Add(_player.name);
                    StandPlayers.Add(_player);
                }
                else if(StandPlayers.Contains(_player)) // Player is ready and is in Stand list
                {
                    if(player_readyToPlay==null) // IF THERE IS NOT ANOTHER READY PLAYER, CURRENT PLAYER WILL STAND BY
                    {
                        player_readyToPlay = _player;
                        readyBox.Items.Add(_player.name);
                    }
                    else
                    { // IF THERE IS A STAND PLAYER PAIR THEM (CURRENT PLAYER AND READY PLAYER)
                        CreatePair(player_readyToPlay, _player);
                        readyBox.Items.Clear();
                        player_readyToPlay = null;
                    }
                    standBox.Items.RemoveAt(standBox.FindString(_player.name));
                    StandPlayers.Remove(_player);
                }
            }
            
            _player.socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, _player.socket);
        }
        private void CreatePair(player firstPlayer,player secondPlayer)
        {
            Pairs.Add(firstPlayer, secondPlayer);
            Pairs.Add(secondPlayer, firstPlayer);
            if (!String.IsNullOrEmpty(firstPlayer.name) && !String.IsNullOrEmpty(secondPlayer.name))
                pairsBox.Items.Add(firstPlayer.name + "  vs  " + secondPlayer.name);

            firstPlayer.socket.Send(Encoding.ASCII.GetBytes("vs :" + secondPlayer.name));
            secondPlayer.socket.Send(Encoding.ASCII.GetBytes("vs :" + firstPlayer.name));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetupServer();
        }
        private void remove(player current)
        {
            int index;
            index = AllPlayers.IndexOf(current);
            AllPlayers.RemoveAt(index);
            index = playersBox.Items.IndexOf(current.name);
            playersBox.Items.RemoveAt(index);
            index = standBox.Items.IndexOf(current.name);
            if (index != -1)
            {
                standBox.Items.RemoveAt(index);
                StandPlayers.RemoveAt(index);
            }
            if(player_readyToPlay==current)
            {
                player_readyToPlay = null;
                readyBox.Items.Clear();
            }
            if(Pairs.ContainsKey(current))
            {
                player secondPlayer = Pairs[current];
                Pairs.Remove(current);
                Pairs.Remove(secondPlayer);
                index = pairsBox.Items.IndexOf(current.name + "  vs  " + secondPlayer.name);
                if(index==-1) index = pairsBox.Items.IndexOf(secondPlayer.name + "  vs  " + current.name);
                if (index != -1) pairsBox.Items.RemoveAt(index);
            }
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

    }
}

