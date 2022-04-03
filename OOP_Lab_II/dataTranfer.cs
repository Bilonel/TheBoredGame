using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
namespace OOP_Lab_II
{
    public sealed class dataTransfer
    {
        //Private Field
        private OleDbConnection connection;     // connecting to DataBase
        private Data.linkedDataSetTableAdapters.tbl_usersTableAdapter adapter;  // Bridge between dataBase and DataSet
        private Account account;
        private static dataTransfer instance;    // Instance
        //Private Constructor
        private dataTransfer()
        {       
            // Initial Declaration
            this.connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" 
                + System.IO.Path.GetFullPath(System.IO.Path.Combine(System.Environment.CurrentDirectory, @"..\..\")) + "/Data/db_user.mdb");
            this.adapter = new Data.linkedDataSetTableAdapters.tbl_usersTableAdapter();
            // Initial Definations
            adapter.Connection = connection;
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
        public void save(string username,string password, string name, string email, string phone, string country, string city, string address)    // save data to data base
        {
            string type = "user";
            adapter.Insert(type, username, System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))).Replace("-", ""), name, email, phone, country, city, address);
            if(account!=null)
                if (username == account.info.username)
                    update_account();
        }
      
        public void update(Data.linkedDataSet.tbl_usersRow row)
        {
            if(row.password!=get_user_row(row.username).password)   // If new password and old password are diffrent then encode it.
                row.password = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(row.password))).Replace("-", "");
            adapter.Update(row);
            if (account != null)
                if (row.username == account.info.username)
                update_account();
        }
        
        public Data.linkedDataSet.tbl_usersRow get_user_row(string username)
        {
            return adapter.GetData().FindByusername(username);     
        }
        public Data.linkedDataSet.tbl_usersDataTable dataTable
        {
            get => adapter.GetData();
            set
            {
               adapter.Update(value);
            }
        }
        private void initAccount(string username)
        {
            Data.linkedDataSet.tbl_usersRow row = get_user_row(username);
            if (row != null)
                if (row.AccountType == "admin")
                {
                    account = new Admin();
                    account.info = row;
                }
                else if (row.AccountType == "user")
                {
                    account = new User();
                    account.info = row;
                }
                else
                    throw new AccessViolationException();
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
            account.info = get_user_row(account.info.username);
        }
    }
}
