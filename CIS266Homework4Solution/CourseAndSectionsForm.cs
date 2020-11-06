using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class CourseAndSectionsForm : Form
    {
        public CourseAndSectionsForm()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try //creating try catch to exceptions if anything breaks --cmj
            {
                this.Validate();
                this.coursesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registrationDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void CourseAndSectionsForm_Load(object sender, EventArgs e)
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
    }
}
