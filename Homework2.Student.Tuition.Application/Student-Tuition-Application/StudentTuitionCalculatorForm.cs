//Christine Jordan 10.6.2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Tuition_Application
{
    public partial class StudentTuitionCalculatorForm : Form
    {

        private ResidentStatuses selectedStatus = ResidentStatuses.Resident;

        public StudentTuitionCalculatorForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int credits = (int)creditsUpDown.Value;
            double tuitionRate = Calculator.CalculateTuition(credits, selectedStatus);
            tuitionAmountLabel.Text = tuitionRate.ToString("C");
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            creditsUpDown.Value = 0;
            residentRadioBtn.Checked = true;
            nonResUSCitRadioBtn.Checked = false;
            NonResNonUSRadioBtn.Checked = false;
            tuitionAmountLabel.Text = 0.0.ToString("C");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void residentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender; //casting object sender to radio button
            if (rb.Checked)
            {
                selectedStatus = ResidentStatuses.Resident;
            } 
        }

        private void nonResUSCitRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                selectedStatus = ResidentStatuses.NonResidentUS;
            }
        }

        private void NonResNonUSRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                selectedStatus = ResidentStatuses.NonResidentNonUS;
            }
        }
    }
}
