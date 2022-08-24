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

        public static string welcomeNewUser = "";
        public static Customer newCustomerInfo = new Customer();

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            string email = TxtEmailAddress.Text;

            // Checks each textbox for an entered value
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim() == "")
                {
                    isEmpty = true;
                }
            }

            if (!isEmpty)
            {
                using PizzaShopContext dbContext = new();

                Customer customer = new()
                {
                    FirstName = TxtFirstName.Text.Trim(),
                    LastName = TxtLastName.Text.Trim(),
                    StreetAddress = TxtStreetAddress.Text.Trim(),
                    State = TxtState.Text.Trim(),
                    City = TxtCity.Text.Trim(),
                    ZipCode = TxtZipCode.Text.Trim(),
                    EmailAddress = TxtEmailAddress.Text.Trim(),
                    Password = TxtPassword.Text.Trim(),
                };

                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();

                customer = (from c in dbContext.Customers
                            where c.EmailAddress == email
                            select c).FirstOrDefault();

                // Create a customer object to be passed onto the next form
                newCustomerInfo.CustomerID = customer.CustomerID;
                newCustomerInfo.FirstName = customer.FirstName;
                newCustomerInfo.LastName = customer.LastName;
                newCustomerInfo.StreetAddress = customer.StreetAddress;
                newCustomerInfo.State = customer.State;
                newCustomerInfo.City = customer.City;
                newCustomerInfo.ZipCode = customer.ZipCode;
                newCustomerInfo.EmailAddress = customer.EmailAddress;
                newCustomerInfo.Password = customer.Password;

                string fullName = $"{customer.FirstName} {customer.LastName}";
                welcomeNewUser = fullName;

                MessageBox.Show($"Thank you {customer.FirstName} for making an account!");

                this.Hide();
                HomePage home = new HomePage();
                HomePage.account = newCustomerInfo;
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Please enter missing values");
            }

        }

        private void BtnClearInputs_Click(object sender, EventArgs e)
        {
            // Itterates through each textbox and clears values
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = String.Empty;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }
    }
}
