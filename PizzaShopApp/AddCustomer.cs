using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            using PizzaShopContext dbContext = new();

            Customer customer = new()
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                StreetAddress = TxtStreetAddress.Text,
                State = TxtState.Text,
                City = TxtCity.Text,
                ZipCode = TxtZipCode.Text,
                EmailAddress = TxtEmailAddress.Text,
            };

            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();

            MessageBox.Show($"Thanks {customer.FirstName}! for making an account");

            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}
