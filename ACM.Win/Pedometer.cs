﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;

namespace ACM.Win
{
    public partial class Pedometer : Form
    {
        public Pedometer()
        {
            InitializeComponent();
        }

        // Try setting "Step Goal for Today" to 0 -> DivideByZeroException
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text, this.StepsTextBox.Text);

            this.ResultLabel.Text = $@"You reached {result} % of your goal!";
        }
    }
}
