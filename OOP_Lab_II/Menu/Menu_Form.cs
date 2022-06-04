using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
namespace OOP_Lab_II.Menu
{
    public partial class Menu_Form : Form
    {
        //Fields
        //
        private XmlDocument xmlDoc;
        private Button currentActiveButton;
        private Form currentForm;
        public static System.Media.SoundPlayer sound;
        private const int formInitWidth = 700;
        private const int formInitHeight = 525;
        //
        //Constructor
        //
        public Menu_Form()
        {
            InitializeComponent();
            usernameLabel.Text = dataTransfer.Instance.get_account().info[2].ToUpper();
        }
        //
        // Methods

        private void activateButton(object button)
        {
            if (currentActiveButton != null) // Deactivate old one
                currentActiveButton.BackgroundImageLayout = ImageLayout.Stretch;
            if (button != null)    // Activate new one
            {
                currentActiveButton = (Button)button;
                currentActiveButton.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
        private void activateForm(Form newForm)
        {
            this.popup.Visible = true;
            // Close Old One
            this.windowPanel.Controls.Clear();
            if (currentForm != null)
                currentForm.Close();
            // Open New One
            currentForm = newForm;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            this.windowPanel.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }
        private void panel_enter(object sender, EventArgs e)
        {
            profile.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void panel_leave(object sender, EventArgs e)
        {
            profile.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void button_Enter(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void button_Leave(object sender, EventArgs e)
        {
            activateButton(null);
        }
        // CLICK METHODS
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void optionsButton_Click(object sender, EventArgs e)
        {
            activateForm(new Form_Options());
        }
        private void play_click(object sender, EventArgs e)
        {
            activateForm(new Form_Play());
        }
        private void multiButton_Click(object sender, EventArgs e)
        {
            activateForm(new Form_Multiplayer());
        }
        private void creditsButton_Click(object sender, EventArgs e)
        {
            activateForm(new Form_About());
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            activateForm(dataTransfer.Instance.get_account().Form);
        }

        private void profile_Click(object sender, EventArgs e)
        {
            activateForm(dataTransfer.Instance.get_account().Form);
        }
        private void Menu_Form_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.SetToolTip(this.profile, "Click to Profile");
            tt.SetToolTip(this.avatarBox, "is You ?");
            xmlDoc = new XmlDocument();
            xmlDoc.Load("Data/localSave.xml");
            save_password_panel_timer();
            sound = new System.Media.SoundPlayer();
            sound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.GuitarSound.wav");
            sound.PlayLooping();
        }
        private void save_password_panel_timer()
        {
            if (xmlDoc.SelectSingleNode("Settings/Password/apply").InnerText == "0")
            {
                Action worker = delegate () { System.Threading.Thread.Sleep(5000); };
                Action dg = delegate () { save_password_panel_close(null, null); };
                AsyncCallback cb = delegate (IAsyncResult ar) { save_password_panel.Invoke(dg); worker.EndInvoke(ar); };
                worker.BeginInvoke(cb, null);
            }
            else
                save_password_panel.Visible = false;
        }
        private void save_password_panel_close(object sender, EventArgs e)
        {
            if (save_password_panel.Visible)
            {
                xmlDoc.SelectSingleNode("Settings/Password/value").InnerText = "";
                xmlDoc.SelectSingleNode("Settings/Password/apply").InnerText = "0";
                xmlDoc.Save("Data/localSave.xml");
                save_password_panel.Visible = false;
            }
        }

        private void save_password(object sender, EventArgs e)
        {
            xmlDoc.SelectSingleNode("Settings/Password/apply").InnerText = "1";
            xmlDoc.Save("Data/localSave.xml");
            save_password_panel.Visible = false;
        }

        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            if(this.Size != Screen.PrimaryScreen.Bounds.Size)   // Its small ; Make FullScreen
            {
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                ((Button)sender).BackgroundImage = global::OOP_Lab_II.Properties.Resources.smallscreen;
            }
            else
            {
                this.Size = new System.Drawing.Size(formInitWidth, formInitHeight);
                ((Button)sender).BackgroundImage = global::OOP_Lab_II.Properties.Resources.fullscreen;
            }
            this.CenterToScreen();
            windowPanel.Size = new Size((int)(this.Size.Width * 449/ formInitWidth), (int)(this.Size.Height * 341/ formInitHeight));
            windowPanel.Location = new Point((int)(this.Size.Width * 118/ formInitWidth), (int)(this.Size.Height * 85/ formInitHeight));
            exitPopup.Location= new Point((int)(this.Size.Width * 552/ formInitWidth), (int)(this.Size.Height * 48/ formInitHeight));
            exitPopup.Size = new Size((int)(this.Size.Width * 40/ formInitWidth), (int)(this.Size.Height * 40/ formInitHeight));
        }
        public void exitPopup_Click(object sender, EventArgs e)
        {
            this.windowPanel.Controls.Clear();
            if (currentForm != null)
                currentForm.Close();
            popup.Visible = false;
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (muteButton.Image == null)
            {
                this.muteButton.Image = global::OOP_Lab_II.Properties.Resources.MuteCross;
                sound.Stop();
                return;
            }
            this.muteButton.Image = null;
            sound.PlayLooping();
        }
    }
}
