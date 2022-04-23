using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
namespace OOP_Lab_II
{
    public partial class Menu_Form : Form
    {
        //Fields
        //
        private XmlDocument xmlDoc;
        private Button currentActiveButton;
        private Form currentForm;
        private Image image;
        //
        //Constructor
        //
        public Menu_Form()
        {
            InitializeComponent();
            this.image = global::OOP_Lab_II.Properties.Resources.frame;
            usernameLabel.Text = dataTransfer.Instance.get_account().info.username;
        }
        //
        //Methods
        //
        private void activateButton(object new_button)
        {
                if(currentActiveButton!= new_button) // If Changes Need
                {
                    if (currentActiveButton != null) // Deactivate old one
                        currentActiveButton.BackgroundImage = null;
                    if(new_button!=null)    // Activate new one
                    {
                        currentActiveButton = (Button)new_button;
                        currentActiveButton.BackgroundImage = image;
                    }
                }
        }
        private void activateForm(Form newForm)
        {
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
        private void button_Enter(object sender, EventArgs e)  
        {
            activateButton(sender);
        }

        // CLICK METHODS
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void options_click(object sender, EventArgs e)
        {
            activateForm(new Forms.Form_Options());
        }
        private void play_click(object sender, EventArgs e)
        {
            activateForm(new Menus_Forms.Form_Play());
        }
        private void multiplayer_click(object sender, EventArgs e)
        {
            activateForm(new Forms.Form_Multiplayer());
        }
        private void about_button_Click(object sender, EventArgs e)
        {
            activateForm(new Menus_Forms.Form_About());
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            activateForm(dataTransfer.Instance.get_account().panel);
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            activateForm(dataTransfer.Instance.get_account().panel);
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            activateForm(dataTransfer.Instance.get_account().panel);
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.SetToolTip(this.profileButton, "Click to Profile");
            tt.SetToolTip(this.avatar, "is You ?");
            xmlDoc = new XmlDocument();
            xmlDoc.Load("Data/localSave.xml");
            save_password_panel_timer();
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
            if(save_password_panel.Visible)
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

    }
}
