﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    public partial class Form1 : Form
    {
        Credentials c = new Credentials();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            c.login(tf_username.Text, tf_password.Text);
            this.Hide();
        }
    }
}
