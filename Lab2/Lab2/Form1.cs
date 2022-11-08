// Grading ID: S1908
// Lab Number 2
// Due Date: /02/07/2021
// CIS 199-02
// Program Description: This program takes a user number input and calculates three different tiprates including 15%, 18%, and 20%.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e) // Calculates user input price times tiprates 15%, 18%, and 20%.
        {
            double MealPrice; // User input number
            double Tip15Amount; // Variable for MealPrice times tiprate 15%
            double Tip18Amount; // Variable for MealPrice times tiprate 18%
            double Tip20Amount; // Variable for MealPrice times tiprate 20%
            MealPrice = double.Parse(MealPriceInput.Text); // Assignts the user input number to MealPrice
            const double Tip15Rate = 0.15; // Constant for tiprate 15%
            const double Tip18Rate = 0.18; // Constant for tiprate 18%
            const double Tip20Rate = 0.20; // Constant for tiprate 20%

            Tip15Amount = MealPrice * Tip15Rate; // Multiplies user input price and tiprate 15%
            Tip18Amount = MealPrice * Tip18Rate; // Multiplies user input price and tiprate 18%
            Tip20Amount = MealPrice * Tip20Rate; // Multiplies user input price and tiprate 20%

            Output15Percent.Text = $"{Tip15Amount:C}"; // Assignts the label the output value for the calculation MealPrice times tiprate 15%
            Output18Percent.Text = $"{Tip18Amount:C}"; // Assignts the label the output value for the calculation MealPrice times tiprate 18%
            Output20Percent.Text = $"{Tip20Amount:C}"; // Assignts the label the output value for the calculation MealPrice times tiprate 20%


        }


    }
}
