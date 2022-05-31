﻿using System;
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
        protected string[] row;
        protected System.Windows.Forms.Form form;
        //  Methods
        public virtual System.Windows.Forms.Form Form { get => form; }
        public string[] info { get => row; set => row = value; }
    }
    public class User : Account
    {
        public override System.Windows.Forms.Form Form { get => new Menu.User_Panel(); }
    }
    public class Admin : Account
    {
        public override System.Windows.Forms.Form Form { get => new Menu.Admin_Panel(); }
    }
}