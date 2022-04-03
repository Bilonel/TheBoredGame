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
        protected Data.linkedDataSet.tbl_usersRow row;
        protected System.Windows.Forms.Form form;
        //  Methods
        public virtual System.Windows.Forms.Form panel { get => form; }
        public Data.linkedDataSet.tbl_usersRow info { get => row; set => row = value; }
    }
    public class User : Account
    {
        public override System.Windows.Forms.Form panel { get => new Menus_Forms.User_Panel(); }
    }
    public class Admin : Account
    {
        public override System.Windows.Forms.Form panel { get => new Menus_Forms.Admin_Panel(); }
    }
}
