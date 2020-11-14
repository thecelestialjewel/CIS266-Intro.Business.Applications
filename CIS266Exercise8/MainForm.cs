using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
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

        private void ShowForm(Form formToShow)
        {
            formToShow.MdiParent = this;
            formToShow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetReadyLabel("Movies application open");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?",
                "Close", MessageBoxButtons.YesNo);
            if (dialog== DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new MoviesForm());
        }        

        private void ratingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new RatingsForm());
        }

        private void genresWithMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new GenresMoviesForm());
        }

        private void actorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new ActorsForm());
        }
    }
}
