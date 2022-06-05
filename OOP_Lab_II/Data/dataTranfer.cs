using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Lab_II
{
    public sealed class dataTransfer
    {
        //Private Field
        SqlConnection connection;
        string TableName = "AccountTable";
        string ConnectionString;
        private Account account;
        private static dataTransfer instance;    // Instance
        //Private Constructor
        private dataTransfer() {
            ConnectionString = @"workstation id=BoredDataBase.mssql.somee.com;packet size=4096;user id=Bilonel_SQLLogin_1;pwd=cpiakmox9q;
        data source=BoredDataBase.mssql.somee.com;persist security info=False;initial catalog=BoredDataBase";
        }
        //Public Methods
        public static dataTransfer Instance
        {
            get
            {
                if (instance == null)
                    instance = new dataTransfer();
                return instance;
            }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataSet GetDataSet(string select)
        {
            try
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
                adapter.Fill(dataset);
                return dataset;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public SqlDataReader GetReader(string command)
        {
            try
            {
                SqlDataReader reader;
                reader = Cmd(command).ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void pushAccount(string command,Account user)
        {
            this.Open();
            SqlCommand cmd = Cmd(command);
            cmd.Parameters.AddWithValue("@BestScore", user.BestScore);
            cmd.Parameters.AddWithValue("@AccountType", user.AccountType);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@NameSurname", user.NameSurname);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Country", user.Country);
            cmd.Parameters.AddWithValue("@City", user.City);
            cmd.Parameters.AddWithValue("@Address", user.Address);
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
        public void register(string[] row, string access)
        {
            if (readUser(row[2])[2] != null) //Username must be unique
                throw new ArgumentException("Username must be unique .");
            if (row[1] != "admin" && row[1] != "user")
                throw new ArgumentException("Invalid Account Type ; Please Enter admin or user ."); //Invalid Account Type ; Please Enter admin or user .
            if (!System.Text.RegularExpressions.Regex.IsMatch(row[2], @"^[a-zA-Z]+$"))  // USERNAME HAVE TO INCLUDE ONLY LETTERS
                throw new ArgumentException("Username must have only letters.");

            if (access != "admin")   // For Admin accesss dont encode to password because admin panel is already encoding passwords
                row[3] = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(row[2]))).Replace("-", "");
            for (int i = 0; i < row.Length; i++)
                if (row[i] == null)
                    row[i] = "";
            
            string command = "INSERT INTO " + TableName + " VALUES(" +
                "@BestScore,@AccountType,@Username,@Password,@NameSurname," +
                "@Email,@Phone,@Country,@City,@Address)";
            Account new_account;
            if(row[1]=="admin")
                new_account = new Admin();
            else new_account = new User();
            new_account.setUserData(row);
            this.pushAccount(command, new_account);
        }
        //public void register(string[] row,string access)
        //{
        //    if(readUser(row[1])!=null)
        //        throw new ArgumentException("Username must be unique ."); //Username must be unique
        //    if (row[0]!="admin"&&row[0]!="user")
        //        throw new ArgumentException("Invalid Account Type ; Please Enter admin or user ."); //Invalid Account Type ; Please Enter admin or user .
        //    if (row[2]==null||row[2]=="")                   
        //        throw new ArgumentException("Password cannot be Empty .");      // Password cannot be Empty
        //    if (!System.Text.RegularExpressions.Regex.IsMatch(row[1], @"^[a-zA-Z]+$"))  // USERNAME HAVE TO INCLUDE ONLY LETTERS
        //        throw new ArgumentException("Username must have only letters.");
           
        //    for (int i = 0; i < row.Length; i++)
        //        if (row[i] == null)
        //            row[i] = "";
        //    if (access != "admin")   // For Admin accesss dont encode to password because admin panel already encoding passwords
        //      row[2]=System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(row[2]))).Replace("-", "");
        //    XElement doc = XElement.Load(xmlpath);
        //    doc.Add(new XElement("Account",
        //    new XElement("AccountType", row[0]),
        //    new XElement("Username", row[1]),
        //    new XElement("Password", row[2]),
        //    new XElement("NameSurname", row[3]),
        //    new XElement("Email", row[4]),
        //    new XElement("Phone", row[5]),
        //    new XElement("Country", row[6]),
        //    new XElement("City", row[7]),
        //    new XElement("Address", row[8])
        //    ));
        //    doc.Save(xmlpath);
        //}
        public void updateUser(Account user)    // Update data of User
        {
            if (user.Password != readUser(user.Username)[3])   // If new password and old password are diffrent then encode it.
                user.Password = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(user.Password))).Replace("-", "");

            string command = "update " + TableName + " set " +
                "BestScore=@BestScore," +
                "AccountType=@AccountType," +
                "Password=@Password," +
                "NameSurname=@NameSurname," +
                "Email=@Email," +
                "Phone=@Phone," +
                "Country=@Country," +
                "City=@City," +
                "Address=@Address " +
                "where Username=@Username";
            this.pushAccount(command,user);
            update_account();
            //XmlDocument doc = new XmlDocument();
            //doc.Load(xmlpath);
            //XmlNodeList nodes = doc.SelectNodes("Accounts/Account");
            //foreach (XmlNode accountNodes in nodes)
            //    if (accountNodes.ChildNodes.Item(1).InnerText == row[1])    // FIND BY USERNAME
            //    {
            //        for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
            //        {
            //            accountNodes.ChildNodes.Item(i).InnerText = row[i];
            //        }
            //        doc.Save(xmlpath);
            //        if (account!=null)
            //            if (row[1] == account.info[1])
            //                update_account();
            //        return; // SUCCESS
            //    }
            //throw new Exception("Invalid Argument");
        }
        public string[] readUser(string username)
        {
            this.Open();
            try
            {
                string[] items = new string[10];
                string command = "Select * from "+TableName+" where Username=@Username";
                SqlCommand cmd = Cmd(command);
                cmd.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items[0] = reader.GetInt32(0).ToString();   // HIGHEST SCORE
                        for (int i = 1; i < items.Length; i++)      
                            items[i] = reader.GetString(i);         // OTHER DATAS
                    }
                }
                return items;
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
        public Account get_Account_From_Database(string username)
        {
            string[] row = readUser(username);  // First of all read the user from database
            for (int i = 1; i < 3; i++)
                if (row[i] == null)     // If Username or AccountType is null , return NULL
                    return null;
            Account new_account;        // OTHERWISE
            if (row[1]=="admin")
                new_account = new Admin();      // CREATE OBJECT FOR THE USER
            else new_account = new User();
            new_account.setUserData(row);       // SET DATA
            return new_account;     // RETURN OBJECT
        }
        //public string[] readUser(string username)
        //{
        //    string[] items = new string[10];
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xmlpath);
        //    XmlNodeList nodes = doc.SelectNodes("Accounts/Account");
        //    foreach (XmlNode accountNodes in nodes)
        //    {
        //        if (accountNodes.ChildNodes.Item(1).InnerText == username)
        //        {
        //            for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
        //            {
        //                items[i] = accountNodes.ChildNodes.Item(i).InnerText;
        //            }
        //            return items;
        //        }
        //    }
        //    return null;
        //}
        public void setAll(DataGridView dt)
        {
            this.Open();
            SqlCommand cmd = this.Cmd("delete "+TableName);
            cmd.ExecuteNonQuery();
            this.Close();
            for (int k = 0; k < dt.RowCount - 1; k++)
            {
                string[] items = new string[10];
                for (int i = 0; i < items.Length; i++)
                    if (dt.Rows[k].Cells[i].Value != null)
                        items[i] = dt.Rows[k].Cells[i].Value.ToString();
                register(items, "admin");
            }
            update_account();
            //XElement doc = XElement.Load(xmlpath);
            //doc.RemoveAll();
            //doc.Save(xmlpath);
            //for(int k=0;k<dt.RowCount-1;k++)
            //{
            //    string[] items= new string[9];
            //    for (int i = 0; i < 9; i++)
            //        if (dt.Rows[k].Cells[i].Value!=null)
            //            items[i] = dt.Rows[k].Cells[i].Value.ToString();
            //    register(items,"admin");
            //}
        }
        public void getAll(DataGridView dataGrid)
        {
            this.Open();
            DataTable datatable = GetDataSet("SELECT * FROM " + TableName).Tables[0];
            this.Close();

            dataGrid.Rows.Clear();
            foreach (DataRow row in datatable.Rows)
                dataGrid.Rows.Add(row.ItemArray);
        }
        //XmlDocument doc = new XmlDocument();
        //doc.Load(xmlpath);
        //XmlNodeList nodes = doc.SelectNodes("Accounts/Account");

        //foreach (XmlNode accountNodes in nodes)
        //{
        //    DataGridViewRow row = new DataGridViewRow();
        //    row.CreateCells(dt);
        //    for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
        //        row.Cells[i].Value = accountNodes.ChildNodes.Item(i).InnerText;
        //    dt.Rows.Add(row);
        //}
        private void initAccount(string username)
        {
            string[] row = readUser(username);
            if (row != null)
                if (row[1] == "admin")
                {
                    account = new Admin();
                    account.setUserData(row);
                }
                else if (row[1] == "user")
                {
                    account = new User();
                    account.setUserData(row);
                }
        }
        public Account get_account(string id=null)
        {
            if (id != null)
                initAccount(id);
            else if (this.account == null)
                throw new InvalidOperationException();
            update_account();
            return account;
        }
        private void update_account()
        {
            try { account.setUserData(readUser(account.Username)); }
            catch (Exception) { }
        }
        public bool check_password(string password)
        {
            string encodePassword = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed())
                .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))).Replace("-", "");
            return encodePassword== account.Password;
        }
        public bool isHighestScore(int newScore)
        {
            if(newScore>account.BestScore) // is new score bigger than recorded score 
            {
                account.BestScore = newScore;
                updateUser(account);
                return true;
            }
            return false;
        }
    }
}
