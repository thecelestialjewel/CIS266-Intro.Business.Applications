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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.registrationDataSet.Students);

        }

        //
        private void studentsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((DataRowView)e.ListItem).Row["FirstName"] + " " + ((DataRowView)e.ListItem).Row["LastName"];


        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
