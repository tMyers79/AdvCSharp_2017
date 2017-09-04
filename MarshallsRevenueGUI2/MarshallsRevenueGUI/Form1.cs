using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class Form1 : Form
    {
        int numInterior = 0;
        int numExterior = 0;
        int numDifference = 0;
        double exterior_price = 0.00;
        double interior_price = 0.00;
        double revenueExterior = 0.00;
        double revenueInterior = 0.00;

        const double INTERIOR_PRICE = 500.00;
        const double EXTERIOR_PRICE = 750.00;
        const double INTERIOR_PRICE_SALE = 450.00;
        const double EXTERIOR_PRICE_SALE = 699.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNumExterior.Text = "Pricing based on month...";
            lblNumInterior.Text = "Pricing based on month...";
            txtMonth.Text = DateTime.Now.Month.ToString();
        }

        private void txtNumExterior_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumExterior.Text) || Convert.ToInt16(txtNumExterior.Text) < 0 || Convert.ToInt16(txtNumExterior.Text) > 30)
            {
                MessageBox.Show("Invalid quantity entered.  Please select a value between 0 and 30.");
                lblRevenueExterior.Text = "0.00";
                txtNumExterior.Text = "0";
                txtNumExterior.SelectAll();
            }
            else if (!string.IsNullOrEmpty(txtNumExterior.Text)) {
                lblRevenueExterior.Text = (Double.Parse(txtNumExterior.Text) * exterior_price).ToString("0.00");
                Calc();
            }
        }

        private void txtNumInterior_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumInterior.Text) || Convert.ToInt16(txtNumInterior.Text) < 0 || Convert.ToInt16(txtNumInterior.Text) > 30)
            {
                MessageBox.Show("Invalid quantity entered.  Please select a value between 0 and 30.");
                lblRevenueInterior.Text = "0.00";
                txtNumInterior.Text = "0";
                txtNumInterior.SelectAll();
            }
            else if (!string.IsNullOrEmpty(txtNumInterior.Text)) {
                lblRevenueInterior.Text = (Double.Parse(txtNumInterior.Text) * interior_price).ToString("0.00");
                Calc();
            }
        }

        private void Calc()
        {
            lblTotalRevenue.Text = (Double.Parse(lblRevenueExterior.Text) + Double.Parse(lblRevenueInterior.Text)).ToString("0.00");

            numDifference = Int16.Parse(txtNumInterior.Text) - Int16.Parse(txtNumExterior.Text);
            if (numDifference > 0)
            {
                lblNumDifference.Visible = true;
                if (numDifference == 1)
                {
                    lblNumDifference.Text = "There is " + numDifference + " more interior murals scheduled than exterior.";
                }
                else
                {
                    lblNumDifference.Text = "There are " + numDifference + " more interior murals scheduled than exterior.";
                }
            }
            else { lblNumDifference.Visible = false; }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonth.Text)) 
            {
                txtMonth.Text = DateTime.Now.Month.ToString();
                txtMonth.SelectAll();
            }
            switch (Convert.ToInt16(txtMonth.Text))
            {
                case 1: //no ext
                    SetExteriorUnavailable();
                    SetInteriorNormal();
                    break;
                case 2: //no ext
                    SetExteriorUnavailable();
                    SetInteriorNormal();
                    break;
                case 3:
                    SetExteriorNormal();
                    SetInteriorNormal();
                    break;
                case 4: //ext-sale
                    SetExteriorSale();
                    SetInteriorNormal();
                    break;
                case 5: //ext-sale
                    SetExteriorSale();
                    SetInteriorNormal();
                    break;
                case 6:
                    SetExteriorNormal();
                    SetInteriorNormal();
                    break;
                case 7: //int-sale
                    SetExteriorNormal();
                    SetInteriorSale();
                    break;
                case 8: //int-sale
                    SetExteriorNormal();
                    SetInteriorSale();
                    break;
                case 9: //ext-sale
                    SetExteriorSale();
                    SetInteriorNormal();
                    break;
                case 10: //ext-sale
                    SetExteriorSale();
                    SetInteriorNormal();
                    break;
                case 11:
                    SetExteriorNormal();
                    SetInteriorNormal();
                    break;
                case 12: //no ext
                    SetExteriorUnavailable();
                    SetInteriorNormal();
                    break;
                default:
                    MessageBox.Show("Invalid month entered.  Please select a value from 1 to 12.");
                    txtMonth.Text = DateTime.Now.Month.ToString();
                    break;
            }
        }

        private void SetExteriorNormal()
        {
            txtNumExterior.Enabled = true;
            exterior_price = EXTERIOR_PRICE;
            lblNumExterior.Text = "$" + exterior_price + "/ea";
        }

        private void SetExteriorSale()
        {
            txtNumExterior.Enabled = true;
            exterior_price = EXTERIOR_PRICE_SALE;
            lblNumExterior.Text = "$" + exterior_price + "/ea";
        }

        private void SetExteriorUnavailable()
        {
            txtNumExterior.Text = 0.ToString();
            txtNumExterior.Enabled = false;
            exterior_price = 0.00;
            lblNumExterior.Text = "UNAVAILABLE";
        }

        private void SetInteriorNormal()
        {
            interior_price = INTERIOR_PRICE;
            lblNumInterior.Text = "$" + interior_price + "/ea";
        }

        private void SetInteriorSale()
        {
            interior_price = INTERIOR_PRICE_SALE;
            lblNumInterior.Text = "$" + interior_price + "/ea";
        }
    }
}
