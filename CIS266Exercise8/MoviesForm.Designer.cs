namespace Movies
{
    partial class MoviesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            System.Windows.Forms.Label movieIdLabel;
            System.Windows.Forms.Label movieTitleLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label ratingIDLabel;
            System.Windows.Forms.Label budgetLabel;
            this.moviesDataSet = new Movies.MoviesDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Movies.MoviesDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new Movies.MoviesDataSetTableAdapters.TableAdapterManager();
            this.moviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.moviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ratingIDTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            movieIdLabel = new System.Windows.Forms.Label();
            movieTitleLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ratingIDLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).BeginInit();
            this.moviesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.MovieActorsTableAdapter = null;
            this.tableAdapterManager.MovieGenresTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.RatingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Movies.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesBindingNavigator
            // 
            this.moviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moviesBindingNavigator.BindingSource = this.moviesBindingSource;
            this.moviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.moviesBindingNavigatorSaveItem});
            this.moviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moviesBindingNavigator.Name = "moviesBindingNavigator";
            this.moviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moviesBindingNavigator.Size = new System.Drawing.Size(510, 25);
            this.moviesBindingNavigator.TabIndex = 0;
            this.moviesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // moviesBindingNavigatorSaveItem
            // 
            this.moviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesBindingNavigatorSaveItem.Image")));
            this.moviesBindingNavigatorSaveItem.Name = "moviesBindingNavigatorSaveItem";
            this.moviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.moviesBindingNavigatorSaveItem.Text = "Save Data";
            this.moviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.moviesBindingNavigatorSaveItem_Click);
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Location = new System.Drawing.Point(15, 43);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new System.Drawing.Size(51, 13);
            movieIdLabel.TabIndex = 1;
            movieIdLabel.Text = "Movie Id:";
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "MovieId", true));
            this.movieIdTextBox.Location = new System.Drawing.Point(96, 40);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.ReadOnly = true;
            this.movieIdTextBox.Size = new System.Drawing.Size(62, 20);
            this.movieIdTextBox.TabIndex = 2;
            // 
            // movieTitleLabel
            // 
            movieTitleLabel.AutoSize = true;
            movieTitleLabel.Location = new System.Drawing.Point(15, 69);
            movieTitleLabel.Name = "movieTitleLabel";
            movieTitleLabel.Size = new System.Drawing.Size(62, 13);
            movieTitleLabel.TabIndex = 3;
            movieTitleLabel.Text = "Movie Title:";
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "MovieTitle", true));
            this.movieTitleTextBox.Location = new System.Drawing.Point(96, 66);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(390, 20);
            this.movieTitleTextBox.TabIndex = 4;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(15, 96);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 5;
            releaseDateLabel.Text = "Release Date:";
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.moviesBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(96, 92);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.releaseDateDateTimePicker.TabIndex = 6;
            // 
            // ratingIDLabel
            // 
            ratingIDLabel.AutoSize = true;
            ratingIDLabel.Location = new System.Drawing.Point(15, 121);
            ratingIDLabel.Name = "ratingIDLabel";
            ratingIDLabel.Size = new System.Drawing.Size(55, 13);
            ratingIDLabel.TabIndex = 7;
            ratingIDLabel.Text = "Rating ID:";
            // 
            // ratingIDTextBox
            // 
            this.ratingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "RatingID", true));
            this.ratingIDTextBox.Location = new System.Drawing.Point(96, 118);
            this.ratingIDTextBox.Name = "ratingIDTextBox";
            this.ratingIDTextBox.Size = new System.Drawing.Size(135, 20);
            this.ratingIDTextBox.TabIndex = 8;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(270, 96);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(44, 13);
            budgetLabel.TabIndex = 9;
            budgetLabel.Text = "Budget:";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Budget", true));
            this.budgetTextBox.Location = new System.Drawing.Point(351, 93);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(135, 20);
            this.budgetTextBox.TabIndex = 10;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 155);
            this.Controls.Add(movieIdLabel);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(movieTitleLabel);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(ratingIDLabel);
            this.Controls.Add(this.ratingIDTextBox);
            this.Controls.Add(budgetLabel);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.moviesBindingNavigator);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).EndInit();
            this.moviesBindingNavigator.ResumeLayout(false);
            this.moviesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private MoviesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moviesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton moviesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox ratingIDTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
    }
}