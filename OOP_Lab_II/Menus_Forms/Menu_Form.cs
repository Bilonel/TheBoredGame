using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab_II
{
    public partial class Menu_Form : Form
    {
        //Fields
        //

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
            usernameLabel.Text = Account.getAccount().getUserName();
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

        private void multiplayer_click(object sender, EventArgs e)
        {
            activateForm(new Forms.Form_Multiplayer());
        }
    }
}
