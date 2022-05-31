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
        public string secondPlayerInitalInfos;
        public GameScreen(bool isHost,int[] diffficulty)
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
            multiplayer = Multiplayer.instance(isHost, gameOverPanel);
            game = multiplayer.game;
            game.createRandomCells(3);
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            p2_panel.Visible = !String.IsNullOrEmpty(secondPlayerInitalInfos);
            this.Bounds = new Rectangle(400, 300, 800, 600);
            gameOverPanel.Size = new Size(this.Bounds.Width/3, this.Bounds.Height);
            gameOverPanel.Location = new Point(this.Bounds.Width / 3);
        }

        private async void StartCounting()
        {
            label1.Location = new Point(this.Bounds.Width / 2 - 70, this.Bounds.Height / 2 - 100);
            for (int i = 3; i >= 0; i--)
            {
                label1.Text = i.ToString();
                await Task.Delay(100 * i + 300);
            }
            label1.Visible = false;
        }

        private void Screen_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < game.Objects.Count; i++)
                this.Controls.Add(game.Objects[i].box);
            this.p1_scorePanel.Controls.Add(game.ScoreBoard);
            game.ScoreBoard.Size = p1_scorePanel.Size;
            p1_name.Text = dataTransfer.Instance.get_account().info[2];
            p1_bestScore.BringToFront();
            p1_bestScore.Text=p1_bestScore.Text.Substring(0, 12).ToString() + dataTransfer.Instance.get_account().info[0].ToString();
            if(!String.IsNullOrEmpty(secondPlayerInitalInfos))
            {
                p2_name.Text = secondPlayerInitalInfos.Split(':').First();
                this.p2_scorePanel.Controls.Add(game.ScoreBoard_for_SecondPlayer);
                game.ScoreBoard_for_SecondPlayer.Size = p2_scorePanel.Size;
                p2_bestScore.BringToFront();
                p2_bestScore.Text = p2_bestScore.Text.Substring(0, 12).ToString() + secondPlayerInitalInfos.Split(':').Last();
            }
            //
            // Sound
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            sound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.BeatSound.wav");
            //sound.PlayLooping();
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
        public void gameOver()
        {
            label3.Text = "YOU WIN !" + Environment.NewLine + ":OPPONENT LEFT:";
            gameOverPanel.Visible = true;
        }
    }

}
