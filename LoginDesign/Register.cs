﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDesign
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Close();
        }
    }
}
