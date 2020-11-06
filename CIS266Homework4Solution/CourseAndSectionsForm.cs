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
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void CourseAndSectionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.registrationDataSet.Courses);

        }
    }
}
