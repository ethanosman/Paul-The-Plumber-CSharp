using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaulsTimber
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {

        }

        // Clear form's contents
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLabourHours.Text = "0";
            txtTravelLength.Text = "0";
            txtPlasticPipeLength.Text = "0";

            lblLabourCosts.Text = "Labour Costs: £0";
            lblTravelCosts.Text = "Travel Costs: £0";
            lblPlasticPipeCosts.Text = "Plastic Pipe Costs: £0";

            lblTotalCosts.Text = "Total Costs: £0";
        }

        // Exit button to close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Calculate button to work out various costs
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double labourCosts, travelCosts, plasticPipeCosts, totalCosts;

            labourCosts = double.Parse(txtLabourHours.Text) * 35.00;
            travelCosts = double.Parse(txtTravelLength.Text) * 2.00;
            plasticPipeCosts = double.Parse(txtPlasticPipeLength.Text) * 3.00;

            totalCosts = labourCosts + travelCosts + plasticPipeCosts;

            lblLabourCosts.Text = "Labour Costs: £" + labourCosts.ToString("#.##");
            lblTravelCosts.Text = "Travel Costs: £" + travelCosts.ToString("#,##");
            lblPlasticPipeCosts.Text = "Plastic Pipe Costs: £" + plasticPipeCosts.ToString("#,##");

            lblTotalCosts.Text = "Total Costs: £" + totalCosts.ToString("#,##");
        }
    }
}
