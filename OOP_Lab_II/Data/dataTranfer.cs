using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace OOP_Lab_II
{
    public sealed class dataTransfer
    {
        //Private Field
        private string xmlpath = Environment.CurrentDirectory + "/../../Data/globalSave.xml";
        private Account account;
        private static dataTransfer instance;    // Instance
        //Private Constructor
        private dataTransfer()
        {}
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
        public void register(string[] row,string access)
        {
            if(readUser(row[1])!=null)
                throw new ArgumentException("Username must be unique ."); //Username must be unique
            if (row[0]!="admin"&&row[0]!="user")
                throw new ArgumentException("Invalid Account Type ; Please Enter admin or user ."); //Invalid Account Type ; Please Enter admin or user .
            if (row[2]==null||row[2]=="")                   
                throw new ArgumentException("Password cannot be Empty .");      // Password cannot be Empty
            if (!System.Text.RegularExpressions.Regex.IsMatch(row[1], @"^[a-zA-Z]+$"))  // USERNAME HAVE TO INCLUDE ONLY LETTERS
                throw new ArgumentException("Username must have only letters.");
           
            for (int i = 0; i < row.Length; i++)
                if (row[i] == null)
                    row[i] = "";
            if (access != "admin")   // For Admin accesss dont encode to password because admin panel already encoding passwords
                row[2]=System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(row[2]))).Replace("-", "");
            XElement doc = XElement.Load(xmlpath);
            doc.Add(new XElement("Account",
            new XElement("AccountType", row[0]),
            new XElement("Username", row[1]),
            new XElement("Password", row[2]),
            new XElement("NameSurname", row[3]),
            new XElement("Email", row[4]),
            new XElement("Phone", row[5]),
            new XElement("Country", row[6]),
            new XElement("City", row[7]),
            new XElement("Address", row[8])
            ));
            doc.Save(xmlpath);
        }
        public void updateUser(string[] row)    // Update data of User
        {
            if (row[2] != readUser(row[1])[2])   // If new password and old password are diffrent then encode it.
                row[2] = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(row[2]))).Replace("-", "");

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlpath);
            XmlNodeList nodes = doc.SelectNodes("Accounts/Account");
            foreach (XmlNode accountNodes in nodes)
                if (accountNodes.ChildNodes.Item(1).InnerText == row[1])    // FIND BY USERNAME
                {
                    for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
                    {
                        accountNodes.ChildNodes.Item(i).InnerText = row[i];
                    }
                    doc.Save(xmlpath);
                    if (account!=null)
                        if (row[1] == account.info[1])
                            update_account();
                    return; // SUCCESS
                }
            throw new Exception("Invalid Argument");
        }
        public string[] readUser(string username)
        {
            string[] items = new string[10];
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlpath);
            XmlNodeList nodes = doc.SelectNodes("Accounts/Account");
            foreach (XmlNode accountNodes in nodes)
            {
                if (accountNodes.ChildNodes.Item(1).InnerText == username)
                {
                    for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
                    {
                        items[i] = accountNodes.ChildNodes.Item(i).InnerText;
                    }
                    return items;
                }
            }
            return null;
        }
        public void setAll(DataGridView dt)
        {
            XElement doc = XElement.Load(xmlpath);
            doc.RemoveAll();
            doc.Save(xmlpath);
            for(int k=0;k<dt.RowCount-1;k++)
            {
                string[] items= new string[9];
                for (int i = 0; i < 9; i++)
                    if (dt.Rows[k].Cells[i].Value!=null)
                        items[i] = dt.Rows[k].Cells[i].Value.ToString();
                register(items,"admin");
            }
        }
        public void getAll(DataGridView dt)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlpath);
            XmlNodeList nodes = doc.SelectNodes("Accounts/Account");

            foreach (XmlNode accountNodes in nodes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dt);
                for (int i = 0; i < accountNodes.ChildNodes.Count; i++)
                    row.Cells[i].Value = accountNodes.ChildNodes.Item(i).InnerText;
                dt.Rows.Add(row);
            }
        }
        private void initAccount(string username)
        {
            string[] row = readUser(username);
            if (row != null)
                if (row[0] == "admin")
                {
                    account = new Admin();
                    account.info = row;
                }
                else if (row[0] == "user")
                {
                    account = new User();
                    account.info = row;
                }
                else
                    throw new AccessViolationException(" Invalid Account Type ! ");
        }
        public Account get_account(string id=null)
        {
            if (this.account == null && id != null)
                initAccount(id);
            else if (this.account == null)
                throw new InvalidOperationException();
            return account;
        }
        private void update_account()
        {
            account.info = readUser(account.info[1]);
        }
        public bool check_password(string password)
        {
            string encodePassword = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed())
                .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))).Replace("-", "");
            return encodePassword== account.info[2];
        }
    }
}
