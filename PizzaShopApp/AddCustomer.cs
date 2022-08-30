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
            bool isValid = true;
            string email = TxtEmailAddress.Text;
            string missingValues = "Some inputs may be missing, please check all textboxes for input";

            // Checks each textbox for an entered value
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim() == "")
                {
                    isValid = false;
                }
            }

            // Checks if inputted ZipCode is at least 5 characters
            int zipCodeCheck = TxtZipCode.Text.Trim().Length;
            if (zipCodeCheck != 5)
            {
                isValid = false;
                missingValues += $"\nZipCode must be 5 characters";

            }

            // Checks if inputted Email is less than 50 characters
            int emailLengthCheck = TxtEmailAddress.Text.Trim().Length;
            if (emailLengthCheck > 50)
            {
                isValid = false;
                missingValues += $"\nEmail cannot be longer than 50 characters";
            }

            // Checks if inputted password is at least 8 characters
            // and is less than 50 characters
            int passwordLengthCheck = TxtPassword.Text.Trim().Length;
            if (passwordLengthCheck < 8)
            {
                isValid = false;
                missingValues += $"\nPassword must be at least 8 characters";
            }
            if (passwordLengthCheck > 50)
            {
                isValid = false;
                missingValues += $"\nPassword cannot be longer than 50 characters";
            }

            if (isValid)
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
                MessageBox.Show(missingValues);
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
