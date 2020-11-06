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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

       private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.coursesBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.registrationDataSet);
                this.coursesTableAdapter.Update(this.registrationDataSet);
                ShowOnParent("Courses data saved");
            }
            catch
            {
                MessageBox.Show("error saving data");
            }
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'registrationDataSet.Courses' table. You can move, or remove it, as needed.
                this.coursesTableAdapter.Fill(this.registrationDataSet.Courses);
                ShowOnParent("Courses grid form open");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"Error reading data"); }
        }

        private MainForm MyParent
        {
            get { return (MainForm)MdiParent; }
        }

        private void ShowOnParent(string info)
        {
            MyParent.SetReadyLabel(info);
        }

        private void coursesDataGridView_DataError(object sender, 
            DataGridViewDataErrorEventArgs e)
        {
            int rowError = e.RowIndex;
            MessageBox.Show("Error in row " + (rowError + 1).ToString());
            ShowOnParent("Error in entry");
        }
    }
}
