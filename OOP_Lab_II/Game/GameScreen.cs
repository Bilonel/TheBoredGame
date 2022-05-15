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
        Game game;
        int row, col;
        List<int> GameInitialIds;
        public static bool refreshed;
        public GameScreen(int[] diffficulty)
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
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            gameOverPanel.Size = new Size(this.Bounds.Width/3, this.Bounds.Height);
            gameOverPanel.Location = new Point(this.Bounds.Width / 3);
            game = new Game(row, col, GameInitialIds,this.gameOverPanel);
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
            for (int i = 0; i < game.Objects.Count; i++)
                this.Controls.Add(game.Objects[i].box);
            this.Controls.Add(game.ScoreBoard);
        }

        private void Screen_Shown(object sender, EventArgs e)
        {
            StartCounting();
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            sound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.BeatSound.wav");
            sound.PlayLooping();
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
    }

}
