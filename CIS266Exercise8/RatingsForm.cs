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
    public partial class RatingsForm : Form
    {
        public RatingsForm()
        {
            InitializeComponent();
        }

        private void SetStatusInfo(string message)
        {
            MainForm main = (MainForm)MdiParent;
            main.SetReadyLabel(message);
        }

        private void ratingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string message;
            try
            { 
                this.Validate();
                this.ratingsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.moviesDataSet);
                message= "Ratings saved";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }

        private void RatingsForm_Load(object sender, EventArgs e)
        {
            string message;
            try
            { 
            // TODO: This line of code loads data into the 'moviesDataSet.Ratings' table. You can move, or remove it, as needed.
                this.ratingsTableAdapter.Fill(this.moviesDataSet.Ratings);
                message = "Ratings form open";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }
    }
}
