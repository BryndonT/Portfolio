// Grading ID: S1908
// Program Number: 1
// Due Date: 02/16/2021
// Course Section: CIS 199-02 
// This program requires the user to fill in textboxes with information regarding their garden/land and converts it to indivudal costs and a total cost estimate.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void btnCalculateEstimate_Click(object sender, EventArgs e)
        {
            const double AddLaborCost = 50; // Lines 31-35 declare constants for rates and a conversion to sq yards.
            const double FertilizerRate = 4.25; 
            const double ExtraFertilizer = 1.1;
            const double LaborRate = 3.25;
            const double SqYardsConversion = 9;
            double GardenLengthInput; // Lines 36-40 declares the variables used for gather user input data from textboxes.
            double GardenWidthInput;
            double SoilPriceInput;
            double FertilizerInput;
            double FirstGardenInput;
            double SquareYards; // Lines 41-45 declares the variables that are used when calculating the relative equations.
            double SoilCost;
            double FertilizerCost;
            double LaborCost;
            double TotalCost;

            GardenLengthInput = double.Parse(txtWidthOfGardenOutput.Text); // Lines 47-51 takes user information from the textboxes and puts them into variables.
            GardenWidthInput = double.Parse(txtLengthOfGardenOutput.Text);
            SoilPriceInput = double.Parse(txtSoilPriceOutput.Text);
            FertilizerInput = double.Parse(txtFertilizerOutput.Text);
            FirstGardenInput = double.Parse(txtFirstGardenOutput.Text);

            SquareYards = (GardenLengthInput * GardenWidthInput) / SqYardsConversion; // Calculates square yards

            SoilCost = (SquareYards * SoilPriceInput) * ExtraFertilizer; // Calculates soil cost

            FertilizerCost = SquareYards * FertilizerRate; // Caluclates fertilizer cost. 1 for being included and 0 for not being included in the total cost.
            if (FertilizerInput < 1)
                FertilizerCost = 0;

            LaborCost = SquareYards * LaborRate; // Calculates labor cost. If a first garden has a 1, an extra 50 is charged to the labor cost.
            if (FirstGardenInput > 0)
                LaborCost += AddLaborCost;

            TotalCost = SoilCost + FertilizerCost + LaborCost; // Calculates the total cost by adding the three individual costs.

            lblSqYardsOutput.Text = $"{SquareYards:F1}"; // Lines 68-72 output the calculated estimates onto the correct labels.
            lblSoilCostOutput.Text = $"{SoilCost:C2}";
            lblFertilizerCostOutput.Text = $"{FertilizerCost:C2}";
            lblLaborCostOutput.Text = $"{LaborCost:C2}";
            lblTotalCostOutput.Text = $"{TotalCost:C2}";


        }
    }
}
