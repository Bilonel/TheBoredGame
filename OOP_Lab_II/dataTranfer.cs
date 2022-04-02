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
        private Data.linkedDataSet.tbl_usersDataTable dataTable;     // Local Data Store
        private Account account;
        private static dataTransfer instance;    // Instance
        //Private Constructor
        private dataTransfer()
        {       
            // Initial Declaration
            this.connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" 
                + System.IO.Path.GetFullPath(System.IO.Path.Combine(System.Environment.CurrentDirectory, @"..\..\")) + "/Data/db_user.mdb");
            this.dataTable = new Data.linkedDataSet.tbl_usersDataTable();
            this.adapter = new Data.linkedDataSetTableAdapters.tbl_usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            // Initial Definations
            adapter.Connection = connection;
            this.dataTable.TableName = "Data Table";
            this.adapter.ClearBeforeFill = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
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
            adapter.Insert(type, username, password, name, email, phone, country, city, address);
        }
        public void update(Data.linkedDataSet.tbl_usersRow row)
        {
            adapter.Update(row);
        }
        public Data.linkedDataSet.tbl_usersRow get_user_row(string username)
        {
            return adapter.GetData().FindByusername(username);     
        }
        public Data.linkedDataSet.tbl_usersDataTable get_data_table
        {
            get => adapter.GetData();
        }
        private Account initAccount(string username)
        {
            string access = get_user_row(username).AccountType;
            if (access == "admin")
                account = new Admin(username);
            else if (access == "user")
                account = new User(username);
            else
                throw new AccessViolationException();
            return account;
        }
        public Account get_account(string id=null)
        {
            if (this.account == null && id != null)
                initAccount(id);
            else if (this.account == null && id == null)
                throw new InvalidOperationException();
            return account;
        }
    }
}
