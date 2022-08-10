namespace PizzaShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomerForm = new();
            addCustomerForm.ShowDialog();
        }

        public static string welcomeUser = "";

        // Initialize a public static object based on Customer class
        public static Customer customerInfo = new Customer();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using PizzaShopContext dbContext = new();

            string email = TxtCustomerEmail.Text;

            bool doesExist = (from c in dbContext.Customers
                              where c.EmailAddress == email
                              select c).Any();

            if (!doesExist)
            {
                LbEmailError.Visible = true;
            }
            // If email is found
            else
            {
                // Pull back the top result
                Customer ? customer = (from c in dbContext.Customers
                                      where c.EmailAddress == email
                                      select c).FirstOrDefault();

                // Create a customer object to be passed onto the next form
                customerInfo.FirstName = customer.FirstName;
                customerInfo.LastName = customer.LastName;
                customerInfo.StreetAddress = customer.StreetAddress;
                customerInfo.State = customer.State;
                customerInfo.City = customer.City;
                customerInfo.ZipCode = customer.ZipCode;
                customerInfo.EmailAddress = customer.EmailAddress;

                // String together the account holder's name to be displayed on next form
                string fullName = $"{customer.FirstName} {customer.LastName}";

                welcomeUser = fullName;
                LbEmailError.Visible = false;
                MessageBox.Show("Email was found");

                this.Hide();
                HomePage homeForm = new();
                HomePage.account = customerInfo;
                homeForm.ShowDialog();
            }
        }
    }
}