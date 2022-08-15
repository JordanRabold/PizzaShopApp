﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PizzaShopApp
{
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        public static Customer customerAccount { get; set; }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            // Display all the account info within their respctive Textboxes
            label8.Text = Convert.ToString(customerAccount.CustomerID);
            TxtFirstName.Text = customerAccount.FirstName;
            TxtLastName.Text = customerAccount.LastName;
            TxtEmail.Text = customerAccount.EmailAddress;
            TxtStreetAddress.Text = customerAccount.StreetAddress;
            TxtState.Text = customerAccount.State;
            TxtCity.Text = customerAccount.City;
            TxtZipCode.Text = customerAccount.ZipCode;

            //using PizzaShopContext dbContext = new();
            //dataGridView1.DataSource = dbContext.Customers.ToList();
        }

        /// <summary>
        /// Deletes the customers account based on which customer is logged in at the moment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            // Get the PizzaShopContext
            using PizzaShopContext dbContext = new();

            // Get customer where TxtEmail = email in database
            Customer cust = dbContext.Customers.First(i => i.CustomerID == Convert.ToInt32(label8.Text));
            dbContext.Customers.Remove(cust);
            dbContext.SaveChanges();
            MessageBox.Show("Account Successfully Deleted");

            this.Hide();
            Form1 formOne = new Form1();
            formOne.ShowDialog();
        }

        private void buttonUpdateAccount_Click(object sender, EventArgs e)
        {
            TxtFirstName.ReadOnly = false;
            TxtLastName.ReadOnly = false;
            TxtEmail.ReadOnly = false;
            TxtStreetAddress.ReadOnly = false;
            TxtState.ReadOnly = false;
            TxtCity.ReadOnly = false;
            TxtZipCode.ReadOnly = false;

            buttonConfirm.Visible = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            using PizzaShopContext dbContext = new();

            Customer cust = dbContext.Customers.First(i => i.CustomerID == Convert.ToInt32(label8.Text));
            cust.FirstName = TxtFirstName.Text;
            cust.LastName = TxtLastName.Text;
            cust.EmailAddress = TxtEmail.Text;
            cust.StreetAddress = TxtStreetAddress.Text;
            cust.State = TxtState.Text;
            cust.City = TxtCity.Text;
            cust.ZipCode = TxtZipCode.Text;

            dbContext.SaveChanges();
            MessageBox.Show("Account Successfully Updated");
        }
    }
}
