namespace Movies
{
    partial class ActorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moviesDataSet1 = new Movies.MoviesDataSet();
            this.actorsTableAdapter1 = new Movies.MoviesDataSetTableAdapters.ActorsTableAdapter();
            this.actorListBox = new System.Windows.Forms.ListBox();
            this.firstNameTxtBx = new System.Windows.Forms.TextBox();
            this.lastNameTxtBx = new System.Windows.Forms.TextBox();
            this.birthdayTxtBx = new System.Windows.Forms.TextBox();
            this.stageNameTxtBx = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.stageNameLbl = new System.Windows.Forms.Label();
            this.movieActorsTableAdapter1 = new Movies.MoviesDataSetTableAdapters.MovieActorsTableAdapter();
            this.moviesPlayedInLbl = new System.Windows.Forms.Label();
            this.moviesPlayedValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesDataSet1
            // 
            this.moviesDataSet1.DataSetName = "MoviesDataSet";
            this.moviesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorsTableAdapter1
            // 
            this.actorsTableAdapter1.ClearBeforeFill = true;
            // 
            // actorListBox
            // 
            this.actorListBox.FormattingEnabled = true;
            this.actorListBox.Location = new System.Drawing.Point(45, 23);
            this.actorListBox.Name = "actorListBox";
            this.actorListBox.Size = new System.Drawing.Size(148, 199);
            this.actorListBox.TabIndex = 0;
            this.actorListBox.SelectedIndexChanged += new System.EventHandler(this.actorListBox_SelectedIndexChanged);
            // 
            // firstNameTxtBx
            // 
            this.firstNameTxtBx.Location = new System.Drawing.Point(208, 45);
            this.firstNameTxtBx.Name = "firstNameTxtBx";
            this.firstNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxtBx.TabIndex = 1;
            // 
            // lastNameTxtBx
            // 
            this.lastNameTxtBx.Location = new System.Drawing.Point(208, 115);
            this.lastNameTxtBx.Name = "lastNameTxtBx";
            this.lastNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxtBx.TabIndex = 2;
            // 
            // birthdayTxtBx
            // 
            this.birthdayTxtBx.Location = new System.Drawing.Point(208, 181);
            this.birthdayTxtBx.Name = "birthdayTxtBx";
            this.birthdayTxtBx.Size = new System.Drawing.Size(100, 20);
            this.birthdayTxtBx.TabIndex = 3;
            // 
            // stageNameTxtBx
            // 
            this.stageNameTxtBx.Location = new System.Drawing.Point(208, 229);
            this.stageNameTxtBx.Name = "stageNameTxtBx";
            this.stageNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.stageNameTxtBx.TabIndex = 4;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(205, 23);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameLbl.TabIndex = 5;
            this.firstNameLbl.Text = "First Name:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(205, 88);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameLbl.TabIndex = 6;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Location = new System.Drawing.Point(205, 153);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(48, 13);
            this.birthdayLbl.TabIndex = 7;
            this.birthdayLbl.Text = "Birthday:";
            // 
            // stageNameLbl
            // 
            this.stageNameLbl.AutoSize = true;
            this.stageNameLbl.Location = new System.Drawing.Point(124, 236);
            this.stageNameLbl.Name = "stageNameLbl";
            this.stageNameLbl.Size = new System.Drawing.Size(69, 13);
            this.stageNameLbl.TabIndex = 8;
            this.stageNameLbl.Text = "Stage Name:";
            // 
            // movieActorsTableAdapter1
            // 
            this.movieActorsTableAdapter1.ClearBeforeFill = true;
            // 
            // moviesPlayedInLbl
            // 
            this.moviesPlayedInLbl.AutoSize = true;
            this.moviesPlayedInLbl.Location = new System.Drawing.Point(124, 265);
            this.moviesPlayedInLbl.Name = "moviesPlayedInLbl";
            this.moviesPlayedInLbl.Size = new System.Drawing.Size(116, 13);
            this.moviesPlayedInLbl.TabIndex = 9;
            this.moviesPlayedInLbl.Text = "# of Movies Played In: ";
            // 
            // moviesPlayedValueLbl
            // 
            this.moviesPlayedValueLbl.AutoSize = true;
            this.moviesPlayedValueLbl.Location = new System.Drawing.Point(246, 265);
            this.moviesPlayedValueLbl.Name = "moviesPlayedValueLbl";
            this.moviesPlayedValueLbl.Size = new System.Drawing.Size(13, 13);
            this.moviesPlayedValueLbl.TabIndex = 10;
            this.moviesPlayedValueLbl.Text = "0";
            // 
            // ActorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 298);
            this.Controls.Add(this.moviesPlayedValueLbl);
            this.Controls.Add(this.moviesPlayedInLbl);
            this.Controls.Add(this.stageNameLbl);
            this.Controls.Add(this.birthdayLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.stageNameTxtBx);
            this.Controls.Add(this.birthdayTxtBx);
            this.Controls.Add(this.lastNameTxtBx);
            this.Controls.Add(this.firstNameTxtBx);
            this.Controls.Add(this.actorListBox);
            this.Name = "ActorsForm";
            this.Text = "ActorsForm";
            this.Load += new System.EventHandler(this.ActorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MoviesDataSet moviesDataSet1;
        private MoviesDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter1;
        private System.Windows.Forms.ListBox actorListBox;
        private System.Windows.Forms.TextBox firstNameTxtBx;
        private System.Windows.Forms.TextBox lastNameTxtBx;
        private System.Windows.Forms.TextBox birthdayTxtBx;
        private System.Windows.Forms.TextBox stageNameTxtBx;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.Label stageNameLbl;
        private MoviesDataSetTableAdapters.MovieActorsTableAdapter movieActorsTableAdapter1;
        private System.Windows.Forms.Label moviesPlayedInLbl;
        private System.Windows.Forms.Label moviesPlayedValueLbl;
    }
}