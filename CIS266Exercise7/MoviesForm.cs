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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void SetStatusInfo(string message)
        {
            MainForm main = (MainForm)MdiParent;
            main.SetReadyLabel(message);
        }
        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string message;
            try
            {
                this.Validate();
                this.moviesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.moviesDataSet);
                message = "Movies saved";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            string message;
            try
            {
                // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
                this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);
                message = "Movies form open";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }
    }
}
