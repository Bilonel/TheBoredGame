using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_II
{
    public static class AccountFactory      // IT WILL USE AFTER DATABASE BUILD
    {
        public static Account GetAccount(string username, string accountType)
        {
            Account account = null;

            account = dataTransfer.Instance.get_Account_From_Database(username);

            if (account != null) return account;    // IF ACCOUNT IS NOT NULL , HERE IT IS WE FOUND IT AND RETURN IT

            else
            {
                switch (accountType)
                {
                    case "admin": account = new Admin(); break;
                    case "user": account = new User(); break;
                    //...
                    default: break;
                }
                // dataTransfer.Instance.register(account);     COMING SOON
            }
            return account;
        }
    }

    public class Account
    {
        //  Field
        public int BestScore { get; set; }
        public string AccountType { get; internal set; }
        public string Username { get; set; }  // just GET because it should be Unique XXX
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        protected System.Windows.Forms.Form form;

        //  Methods
        public virtual System.Windows.Forms.Form Form { get => form; }
        public void setUserData(string _BestScore, string _Username, string _Password, string _NameSurname, string _Email, string _Phone, string _Country, string _City, string _Address)
        {
            BestScore = int.Parse(_BestScore);
            Username = _Username;
            Password = _Password;
            NameSurname = _NameSurname;
            Email = _Email;
            Phone = _Phone;
            Country = _Country;
            City = _City;
            Address = _Address;
        }
        public void setUserData(string[] row)
        {
            int i = 0;
            BestScore = int.Parse(row[i++]);
            i++;    //DONT SET ACCOUNT TYPE 
            Username = row[i++];
            Password = row[i++];
            NameSurname = row[i++];
            Email = row[i++];
            Phone = row[i++];
            Country = row[i++];
            City = row[i++];
            Address = row[i++];
        }
    }
    public class User : Account
    {
        public User() { this.AccountType = "user"; }
        public override System.Windows.Forms.Form Form { get => new Menu.User_Panel(); }
    }
    public class Admin : Account
    {
        public Admin() { this.AccountType = "admin"; }

        public override System.Windows.Forms.Form Form { get => new Menu.Admin_Panel(); }
    }

}
