using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double pikas = 5;
        double chards = 13.5;
        double mutus = 50;

        double numOfPikas = 0;
        double numOfChards = 0;
        double numOfMutus = 0;

        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalCost = 0;

        double tendered = 0;
        double change = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOfPikasInput.Text == "")
                {
                    numOfPikas = 0;
                    numOfPikasInput.Text = "0";
                }
                else
                {
                    numOfPikas = Convert.ToDouble(numOfPikasInput.Text);
                }
                
                if (numOfChardsInput.Text == "")
                {
                    numOfChards = 0;
                    numOfChardsInput.Text = "0";
                }
                else
                {
                    numOfChards = Convert.ToDouble(numOfChardsInput.Text);
                }

                if (numOfMutusInput.Text == "")
                {
                    numOfMutus = 0;
                    numOfMutusInput.Text = "0";
                }
                else
                {
                    numOfMutus = Convert.ToDouble(numOfMutusInput.Text);
                }

                subTotal = (numOfPikas * pikas) + (numOfChards * chards) + (numOfMutus * mutus);
                subTotalAmountOutput.Text = subTotal.ToString("C");

                taxAmount = taxRate * subTotal;
                taxAmountOutput.Text = taxAmount.ToString("C");

                totalCost = subTotal + taxAmount;
                totalAmountOutput.Text = totalCost.ToString("C");

                calculateChangeButton.Enabled = true;
            }
            catch
            {
                subTotalAmountOutput.Text = "INVALID";
                taxAmountOutput.Text = "INVALID";
                totalAmountOutput.Text = "INVALID";
            }
                

        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenderedInput.Text == "")
                {
                    changeAmountOutput.Text = "INVALID";
                }
                else
                {
                    tendered = Convert.ToDouble(tenderedInput.Text);
                }


                change = totalCost - tendered;
                

                if (tendered < totalCost)
                {
                    changeAmountOutput.Text = "NSFj";
                }
                else
                {
                    changeAmountOutput.Text = change.ToString("C");
                }

            }
            catch { }
        }
    }
}
