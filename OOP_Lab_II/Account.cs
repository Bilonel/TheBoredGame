using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_II
{
    public sealed class Account
    {
        //  Field
        private static dataTransfer dataControl;
        private Data.linkedDataSet.tbl_usersRow row;
        private static Account account=null;
        //  Constructor
        private Account(string username)
        {
            dataControl = dataTransfer.Instance;
            row = dataControl.get_user_row(username);
        }
        //  Methods
        public static Account getAccount(string username=null)
        {
            if (username == null && account == null)
                return null;
            if (username != null && account == null)
                account = new Account(username);
            return account;
        }
        public string getUserName()
        {
            return row.username;
        }
    }
}
