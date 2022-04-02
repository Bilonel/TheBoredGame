using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_II
{
    public class Account
    {
        //  Field
        protected static dataTransfer dataControl;
        public string username, password;
        protected System.Windows.Forms.Form form;
        //  Consturctor
        protected Account()
        {
            dataControl = dataTransfer.Instance;
        }
        //  Methods
        public virtual System.Windows.Forms.Form panel { get => null; }
    }
    public class User : Account
    {
        private Data.linkedDataSet.tbl_usersRow row;
        public User(string username)
        {
            row = dataControl.get_user_row(username);
            this.username = username;
            this.form = new Menus_Forms.User_Panel();
        }   
        public override System.Windows.Forms.Form panel { get => form; }
    }
    public class Admin : Account
    {
        private Data.linkedDataSet.tbl_usersDataTable dataTable;
        public Admin(string username)
        {
            dataTable = dataControl.get_data_table;
            this.username = username;
            this.password = dataControl.get_user_row(username).password;
           // this.form = new Admin_Panel();
        }
        
        public override System.Windows.Forms.Form panel { get => form; }

    }
}
