using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace OOP_Lab_II.Game
{
    public class Multiplayer
    {
        bool isHost;
        private const int bufferSize = 2048;
        public int NumberOfRandomCells = 20;
        public Game game;
        public Label InfoLabel;

        public BackgroundWorker Receiver = new BackgroundWorker();
        public Socket _socket;
        public TcpListener server = null;
        private TcpClient client;
        private Multiplayer(System.Net.IPAddress IP,int Port, bool isHost, GameScreen gameScreen = null,bool isMute=false)
        {
            game = new Game(9, 9, new List<int>() { 2,3,4,5, 6, 7, 8, 9, 10 }, true, gameScreen, isMute);
            InfoLabel = new Label();
            InfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            InfoLabel.Dock = DockStyle.Top;
            InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0F);
            InfoLabel.AutoSize = false;
            InfoLabel.Size = new Size(InfoLabel.Size.Width,48);
            InfoLabel.BackColor = Color.FromArgb(60, 100, 40, 50);
            this.isHost = isHost;
            Receiver.DoWork += Receiver_DoWork;
            Control.CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                server = new TcpListener(IP, Port);
                server.Start();
                _socket = server.AcceptSocket();
                InfoLabel.Text = "Your Turn";
            }
            else
            {
                try
                {
                    client = new TcpClient("", 5732);
                    _socket = client.Client;
                    Receiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private static Multiplayer Ins=null;
        public static Multiplayer instance(System.Net.IPAddress IP=null, int Port=0, bool isHost=false, GameScreen gameScreen = null,bool isMute=false)
        {
            if (Ins == null)
                Ins = new Multiplayer(IP,Port,isHost, gameScreen, isMute);
            else if (Port == -1923)
                Ins = null;
            return Ins;
        }

        private void Receiver_DoWork(object sender, DoWorkEventArgs e)
        {
            Freeze_UnfreezeBoard();//////////////
            //Opponent's Turn!
            InfoLabel.Text = "Opponents Turn";
            ReceiveRandomCells();
            if (game.gameOver())   // IS GAME OVER ?
                return;
            ReceiveClickedCell();
            ReceiveMove();
            //Your Turn!
            InfoLabel.Text = "Your Turn";
            game.createRandomCells(NumberOfRandomCells);
            if (game.gameOver())   // IS GAME OVER ?
                return;
            Freeze_UnfreezeBoard();
        }

        private void Freeze_UnfreezeBoard()
        {
            foreach (var item in game.Objects)
                item.box.Enabled = !item.box.Enabled;
        }
        private void ReceiveClickedCell()
        {
            byte[] clickedCell = new byte[bufferSize];
            while(!Encoding.ASCII.GetString(clickedCell).Contains("click")) _socket.Receive(clickedCell);
            string text = Encoding.ASCII.GetString(clickedCell).Split(':').Last();
            int ClickedRow = int.Parse(text.Split(',').First());
            int ClickedCol = int.Parse(text.Split(',').Last());
            ///
            /// SET TARGET CELL AS CLICKED
            
            game.ClickCell(game.Objects[ClickedRow * 9 + ClickedCol].box, EventArgs.Empty);
        }
        private void ReceiveMove()
        {
            byte[] targetCell = new byte[bufferSize];
            _socket.Receive(targetCell);
            string text = Encoding.ASCII.GetString(targetCell).Split(':').Last();
            int TargetRow = int.Parse(text.Split(',').First());
            int TargetCol = int.Parse(text.Split(',').Last());
            ///
            /// SET TARGET CELL AS CLICKED

            game.ClickMove(game.Objects[TargetRow * 9 + TargetCol].box, EventArgs.Empty);
        }
        private void ReceiveRandomCells()
        {
            byte[] buffer = new byte[bufferSize];
            _socket.Receive(buffer);

            string text = Encoding.ASCII.GetString(buffer).Split(':').Last().Split('\0').First();
            text =text.Substring(0, text.Length - 1);
            foreach (var item in text.Split(';'))
            {
                if (text.Length < 5)
                    return;
                int Cell_Row = int.Parse(item.Split(',')[0]);
                int Cell_Col = int.Parse(item.Split(',')[1]);
                int Cell_Id = int.Parse(item.Split(',')[2]);
                game.createRandomCell(Cell_Row, Cell_Col, Cell_Id);
            }

            //for(int i=0;i< NumberOfRandomCells;i++)
            //{
            //    byte[] buffer = new byte[bufferSize];
            //    sock.Receive(buffer);

            //    string text = Encoding.ASCII.GetString(buffer).Split(':').Last().Split('\0').First();
            //    if (text.Length<5)
            //        return;
            //    int Cell_Row = int.Parse(text.Split(',')[0]);
            //    int Cell_Col = int.Parse(text.Split(',')[1]);
            //    int Cell_Id = int.Parse(text.Split(',')[2]);
            //    game.createRandomCell(Cell_Row, Cell_Col, Cell_Id);
            //}
        }

    }
}
