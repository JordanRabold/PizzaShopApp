using Microsoft.Data.SqlClient;
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
            Customer cust = dbContext.Customers.First(i => i.EmailAddress == TxtEmail.Text);
            dbContext.Customers.Remove(cust);
            dbContext.SaveChanges();
            MessageBox.Show("Account Successfully Deleted");

            this.Hide();
            Form1 formOne = new Form1();
            formOne.ShowDialog();
        }
    }
}
