//Christine Jordan
//HW4 10.30.2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()//constructor
        {
            InitializeComponent();
            
        }

        private void tblCoursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ParentMDIForm parentForm = (ParentMDIForm)MdiParent; //getting the parent form
            if (this.Validate()) //if valid saving and update
            {
                this.tblCoursesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registrationDataSet);
                parentForm.UpdateStatusBar($"Updated/Saved {registrationDataSet.tblCourses.Count} Courses!");//updating status bar on parent form
            }
            else //if not valid
            {
                parentForm.UpdateStatusBar("Invalid Data. Save Failed.");//status bar updated with information
            }
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.tblCourses' table. You can move, or remove it, as needed.
            this.tblCoursesTableAdapter.Fill(this.registrationDataSet.tblCourses);
            ParentMDIForm parentForm = (ParentMDIForm)MdiParent;
            parentForm.UpdateStatusBar($"Total Courses loaded: [{this.registrationDataSet.tblCourses.Count}]"); //injects value of property straight into string
        }
    }
}
