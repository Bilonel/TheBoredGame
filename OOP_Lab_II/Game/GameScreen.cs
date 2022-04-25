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
        public GameScreen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            game = new Game(6, 6);
        }

        private async void StartCounting()
        {
            label1.Location = new Point(this.Bounds.Width / 2 - 70, this.Bounds.Height / 2 - 100);
            for (int i = 3; i >= 0; i--)
            {
                label1.Text = i.ToString();
                await Task.Delay(200 * i + 400);
            }
            label1.Visible = false;
            for (int i = 0; i < game.Objects.Count; i++)
                this.Controls.Add(game.Objects[i].box);
        }

        private void Screen_Shown(object sender, EventArgs e)
        {
            StartCounting();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
