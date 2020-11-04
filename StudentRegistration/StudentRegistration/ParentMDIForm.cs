//Christine Jordan
//HW 4 10.30.2020
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
    public partial class ParentMDIForm : Form
    {
        public ParentMDIForm() //setting MDI to be main form
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        private void ParentMDIForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateStatusBar(string message) //updates status bar 
        {
            statusStrip.Items[0].Text = message;
            statusStrip.Update();
        }

        private void coursesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CoursesForm form = new CoursesForm();
            form.MdiParent = this;
            form.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionForm form = new SectionForm();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
