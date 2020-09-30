using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1.StudentTracking
{
    public partial class StudentTrackingForm : Form
    {
       
        public StudentTrackingForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student(firstNameTxtbx.Text,
                                          lastNameTxtbx.Text,
                                          idTxtBox.Text,
                                          waResidentCheckBox.Checked,
                                          majorCombobox.SelectedItem.ToString(),
                                          applicationPicker.Value);
            if (!string.IsNullOrWhiteSpace(emailTxtbx.Text))
            {
                student.EmailAddress = emailTxtbx.Text;
            }
            if (!string.IsNullOrWhiteSpace(phoneTxtbx.Text))
            {
                student.PhoneNumber = phoneTxtbx.Text;
            }
            student.Birthday = birthdayPicker.Value;
            

            studentApplications.Items.Add(student);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Student removeStudent = studentApplications.SelectedItem as Student; //casting 
            if (removeStudent != null)
            {
                studentApplications.Items.Remove(removeStudent);
            }
            else
            {
                MessageBox.Show("Select student to remove.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTxtbx.Clear();
            lastNameTxtbx.Clear();
            idTxtBox.Clear();
            waResidentCheckBox.Checked = false;
            majorCombobox.SelectedItem = null;
            applicationPicker.Value = DateTime.Now;
            emailTxtbx.Clear();
            phoneTxtbx.Clear();
            birthdayPicker.Value = DateTime.Now;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studentApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStudent = studentApplications.SelectedItem as Student;
            if (selectedStudent != null)
            {
                firstNameTxtbx.Text = selectedStudent.FirstName;
                lastNameTxtbx.Text = selectedStudent.LastName;
                idTxtBox.Text = selectedStudent.StudentID;
                waResidentCheckBox.Checked = selectedStudent.IsWaResident;
                majorCombobox.SelectedItem = selectedStudent.Major;
                applicationPicker.Value = selectedStudent.ApplicationDate;
                emailTxtbx.Text = selectedStudent.EmailAddress;
                phoneTxtbx.Text = selectedStudent.PhoneNumber;
                birthdayPicker.Value = selectedStudent.Birthday;
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }

        }
    }
}
