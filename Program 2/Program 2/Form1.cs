// Grading ID: S1908
// Program 2
// Due Date: 03/11/2021
// Course Section: CIS 199-02
// This program caluclates the cost for 3 different delivery companies and displays the cheapest option.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void btnCalculateAll_Click(object sender, EventArgs e)
        {
            int PeopleInput; // These lines establish variables.
            double MilesInput;
            int DaysInput;
            int CompanyAPeople;
            double CompanyAMiles;
            int CompanyADays;
            const int CompanyAPeopleRate = 1;
            const double CompanyAMilesRate = 0.02;
            double CompanyATotal;
            double CompanyBPeople;
            double CompanyBMiles;
            int CompanyBDays;
            const double CompanyBMilesRate = 0.10;
            double CompanyBTotal;
            double CompanyCPeople;
            double CompanyCMiles;
            const int CompanyCDays = 20;
            const double CompanyCPeopleRate = 0.25;
            double CompanyCTotal;

            PeopleInput = int.Parse(txtPeopleInput.Text);
            MilesInput = double.Parse(txtMilesInput.Text);
            DaysInput = int.Parse(txtDaysInput.Text);
            CompanyAPeople = int.Parse(txtPeopleInput.Text);
            CompanyAMiles = int.Parse(txtMilesInput.Text);
            CompanyADays = int.Parse(txtDaysInput.Text);
            CompanyBPeople = int.Parse(txtPeopleInput.Text);
            CompanyBDays = int.Parse(txtDaysInput.Text);
            CompanyCMiles = double.Parse(txtMilesInput.Text);

            if (PeopleInput > 0) // These lines calculate people cost for company A and displays an error if an invalid entry is entered.
                CompanyAPeople = PeopleInput * CompanyAPeopleRate;
            else
                MessageBox.Show("Invalid Number of People!");

            if (MilesInput > 0) // These lines calculate miles cost for company A and displays an error if an invalid entry is entered.
                CompanyAMiles = MilesInput * CompanyAMilesRate;
            else
                MessageBox.Show("Invalid Distance!");

            if (DaysInput == 1) // These lines determine which cost to assign days for company A and displays an error of an invalid entry is entered.
                CompanyADays = 20;
            else
            {
                if (DaysInput == 2)
                    CompanyADays = 17;
                else
                    if (DaysInput == 3)
                        CompanyADays = 15;
                    else
                        if (DaysInput >= 4 && DaysInput <= 7)
                            CompanyADays = 10;
                        else
                            if (DaysInput > 7)
                                CompanyADays = 7;
                            else
                                MessageBox.Show("Invalid Delivery Days!");
            }
        
            CompanyATotal = CompanyAPeople + CompanyAMiles + CompanyADays; // Calculates total cost for company A.

            if (PeopleInput > 0 && PeopleInput < 10) // These lines determine which price to assign company B people.
                CompanyBPeople = PeopleInput * 20;
            else
            {
                if (PeopleInput >= 10 && PeopleInput < 50)
                    CompanyBPeople = PeopleInput * 10;
                else
                    if (PeopleInput >= 50 && PeopleInput < 100)
                        CompanyBPeople = PeopleInput * 5;
                    else
                        if (PeopleInput >= 100 && PeopleInput < 200)
                            CompanyBPeople = PeopleInput * 3;
                        else
                            if (PeopleInput >= 200)
                                CompanyBPeople = PeopleInput * 0.15;
            }

            CompanyBMiles = MilesInput * CompanyBMilesRate; // This line calculates the total miles for company B.

            if (DaysInput >= 1 && DaysInput <= 4) // These lines determine the cost for days in company B.
                CompanyBDays = 10;
            else
            { if (DaysInput > 4)
                    CompanyBDays = 7;
            }

            CompanyBTotal = CompanyBPeople + CompanyBMiles + CompanyBDays; // This line calculates the total cost for company B.

            CompanyCPeople = PeopleInput * CompanyCPeopleRate; // This line calculates the people cost for company C.

            if (MilesInput > 0 && MilesInput < 200) // These lines determine the miles cost for company C.
                CompanyCMiles = 10;
            else
            {
                if (MilesInput >= 200 && MilesInput < 500)
                    CompanyCMiles = 15;
                else
                    if (MilesInput >= 500 && MilesInput < 750)
                    CompanyCMiles = 25;
                    else
                        if (MilesInput >= 750 && MilesInput < 1000)
                    CompanyCMiles = 35;
                        else
                            if (MilesInput >= 1000)
                    CompanyCMiles = 40;
            }

            CompanyCTotal = CompanyCPeople + CompanyCMiles + CompanyCDays; // This line calculates the total cost for company C.

            if (CompanyATotal < CompanyBTotal && CompanyATotal < CompanyCTotal) // These lines determine the company with the lowest cost and displays it on a label.
                lblLowestCost.Text = "The lowest cost company is: A";
            if (CompanyBTotal < CompanyATotal && CompanyBTotal < CompanyCTotal)
                lblLowestCost.Text = "The lowest cost company is: B";
            if (CompanyCTotal < CompanyATotal && CompanyCTotal < CompanyBTotal)
                lblLowestCost.Text = "The lowest cost company is: C";

            lblCompanyACost.Text = $"{CompanyATotal:C}"; // These lines output each companies' total cost on each appropriate label.
            lblCompanyBCost.Text = $"{CompanyBTotal:C}";
            lblCompanyCCost.Text = $"{CompanyCTotal:C}";
        }
    }
}
