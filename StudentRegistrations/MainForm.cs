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
//Student Registration HW5
namespace Homework4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetReadyLabel(string message)
        {
            tslReady.Text = message;
        }


        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CoursesForm());
        }

        private void sectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new SectionDetailForm());
        }

        private void courseAndSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CourseAndSectionsForm()); //instantiating form
        }


        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); //layout be horizontal for open windows
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //will cascade the windows
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren) //looping through each open child window
            {
                form.Close();
            }
        }
    }
}
