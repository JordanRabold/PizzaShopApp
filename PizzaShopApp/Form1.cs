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
            else
            {
                welcomeUser = TxtCustomerEmail.Text;
                LbEmailError.Visible = false;
                MessageBox.Show("Email was found");

                this.Hide();
                HomePage homeForm = new();
                homeForm.ShowDialog();
            }
        }
    }
}