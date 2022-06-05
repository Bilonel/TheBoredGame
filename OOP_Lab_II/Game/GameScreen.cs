using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Game
{
    public partial class GameScreen : Form
    {
        Multiplayer multiplayer;
        Game game;
        int row, col;
        List<int> GameInitialIds;
        public static bool refreshed;
        public string OpponentInfos=null;
        private bool isHost;
        public GameScreen(int[] diffficulty, bool isMute = false)
        {
            InitializeComponent();
            refreshed = false;
            GameInitialIds = new List<int>();
            this.row = diffficulty[0]; this.col = diffficulty[1];
            for (int i = 0; i < 3; i++)
            {
                int colors = diffficulty[3];
                if (diffficulty[2] % 10 == 1)
                    for (int k = 2; k < 5; k++)
                    {
                        if (colors % 10 == 1)
                            GameInitialIds.Add(i * 3 + k);
                        colors /= 10;
                    }
                diffficulty[2] /= 10;
            }
            game = new Game(row, col, GameInitialIds, false, this, isMute);
        }
        public GameScreen(bool isHost,bool isMute=false,string Opponent=":",System.Net.IPAddress IP=null,int port=0)
        {
            InitializeComponent();
            refreshed = false;this.isHost = isHost;
            OpponentInfos = Opponent;
            multiplayer = Multiplayer.instance(IP,port,isHost, this,isMute);   // Initialize Multiplayer
            //
            //Delete User from Host List
            //
            (new Data.HostConnectServer()).deleteHost(dataTransfer.Instance.get_account().Username);
            //
            // Start the game with 3 random cells
            //
            game = multiplayer.game;
        }
        private void Screen_Load(object sender, EventArgs e)
        {
            p2_panel.Visible = !String.IsNullOrEmpty(OpponentInfos);
            gameOverPanel.Size = new Size(this.Bounds.Width/2, this.Bounds.Height);
            gameOverPanel.Location = new Point(this.Bounds.Width / 4);
        }
        private void Screen_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < game.Objects.Count; i++)
                this.Controls.Add(game.Objects[i].box);
            this.p1_scorePanel.Controls.Add(game.ScoreBoard);
            game.ScoreBoard.Size = p1_scorePanel.Size;
            game.ScoreBoard.BringToFront();
            p1_name.Text = dataTransfer.Instance.get_account().Username;
            p1_bestScore.BringToFront();
            p1_bestScore.Text=p1_bestScore.Text.Substring(0, 12).ToString() + dataTransfer.Instance.get_account().BestScore.ToString();
            if (!String.IsNullOrEmpty(OpponentInfos))
            {
                this.p1_panel.Controls.Add(multiplayer.InfoLabel);
                multiplayer.InfoLabel.BringToFront();
                p2_name.Text = OpponentInfos.Split(':').First();
                this.p2_scorePanel.Controls.Add(game.ScoreBoard_for_SecondPlayer);
                game.ScoreBoard_for_SecondPlayer.Size = p2_scorePanel.Size;
                p2_bestScore.BringToFront();
                p2_bestScore.Text = p2_bestScore.Text.Substring(0, 12).ToString() + OpponentInfos.Split(':').Last();
            }
            //
            // Sound
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            //sound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.BeatSound.wav");
            //sound.PlayLooping();
            if (isHost)
                game.createRandomCells(multiplayer.NumberOfRandomCells);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshed = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (String.IsNullOrEmpty(OpponentInfos))
                return;
            multiplayer.Receiver.WorkerSupportsCancellation = true;
            multiplayer.Receiver.CancelAsync();
            if (multiplayer.server != null)
                multiplayer.server.Stop();
        }
        public void gameOver()
        {
            Action worker = delegate () { System.Threading.Thread.Sleep(1); };
            Action dg;
            if (String.IsNullOrEmpty(OpponentInfos)) 
                dg = delegate () { showGameOverPanelSinglePlayer(); };
            else 
                dg = delegate () { showGameOverPanel(); };
            AsyncCallback cb = delegate (IAsyncResult ar) { gameOverPanel.Invoke(dg); worker.EndInvoke(ar); };
            worker.BeginInvoke(cb, null);
        }
        private void showGameOverPanel()
        {
            int score1 = int.Parse(game.ScoreBoard.Text.Split(':')[1]);
            int score2 = int.Parse(game.ScoreBoard_for_SecondPlayer.Text.Split(':')[1]);

            if (score1 > score2)
            { 
                score.Text = "WELL DONE"+ Environment.NewLine + " YOU WIN ";
                gameOverPanel.BackColor = Color.SeaGreen;
            }
            else if (score1 < score2) 
            {
                score.Text = "PfffHHHH" + Environment.NewLine + " LOSER ";
                gameOverPanel.BackColor = Color.Firebrick;
            }
            else score.Text = "BORING" + Environment.NewLine + " DRAW ";
            if (dataTransfer.Instance.isHighestScore(score1))
                score.Text += Environment.NewLine+ Environment.NewLine + "New BestScore: " + score1.ToString();

            gameOverPanel.Visible = true;
        }
        private void showGameOverPanelSinglePlayer()
        {
            int score1 = int.Parse(game.ScoreBoard.Text.Split(':')[1]);
            if (dataTransfer.Instance.isHighestScore(score1))
                score.Text = Environment.NewLine + Environment.NewLine + "New Best Score = " + score1.ToString();
            else score.Text = Environment.NewLine + " Score : " + score1.ToString();
            gameOverPanel.Visible = true;
        }
    }

}
