using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Christine Jordan
//11.6.2020
//Homework 5 Student Registration
namespace Homework4
{
    public partial class CourseAndSectionsForm : Form
    {
        public CourseAndSectionsForm() //constructor
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e) //save item method
        {
            try //creating try catch to exceptions if anything breaks --cmj
            {
                this.Validate();
                this.coursesBindingSource.EndEdit();

                foreach (var item in registrationDataSet.Courses)//extra credit
                {
                    if (item.RowState == DataRowState.Deleted) //looking for deleted row state
                    {

                    }
                }

                this.tableAdapterManager.UpdateAll(this.registrationDataSet);

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void CourseAndSectionsForm_Load(object sender, EventArgs e) //form loading method
        {
            try //creating try catch --cmj
            {
                // TODO: This line of code loads data into the 'registrationDataSet.Sections' table. You can move, or remove it, as needed.
                this.sectionsTableAdapter.Fill(this.registrationDataSet.Sections);
                // TODO: This line of code loads data into the 'registrationDataSet.Courses' table. You can move, or remove it, as needed.
                this.coursesTableAdapter.Fill(this.registrationDataSet.Courses);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //attempt at extra credit.
        {
            if (int.TryParse(courseIdTextBox.Text, out int courseIdToDelete))
            {
                //Foreign key constraint sections removed first.
                foreach (var section in registrationDataSet.Sections)
                {
                    if (section.CourseID == courseIdToDelete)
                    {
                        section.Delete();
                    }
                }

                //Delete Course after Sections removed
                foreach (var course in registrationDataSet.Courses)
                {
                    if (course.CourseId == courseIdToDelete)
                    {
                        course.Delete();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to delete: Not a valid course id.");
            }
        }
    }
}
