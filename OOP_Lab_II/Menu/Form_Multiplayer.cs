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
            Game.Client.ConnectToServer();
            Game.Client.multiplayerForm = this;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Game.Client.SendRequest("ready"); // Im ready for the game
            stopBtn.Visible = true;
            
        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Visible = false;
            Game.Client.SendRequest("not ready"); //Im not ready
        }
        public void ConnectedToPlayer(string SecondPlayerName)
        {
            player2Name.Text = SecondPlayerName;
            player2Name.Visible = avatar2.Visible = true;
            stopBtn.Enabled = false;
            stopBtn.Text = "Starting...";
            wait(500);
            gameScreen = (new Game.GameScreen(new int[] { 8, 8, 010, 011 }, SecondPlayerName + ":" + dataTransfer.Instance.readUser(SecondPlayerName)[0]));
            gameScreen.ShowDialog();
        }
        public void MatchOver()
        {
            gameScreen.gameOver();
        }
        private void Form_Multiplayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.Client.exit();
        }
        private void wait(int milliseconds)
        {
            var timer1 = new Timer();   // Create a timer
            if (milliseconds == 0 || milliseconds < 0) return;  // If its not Valid , finish function
            //
            // Star Timer
            timer1.Interval = milliseconds; // Set count
            timer1.Enabled = true;
            timer1.Start(); // Start

            timer1.Tick += (s, e) => { timer1.Enabled = false; timer1.Stop(); }; // After Waiting; Stop Timer

            while (timer1.Enabled)  // While Timer Waiting; Waited Everything
                Application.DoEvents();
        }
    }
}
