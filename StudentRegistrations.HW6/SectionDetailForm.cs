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
    public partial class SectionDetailForm : Form
    {
        public SectionDetailForm()
        {
            InitializeComponent();
        }

        private void SetReady(string message)
        {
            ((MainForm)MdiParent).SetReadyLabel(message);
        }

        private void sectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sectionsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registrationDataSet);
                SetReady("Section data saved");
            }
            catch { SetReady("Error saving data for sections form"); }
        }

        private void SectionDetailForm_Load(object sender, EventArgs e)
        {            
            try
            {
                RegistrationDataSetTableAdapters.CoursesTableAdapter taCourses =
                    new RegistrationDataSetTableAdapters.CoursesTableAdapter();
                taCourses.Fill(registrationDataSet.Courses);
                // TODO: This line of code loads data into the 'registrationDataSet.Sections' table. You can move, or remove it, as needed.
                this.sectionsTableAdapter.Fill(this.registrationDataSet.Sections);
                SetReady("Section details form open");
            }
            catch { SetReady("Error loading data for sections form"); }
        }
    }
}
