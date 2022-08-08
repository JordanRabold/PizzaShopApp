﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            labelUserName.Text = "Welcome " + Form1.welcomeUser;
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo infoForm = new();
            infoForm.ShowDialog();
        }
    }
}
