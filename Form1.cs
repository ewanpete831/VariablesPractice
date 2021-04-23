using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_click(object sender, EventArgs e)
        {
            //set up variables
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            //change text
            outputLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void areaButton_click(object sender, EventArgs e)
        {
            //set up variables
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            //change text
            outputLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2";

        }

        private void carpetButton_click(object sender, EventArgs e)
        {
            //set up variables
            double length = 8.5;
            double width = 6;
            double costPerMetre = 19.95;
            double area = length * width;
            double totalCost = area * costPerMetre;

            //change text
            outputLabel.Text = $"The area of a room with dimensions of {length}m x {width}m is: {area}m^2" +
                $"\n\nThe cost to carpet this area at ${costPerMetre} per metre is ${totalCost}";

        }

        private void billButton_click(object sender, EventArgs e)
        {
            //set up variables
            double costOfShirt = 12.49;
            double taxRate = 0.13;
            double taxPaid = taxRate * costOfShirt;
            double totalBill = costOfShirt + taxPaid;
            double tendered = 20.00;
            double change = tendered - totalBill;

            //change text
            outputLabel.Text = "Bill of Sale";
            outputLabel.Text += $"\n\nShirt:                 ${costOfShirt}";
            outputLabel.Text += $"\n\nTax:                 ${taxPaid}";
            outputLabel.Text += $"\nTotal:              ${totalBill}";
            outputLabel.Text += $"\n\nTendered:                 ${tendered}";
            outputLabel.Text += $"\nChange:              ${change}";
        }
    }
}
