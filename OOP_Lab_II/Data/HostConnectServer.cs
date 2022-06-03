using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_Lab_II.Data
{
    public class Host
    {
        public string Username { get; }
        public string BestScore { get; }
        public string IP { get; }
        public string Port { get; }
        public Host(string[] row)
        {
            Username = row[0].ToString();
            BestScore = row[1].ToString();
            IP = row[2].ToString();
            Port = row[3].ToString();
        }
        
    }
    
    public class HostPanel
    {
        public HostPanel(Host host,int count=0)
        {
            // INIT
            MainPanel = new Panel();
            this.UsernameLabel = new Label();
            this.BestScoreLabel = new Label();
            InviteButton = new Button();
            
            //Main Host Panel
            MainPanel.SuspendLayout();
            MainPanel.BackColor = Color.FromArgb(150, 70, 90);
            MainPanel.Size = new System.Drawing.Size(340, 50);
            MainPanel.Location = new Point(5, 10 + (count * 60));
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Controls.Add(InviteButton);
            MainPanel.Controls.Add(BestScoreLabel);
            MainPanel.Controls.Add(UsernameLabel);

            //Username Label
            this.UsernameLabel.Size = new System.Drawing.Size(130, 40);
            this.UsernameLabel.Location = new System.Drawing.Point(10, 5);
            this.UsernameLabel.Text = host.Username;
            this.UsernameLabel.TextAlign = ContentAlignment.MiddleCenter; 
            this.UsernameLabel.BackColor = Color.FromArgb(150, 70, 90);
            this.UsernameLabel.ForeColor = Color.FromArgb(252, 160, 0);
            this.UsernameLabel.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);

            //BestScore Label
            this.BestScoreLabel.Size = new System.Drawing.Size(50, 40);
            this.BestScoreLabel.Location = new System.Drawing.Point(150, 5);
            this.BestScoreLabel.Text = host.BestScore;
            this.BestScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.BestScoreLabel.BackColor = Color.FromArgb(150, 70, 90);
            this.BestScoreLabel.ForeColor = Color.FromArgb(252, 160, 0);
            this.BestScoreLabel.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);

            //Invite Button
            this.InviteButton.Size = new System.Drawing.Size(90, 40);
            this.InviteButton.Location = new System.Drawing.Point(240, 5);
            this.InviteButton.Text = "INVITE";
            this.InviteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InviteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InviteButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            this.InviteButton.BackColor = Color.FromArgb(190, 100, 130);
            this.InviteButton.ForeColor = Color.FromArgb(252, 160, 0);
           // this.InviteButton.Click += new System.EventHandler(this.Invite_Click);

            MainPanel.ResumeLayout(false);

        }
        public Panel MainPanel { get; }
        //private PictureBox Avatar;
        private Label UsernameLabel;
        private Label BestScoreLabel;
        public Button InviteButton { get; }
        //
        // Invite Click Event
       
    }
    class HostConnectServer
    {
        SqlConnection connection;
        string TableName = "Hosts";
        string ConnectionString;
        //Private Constructor
        public HostConnectServer()
        {
            ConnectionString = @"workstation id=BoredDataBase.mssql.somee.com;packet size=4096;user id=Bilonel_SQLLogin_1;pwd=cpiakmox9q;
        data source=BoredDataBase.mssql.somee.com;persist security info=False;initial catalog=BoredDataBase";
        }
        public void Open()
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Close()
        {
            connection.Close();
            connection.Dispose();
        }
        public SqlCommand Cmd(string command)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(command, connection);
                return cmd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void addHost(string[] row)
        {
            string command = "INSERT INTO " + TableName + " VALUES(" +
                "@Username,@BestScore,@IP,@Port,'')";

            this.Open();
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@Username", row[0]);
            cmd.Parameters.AddWithValue("@BestScore", row[1]);
            cmd.Parameters.AddWithValue("@IP", row[2]);
            cmd.Parameters.AddWithValue("@Port", row[3]);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        public void deleteHost(string Host_Username)
        {
            string command = "DELETE FROM "+TableName+ " WHERE Username=@Username;";
            this.Open();
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@Username", Host_Username);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        public void SendRequest(string ReceiverUsernmae, string ChallangerUsername)
        {
            string command = "update "+TableName+ " set Challenger = @ChallangerUsername where Username = @Username";

            this.Open();
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@Username", ReceiverUsernmae);
            cmd.Parameters.AddWithValue("@ChallangerUsername", ChallangerUsername);
           
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        public string getChallengerName(string Username)
        {
            this.Open();
            string command = "SELECT Challenger FROM " + TableName + " where Username=@Username";
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@Username", Username);
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        command = reader.GetValue(0).ToString();   // HIGHEST SCORE
                    }
                }
                if (string.IsNullOrEmpty(command))
                    command = "";
                return command;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                this.Close();
            }
        }
        public List<Host> getList()
        {
            this.Open();
            string command = "SELECT * FROM " + TableName;
            DataTable datatable = new DataTable();
            List<Host> hostList = new List<Host>();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(datatable);
                foreach (DataRow row in datatable.Rows)
                {
                    Host host = new Host(new string[] {row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() });
                    hostList.Add(host);
                }
                return hostList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                this.Close();
            }
        }
        public Host getHost(string username)
        {
            this.Open();
            string command = "SELECT * FROM " + TableName + " where Username=@Username";
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                string[] row = new string[4];
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < 4; i++)
                            row[i] = reader.GetValue(i).ToString();
                    }
                }
                return new Host(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                this.Close();
            }
        }
    }
}
