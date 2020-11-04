//Christine Jordan 10.13.2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3.StudentTuitionCalculator
{
    public partial class StudentTuitionCalculator : Form
    {
        private ResidentStatuses selectedStatus = ResidentStatuses.Resident;
        private Calculations calculations = new Calculations();
        public StudentTuitionCalculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(studentIDTxtbx.Text, (int)creditAmountNumericUpDown.Value, selectedStatus);
            
            decimal tuitionRate = calculator.CalculateTuition();
            tuitionAmountLabel.Text = tuitionRate.ToString("C");

            calculations.Add(calculator); //add current calculator to calculations list
            tuitionListBox.Items.Add(calculator); //add tuition string to listbox

        }

        private void clearBtn_Click(object sender, EventArgs e) //clearing all values
        {
            tuitionAmountLabel.Text = 0.0.ToString("C");
            creditAmountNumericUpDown.Value = 0;
            studentIDTxtbx.Clear();
            residentRadioBtn.Checked = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close(); //exit will close form
        }

        private void tuitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tuitionListBox.SelectedIndex !=-1)//checking user clicks something in the list box
            {
                Calculator calculator = calculations[tuitionListBox.SelectedIndex]; //getting a specific calculation for a student at an index
                studentIDTxtbx.Text = calculator.StudentID;
                creditAmountNumericUpDown.Value = calculator.CreditAmount;
                decimal tuition = calculator.CalculateTuition(); //declarung variable and capturing tuition calculation
                tuitionAmountLabel.Text = tuition.ToString("C"); //to string into currency

                switch (calculator.ResidentStatus) //switch that checks which state a resident status is in
                {
                    case ResidentStatuses.Resident:
                        residentRadioBtn.Checked = true;
                        break;
                    case ResidentStatuses.NonResidentUS:
                        nonResUsCitizenRadioBtn.Checked = true;
                        break;
                    case ResidentStatuses.NonResidentNonUS:
                        nonResNonUsCitizenRadioBtn.Checked = true;
                        break;
                }
            }
        }

        private void residentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (residentRadioBtn.Checked)
            {
                selectedStatus = ResidentStatuses.Resident;
            }
        }

        private void nonResUsCitizenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (nonResUsCitizenRadioBtn.Checked)
            {
                selectedStatus = ResidentStatuses.NonResidentUS;
            }
        }

        private void nonResNonUsCitizenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (nonResNonUsCitizenRadioBtn.Checked)
            {
                selectedStatus = ResidentStatuses.NonResidentNonUS;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tuitionListBox.SelectedIndex != -1)
            {
                
                calculations.RemoveAt(tuitionListBox.SelectedIndex);//removing calculator object from calculations list
                tuitionListBox.Items.RemoveAt(tuitionListBox.SelectedIndex);
            }
        }
    }
}
