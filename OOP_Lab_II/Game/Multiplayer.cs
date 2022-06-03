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
<<<<<<< HEAD
        private const int bufferSize = 2048;
=======
        bool isHost;
        private const int bufferSize = 2048;
        public int NumberOfRandomCells = 3;
>>>>>>> Test2_Coop
        public Game game;
        public Label InfoLabel;

        public BackgroundWorker Receiver = new BackgroundWorker();
        public Socket sock;
<<<<<<< HEAD
        private TcpListener server = null;
        private TcpClient client;
        private Multiplayer(bool isHost,Panel gameOverPanel=null)
        {
            game = new Game(9, 9, new List<int>() { 5, 6, 7, 8, 9, 10 }, true,gameOverPanel);
            InfoLabel = new Label();
            InfoLabel.Location = new Point(40, 500);
            
=======
        public TcpListener server = null;
        private TcpClient client;
        private Multiplayer(System.Net.IPAddress IP,int Port, bool isHost, GameScreen gameScreen = null,bool isMute=false)
        {
            game = new Game(9, 9, new List<int>() { 5, 6, 7, 8, 9, 10 }, true, gameScreen, isMute);
            InfoLabel = new Label();
            InfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            InfoLabel.Dock = DockStyle.Top;
            InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0F);
            InfoLabel.AutoSize = false;
            InfoLabel.Size = new Size(InfoLabel.Size.Width,48);
            InfoLabel.BackColor = Color.FromArgb(60, 100, 40, 50);
            this.isHost = isHost;
>>>>>>> Test2_Coop
            Receiver.DoWork += Receiver_DoWork;
            Control.CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
<<<<<<< HEAD
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
=======
                server = new TcpListener(IP, Port);
                server.Start();
                sock = server.AcceptSocket();
                InfoLabel.Text = "Your Turn";
>>>>>>> Test2_Coop
            }
            else
            {
                try
                {
                    client = new TcpClient("", 5732);
                    sock = client.Client;
                    Receiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private static Multiplayer Ins=null;
<<<<<<< HEAD
        public static Multiplayer instance(bool isHost=false, Panel gameOverPanel = null)
        {
            if (Ins == null)
                Ins = new Multiplayer(isHost, gameOverPanel);
=======
        public static Multiplayer instance(System.Net.IPAddress IP=null, int Port=0, bool isHost=false, GameScreen gameScreen = null,bool isMute=false)
        {
            if (Ins == null)
                Ins = new Multiplayer(IP,Port,isHost, gameScreen, isMute);
            else if (Port == -1923)
                Ins = null;
>>>>>>> Test2_Coop
            return Ins;
        }

        private void Receiver_DoWork(object sender, DoWorkEventArgs e)
        {
            Freeze_UnfreezeBoard();//////////////
<<<<<<< HEAD
            ReceiveRandomCells();
            //if (game.gameOver())
            //    return;
            //Opponent's Turn!
            ReceiveClickedCell();
            ReceiveMove();
            //Your Turn!
            game.createRandomCells(3);
=======
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
>>>>>>> Test2_Coop
            Freeze_UnfreezeBoard();
        }

        private void Freeze_UnfreezeBoard()
        {
            foreach (var item in game.Objects)
                item.box.Enabled = !item.box.Enabled;
        }
<<<<<<< HEAD

=======
>>>>>>> Test2_Coop
        private void ReceiveClickedCell()
        {
            byte[] clickedCell = new byte[bufferSize];
            while(!Encoding.ASCII.GetString(clickedCell).Contains("click")) sock.Receive(clickedCell);
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
<<<<<<< HEAD
            while (!Encoding.ASCII.GetString(targetCell).Contains("move")) sock.Receive(targetCell);
=======
            sock.Receive(targetCell);
>>>>>>> Test2_Coop
            string text = Encoding.ASCII.GetString(targetCell).Split(':').Last();
            int TargetRow = int.Parse(text.Split(',').First());
            int TargetCol = int.Parse(text.Split(',').Last());
            ///
            /// SET TARGET CELL AS CLICKED

            game.ClickMove(game.Objects[TargetRow * 9 + TargetCol].box, EventArgs.Empty);
        }
        private void ReceiveRandomCells()
        {
<<<<<<< HEAD
            int i = 0;
            byte[] buffer = new byte[bufferSize];
            while (!Encoding.ASCII.GetString(buffer).ToLower().Contains("random")) sock.Receive(buffer);
            
            string text = Encoding.ASCII.GetString(buffer).Split('m').Last().Split('\0').First().Substring(1);
            foreach (var CellData in text.Split(':'))
            {
                if ((++i)>3 || CellData.Length<3)
                    return;
                int Cell_Row = int.Parse(CellData.Split(',')[0]);
                int Cell_Col = int.Parse(CellData.Split(',')[1]);
                int Cell_Id = int.Parse(CellData.Split(',')[2]);
                game.createRandomCell(Cell_Row, Cell_Col, Cell_Id);
            }
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Receiver.WorkerSupportsCancellation = true;
            Receiver.CancelAsync();
            if (server != null)
                server.Stop();
=======
            byte[] buffer = new byte[bufferSize];
            sock.Receive(buffer);

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
>>>>>>> Test2_Coop
        }

    }
}
