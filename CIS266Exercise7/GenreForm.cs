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
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void genresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.moviesDataSet);

        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.moviesDataSet.Genres);

        }
    }
}
