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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        List<double> subtotal = new List<double>();

        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            double pizza = 9.99;
            if (radioButtonPizza.Checked)
            {
                ClearCheckBoxes();
                checkBox1.Text = "Cheese";
                checkBox2.Text = "Pepperoni";
                checkBox3.Text = "Supreme";
                checkBox4.Text = "Veggie";
            }
        }

        private void radioButtonWings_CheckedChanged(object sender, EventArgs e)
        {
            double wings = 6.99;
            if (radioButtonWings.Checked)
            {
                ClearCheckBoxes();
                checkBox1.Text = "Buffalo";
                checkBox2.Text = "Barbeque";
                checkBox3.Text = "Parmesan Garlic";
                checkBox4.Text = "Lemon Pepper Dry Rub";
            }
        }

        private void radioButtonSides_CheckedChanged(object sender, EventArgs e)
        {
            double sides = 3.99;
            if (radioButtonSides.Checked)
            {
                ClearCheckBoxes();
                checkBox1.Text = "Cheesy Breadsticks";
                checkBox2.Text = "Garlic Parmesan Bites";
                checkBox3.Text = "Stuffed Cheesy Bread";
                checkBox4.Text = "Mozzarella Sticks";
            }
            
        }

        private void radioButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            double drinks = 1.99;
            if (radioButtonDrinks.Checked)
            {
                ClearCheckBoxes();
                checkBox1.Text = "Coca Cola";
                checkBox2.Text = "Sprite";
                checkBox3.Text = "Root Beer";
                checkBox4.Text = "Dr. Pepper";
            }
        }

        private void ClearCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void ClearTextBoxes()
        {
            textBoxOrderTotal.Clear();
            textBoxSubtotal.Clear();
            textBoxTax.Clear();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            double pizza = 9.99;
            double wings = 6.99;
            double sides = 3.99;
            double drinks = 1.99;
            double subtotalSum = 0;
            double taxSum;
            double orderTotal;
            foreach(CheckBox c in groupBoxOptions.Controls)
            {
                if(radioButtonPizza.Checked && c.Checked)
                {
                    subtotal.Add(pizza);
                }

                if (radioButtonWings.Checked && c.Checked)
                {
                    subtotal.Add(wings);
                }

                if (radioButtonSides.Checked && c.Checked)
                {
                    subtotal.Add(sides);
                }

                if (radioButtonDrinks.Checked && c.Checked)
                {
                    subtotal.Add(drinks);
                }
            }

            for (int i = 0; i < subtotal.Count; i++)
            {
                subtotalSum += subtotal[i];
            }

            taxSum = subtotalSum * .065;
            orderTotal = subtotalSum + taxSum;

            textBoxSubtotal.Text = subtotalSum.ToString("c");
            textBoxTax.Text = taxSum.ToString("c");
            textBoxOrderTotal.Text = orderTotal.ToString("c");
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank's for placing an order!");
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            ClearTextBoxes();
            subtotal.Clear();
        }
    }
}
