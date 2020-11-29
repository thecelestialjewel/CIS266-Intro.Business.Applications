using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework4.RegistrationDataSet;

namespace Homework4
{
    //Christine Jordan 
    //Homework 6 Student Registration
    //11.29.2020
    public partial class StudentListForm : Form //Student list inherits from form 
    {
        //Constructor that initializes component
        public StudentListForm()
        {
            
            InitializeComponent();
        }

        
        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        { //Click event that saves dataset changes back to database
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.registrationDataSet.Students);
            //Fill Enrollment w/ Data
            this.enrollmentTableAdapter.Fill(this.registrationDataSet.Enrollment);
            //Fill Courses w/ Data
            this.coursesTableAdapter.Fill(this.registrationDataSet.Courses);
            //Fill Registration w/ Data
            this.sectionsTableAdapter.Fill(this.registrationDataSet.Sections);
        

        }

        // REF: https://stackoverflow.com/questions/14679253/how-to-append-two-field-values-in-combobox-display-member-in-c-sharp?fbclid=IwAR1kiN0iZLU35cfo8NZKdP9BUpsw6zHYyaeezYixjB4JZPsw3Qda7OGsmtg
        private void studentsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            //Concat. First & Last Name
            e.Value = ((DataRowView)e.ListItem).Row["FirstName"] + " " + ((DataRowView)e.ListItem).Row["LastName"];


        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IF a student selected, go into scope
            if (studentsListBox.SelectedIndex != -1) 
            {
                DataRowView view = (DataRowView)studentsListBox.SelectedItem;
                StudentsRow row = (StudentsRow)view.Row;
                
                if (!string.IsNullOrWhiteSpace(row.StudentID))
                {
                    //course counter
                    int courseCount = 0;
                    //catch total credits attempted
                    int creditsAttempted = 0;
                    //Going through each row in enrollments.
                    foreach (EnrollmentRow eRow in registrationDataSet.Enrollment.Rows)
                    {
                        //If the student id matches, go into scope
                        if (eRow.Student == row.StudentID)
                        {
                            //for each section row in sections
                            foreach (SectionsRow sRow in registrationDataSet.Sections.Rows)
                            {
                                //If enrollment section id matches the current section id, go into scope
                                if (sRow.SectionId == eRow.Section)
                                {
                                    //increment course count
                                    courseCount++;

                                    //**HOMEWORK 6: EXTRA CREDIT**
                                    foreach (CoursesRow cRow in registrationDataSet.Courses.Rows)
                                    {
                                        //IF section course id matches current course id, go into scope
                                        if (sRow.CourseID == cRow.CourseId)
                                        {
                                            //accumulating credits attempted
                                            creditsAttempted += cRow.Credits;
                                        }
                                    }
                                }

                            }
                        }
                    }
                    //Update Controls
                    courseEnrolledTxtbx.Text = courseCount.ToString();
                    creditsAttemptedTxtbox.Text = creditsAttempted.ToString();
                }
                else
                {
                    MessageBox.Show("Emtpy student id.");
                }
            }
        }
    }
}
