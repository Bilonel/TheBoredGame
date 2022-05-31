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
        private const int bufferSize = 2048;
        public Game game;
        public Label InfoLabel;

        public BackgroundWorker Receiver = new BackgroundWorker();
        public Socket sock;
        private TcpListener server = null;
        private TcpClient client;
        private Multiplayer(bool isHost,Panel gameOverPanel=null)
        {
            game = new Game(9, 9, new List<int>() { 5, 6, 7, 8, 9, 10 }, true,gameOverPanel);
            InfoLabel = new Label();
            InfoLabel.Location = new Point(40, 500);
            
            Receiver.DoWork += Receiver_DoWork;
            Control.CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
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
        public static Multiplayer instance(bool isHost=false, Panel gameOverPanel = null)
        {
            if (Ins == null)
                Ins = new Multiplayer(isHost, gameOverPanel);
            return Ins;
        }

        private void Receiver_DoWork(object sender, DoWorkEventArgs e)
        {
            Freeze_UnfreezeBoard();//////////////
            ReceiveRandomCells();
            //if (game.gameOver())
            //    return;
            //Opponent's Turn!
            ReceiveClickedCell();
            ReceiveMove();
            //Your Turn!
            game.createRandomCells(3);
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
            while (!Encoding.ASCII.GetString(targetCell).Contains("move")) sock.Receive(targetCell);
            string text = Encoding.ASCII.GetString(targetCell).Split(':').Last();
            int TargetRow = int.Parse(text.Split(',').First());
            int TargetCol = int.Parse(text.Split(',').Last());
            ///
            /// SET TARGET CELL AS CLICKED

            game.ClickMove(game.Objects[TargetRow * 9 + TargetCol].box, EventArgs.Empty);
        }
        private void ReceiveRandomCells()
        {
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
        }

    }
}
