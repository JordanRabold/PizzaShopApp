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
            //using PizzaShopContext dbContext = new();
            //dataGridView1.DataSource = dbContext.Customers.ToList();
        }
    }
}
