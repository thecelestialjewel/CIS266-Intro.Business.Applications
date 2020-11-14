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
    public partial class ActorsForm : Form
    {
        private bool isLoaded = false;
        public ActorsForm()
        {
            InitializeComponent();
        }
        private void SetUpActors()
        {
            //binding data from the dataset actors section to datasource of listbox
            actorListBox.DataSource = moviesDataSet1.Actors;
            actorListBox.DisplayMember = "StageName";
            actorListBox.ValueMember = "ActorId";
        }
        private void ActorsForm_Load(object sender, EventArgs e)
        {
            try
            {
                actorsTableAdapter1.Fill(moviesDataSet1.Actors); //filling table
                movieActorsTableAdapter1.Fill(moviesDataSet1.MovieActors);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            SetUpActors();
            isLoaded = true;
        }
         
        private void actorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                if (actorListBox.SelectedIndex != -1)
                {
                    DataRowView selectedActor = (DataRowView)actorListBox.SelectedItem;
                    MoviesDataSet.ActorsRow actorRow = (MoviesDataSet.ActorsRow)selectedActor.Row;

                    firstNameTxtBx.Text = actorRow.FirstName;
                    lastNameTxtBx.Text = actorRow.LastName;
                    birthdayTxtBx.Text = actorRow.Birthday.ToString("d");//short date formatting
                    stageNameTxtBx.Text = actorRow.StageName;

                    int actorID = (int)actorListBox.SelectedValue;

                    int numMoviesPlayedIn = 0; //creating variable for accumulator
                    foreach (DataRow movieActorRow in moviesDataSet1.MovieActors.Rows) //extra credit count number of movies an actor has played
                    {
                        if ((int)movieActorRow[2] == actorID)
                        {
                            numMoviesPlayedIn++; //incrementing by 1 each time we have a match
                        }

                    }
                    moviesPlayedValueLbl.Text = numMoviesPlayedIn.ToString();
                }
            }

        }
    }
}
