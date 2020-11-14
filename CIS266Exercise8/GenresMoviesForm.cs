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
    public partial class GenresMoviesForm : Form
    {
        public GenresMoviesForm()
        {
            InitializeComponent();
        }

        private void SetStatusInfo(string message)
        {
            MainForm main = (MainForm)MdiParent;
            main.SetReadyLabel(message);
        }
        private void genresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string message;
            try
            {
                this.Validate();
                this.genresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.moviesDataSet);
                message = "Entries saved";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }

        private void GenresMoviesForm_Load(object sender, EventArgs e)
        {
            string message;
            try
            {

                // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
                this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);
                // TODO: This line of code loads data into the 'moviesDataSet.MovieGenres' table. You can move, or remove it, as needed.
                this.movieGenresTableAdapter.Fill(this.moviesDataSet.MovieGenres);
                // TODO: This line of code loads data into the 'moviesDataSet.Genres' table. You can move, or remove it, as needed.
                this.genresTableAdapter.Fill(this.moviesDataSet.Genres);
                message = "Genres with movies open";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            SetStatusInfo(message);
        }
    }
}
