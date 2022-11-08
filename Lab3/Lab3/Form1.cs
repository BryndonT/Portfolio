// Grading ID: S1908 
// Lab Number: Lab3
// Due Date: 02/14/2021
// Course Section: CIS 199-02
// This program takes the radius of a sphere and converts it into a diamter, surface area, and volume when calculate is pressed.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void btnCalculateEquations_Click(object sender, EventArgs e)
        {
            double RadiusNumber; // Declares RadiusNumber a variable
            RadiusNumber = double.Parse(lblRadiusInput.Text); // Says RadiusNumber is equal to the radius the user enters
            double DiameterEquation; // Declares equation for diameter
            double SurfaceAreaEquation; // Declares equation for surface area
            double VolumeEquation; // Decllares equation for volume

            DiameterEquation = 2 * RadiusNumber; // Assigns the diameter equation to to the variable DiameterEquation
            SurfaceAreaEquation = 4 * Math.PI * Math.Pow(RadiusNumber, 2); // Assigns the surface area equation to the variable SurfaceAreaEquation
            VolumeEquation = (4 * Math.PI * Math.Pow(RadiusNumber, 3) / 3); // Assigns the volume equation to the variable VolumeEquation

            lblDiameterOutput.Text = $"{DiameterEquation:F2}"; // Assigns the diameter output to the label lblDiameterOutput
            lblSurfaceAreaOutput.Text = $"{SurfaceAreaEquation:F2}"; // Assigns the surface area output to the label lblSurfaceAreaOutput
            lblVolumeOutput.Text = $"{VolumeEquation:F2}"; // Assigns the volume output to the label lblVolumeOutput
        }
    }
}

