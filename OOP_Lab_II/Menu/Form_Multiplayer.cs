using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
=======
using System.Drawing;
using System.Net;
using System.Net.Sockets;
>>>>>>> Test2_Coop
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Menu
{
    public partial class Form_Multiplayer : Form
    {
<<<<<<< HEAD
        // Field
        Game.GameScreen gameScreen;
=======
        int Port;
        // Field
        Game.GameScreen gameScreen;
        Data.Host host;
>>>>>>> Test2_Coop
        public Form_Multiplayer()
        {
            InitializeComponent();
        }
        // METHODS

        private void Form_Multiplayer_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            int count = 0;
            foreach (Data.Host item in (new Data.HostConnectServer()).getList())
            {
                Data.HostPanel hostPanel = new Data.HostPanel(item, count++);
                hostPanel.InviteButton.Click+= new System.EventHandler(this.Invite_Click);
                HostsPanel.Controls.Add(hostPanel.MainPanel);
            }
        }
        private void Invite_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.Enabled = false;
            currentButton.Text = "INVITED";
            currentButton.BackColor = Color.FromArgb(140, 90, 110);
            string OpponentsUsername = currentButton.Parent.Controls[2].Text;
            host = (new Data.HostConnectServer()).getHost(OpponentsUsername);
            (new Data.HostConnectServer()).SendRequest(OpponentsUsername, dataTransfer.Instance.get_account().info[2]);
            MessageLabel.Text = "Waiting For " + OpponentsUsername.ToUpper() +"'s Response";
            acceptChallengeButton.Visible = false;
            InitedPanel.Visible = true;
            WaitResponseOfHost(OpponentsUsername);
        }
        private void ConnectToHost()
        {
            string Host_IP = host.IP;
            string Host_Port = host.Port;
            string HostInfo = host.Username + ":" + host.BestScore;
            gameScreen =new Game.GameScreen(false,new int[] { 8, 8, 010, 011 },((Button)ParentForm.Controls[1]).Image!=null, HostInfo, IPAddress.Parse(Host_IP),int.Parse(Host_Port));

            this.ParentForm.Visible = false;
            Menu_Form parent = (Menu_Form)this.ParentForm;
            if (!gameScreen.IsDisposed)
                gameScreen.ShowDialog();
            try
            {
                Game.Multiplayer.instance().sock.Shutdown(SocketShutdown.Both);
                Game.Multiplayer.instance(null, -1923);
                parent.exitPopup_Click(null, null);
            }
            catch (Exception) { }
            parent.Visible = true;
>>>>>>> Test2_Coop
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            gameScreen = new Game.GameScreen(true, new int[] { 8, 8, 010, 011 });
            this.ParentForm.Visible = false;
            if (!gameScreen.IsDisposed)
                gameScreen.ShowDialog();
            this.ParentForm.Visible = true;
        }
=======
            Port = 5732;
            sendHostInfoToServer();
            MessageLabel.Text ="Waiting For An Opponent";
            acceptChallengeButton.Visible = false;
            InitedPanel.Visible = true;
            string challenger = WaitResponseOfChallenger(dataTransfer.Instance.get_account().info[2]);
            MessageLabel.Text = challenger + " Challenged To You";
            acceptChallengeButton.Visible = true;
            datLabel.Visible = false;
        }
        private void acceptChallengeButton_Click(object sender, EventArgs e)
        {
            string challengerName =(new Data.HostConnectServer()).getChallengerName(dataTransfer.Instance.get_account().info[2]);
            string challengerBestScore = dataTransfer.Instance.readUser(challengerName)[0];
            string challengerInfo = challengerName + ":" + challengerBestScore;
            (new Data.HostConnectServer()).SendRequest(dataTransfer.Instance.get_account().info[2],"accepted");
            gameScreen = new Game.GameScreen(true, new int[] { 8, 8, 010, 011 }, ((Button)ParentForm.Controls[1]).Image != null, challengerInfo, GetLocalIP(), Port);
            Form parent = this.ParentForm;
            parent.Visible = false;
            if (!gameScreen.IsDisposed)
                gameScreen.ShowDialog();
            Game.Multiplayer.instance(null, -1923);
            try
            {
                ((Menu_Form)this.ParentForm).exitPopup_Click(null, null);
            }
            catch (Exception) { }
            parent.Visible = true;
        }
        private void sendHostInfoToServer()
        {
            string Host_Username = dataTransfer.Instance.get_account().info[2];
            string Host_BestScore = dataTransfer.Instance.get_account().info[0];
            string Host_IP = GetLocalIP().ToString();
            string Host_Port = Port.ToString();
            Data.HostConnectServer hostConnect = new Data.HostConnectServer();
            hostConnect.addHost(new string[] { Host_Username, Host_BestScore, Host_IP, Host_Port });
        }
        public static IPAddress GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("There is No Network Adapters in the System!");
        }
        private void showPanel_Click(object sender, EventArgs e)
        {
            showGamesButton.Enabled = !showGamesButton.Enabled;
            showHostsButton.Enabled = !showHostsButton.Enabled;
            GamesPanel.Visible = !GamesPanel.Visible;
            HostsPanel.Visible = !HostsPanel.Visible;
            System.Drawing.Color color = showHostsButton.BackColor;
            showHostsButton.BackColor = showGamesButton.BackColor;
            showGamesButton.BackColor = color;
        }
        private string WaitResponseOfChallenger(string username)
        {
            if (datLabel.Text == "lll") datLabel.Text = "l";
            else datLabel.Text += "l";
            wait();
            string challengerName = (new Data.HostConnectServer()).getChallengerName(username);
            if(challengerName.Length>0)
                return (new Data.HostConnectServer()).getChallengerName(username);
            return WaitResponseOfChallenger(username);
        }
        private void WaitResponseOfHost(string username)
        {
            if (datLabel.Text == "lll") datLabel.Text = "l";
            else datLabel.Text += "l";
            wait();
            string challengerName = (new Data.HostConnectServer()).getChallengerName(username);
            if (challengerName.ToLower()=="accepted")
                ConnectToHost();
            else WaitResponseOfHost(username);
        }
        private void wait()
        {
            var timer1 = new Timer();   // Create a timer
            //
            // Star Timer
            timer1.Interval = 333; // Set count
            timer1.Enabled = true;
            timer1.Start(); // Start

            timer1.Tick += (s, e) => { timer1.Enabled = false; timer1.Stop(); }; // After Waiting; Stop Timer

            while (timer1.Enabled)  // While Timer Waiting; Waited Everything
                Application.DoEvents();
        }

>>>>>>> Test2_Coop
    }
}
