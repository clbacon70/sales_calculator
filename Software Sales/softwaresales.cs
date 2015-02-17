using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class softwareSales : Form
    {
        public softwareSales()
        {
            InitializeComponent();
        }

        // local variables

        decimal numberOfPackages, discountAmount, subTotalPrice, totalPrice;

        const decimal packageAmount = 99m;
        const decimal discountTwenty = 0.2m;
        const decimal discountThirty = 0.3m;
        const decimal discountForty = 0.4m;
        const decimal discountFifty = 0.5m;


        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(numberOfPackagesTextBox.Text, out numberOfPackages) && (numberOfPackages >= 1 && numberOfPackages <= 1000))
            {
                if (numberOfPackages >= 10 && numberOfPackages <= 19)
                {
                    discountAmount = discountTwenty;
                }
                else if (numberOfPackages >= 20 && numberOfPackages <= 49)
                {
                    discountAmount = discountThirty;
                }
                else if (numberOfPackages >= 50 && numberOfPackages <= 99)
                {
                    discountAmount = discountForty;
                }
                else if (numberOfPackages >= 100 && numberOfPackages <= 1000)
                {
                    discountAmount = discountFifty;
                }

                subTotalPrice = packageAmount * numberOfPackages * discountAmount;
                totalPrice = packageAmount * numberOfPackages - subTotalPrice;
                subTotalPriceTextBox.Text = subTotalPrice.ToString("c");
                totalPriceTextBox.Text = totalPrice.ToString("c");
                numberOfPackagesTextBox.Focus();
            }

            else
            {
                MessageBox.Show("Please enter whole number between 1 and 1,000");
                numberOfPackagesTextBox.Focus();
                numberOfPackagesTextBox.SelectAll();

                numberOfPackagesTextBox.Clear();
                totalPriceTextBox.Clear();
            }

    }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberOfPackagesTextBox.Clear();
            subTotalPriceTextBox.Clear();
            totalPriceTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        
    }
}