using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Menu
{
    public partial class Form_Multiplayer : Form
    {
        // Field
        Game.GameScreen gameScreen;
        public Form_Multiplayer()
        {
            InitializeComponent();
        }
        // METHODS

        private void Form_Multiplayer_Load(object sender, EventArgs e)
        {
            player1Name.Text = dataTransfer.Instance.get_account().info[2];
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            gameScreen =new Game.GameScreen(false,new int[] { 8, 8, 010, 011 });
            this.ParentForm.Visible = false;
            if (!gameScreen.IsDisposed)
                gameScreen.ShowDialog();
            this.ParentForm.Visible = true;
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            gameScreen = new Game.GameScreen(true, new int[] { 8, 8, 010, 011 });
            this.ParentForm.Visible = false;
            if (!gameScreen.IsDisposed)
                gameScreen.ShowDialog();
            this.ParentForm.Visible = true;
        }
    }
}
