﻿namespace Movies
{
    partial class GenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreForm));
            System.Windows.Forms.Label genreIdLabel;
            System.Windows.Forms.Label genreLabel;
            this.moviesDataSet = new Movies.MoviesDataSet();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new Movies.MoviesDataSetTableAdapters.GenresTableAdapter();
            this.tableAdapterManager = new Movies.MoviesDataSetTableAdapters.TableAdapterManager();
            this.genresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.genresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.genreIdTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            genreIdLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).BeginInit();
            this.genresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.moviesDataSet;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = this.genresTableAdapter;
            this.tableAdapterManager.MovieActorsTableAdapter = null;
            this.tableAdapterManager.MovieGenresTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.RatingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Movies.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // genresBindingNavigator
            // 
            this.genresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.genresBindingNavigator.BindingSource = this.genresBindingSource;
            this.genresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.genresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.genresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.genresBindingNavigatorSaveItem});
            this.genresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.genresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.genresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.genresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.genresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.genresBindingNavigator.Name = "genresBindingNavigator";
            this.genresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.genresBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.genresBindingNavigator.TabIndex = 0;
            this.genresBindingNavigator.Text = "bindingNavigator1";
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
            // genresBindingNavigatorSaveItem
            // 
            this.genresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.genresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("genresBindingNavigatorSaveItem.Image")));
            this.genresBindingNavigatorSaveItem.Name = "genresBindingNavigatorSaveItem";
            this.genresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.genresBindingNavigatorSaveItem.Text = "Save Data";
            this.genresBindingNavigatorSaveItem.Click += new System.EventHandler(this.genresBindingNavigatorSaveItem_Click);
            // 
            // genreIdLabel
            // 
            genreIdLabel.AutoSize = true;
            genreIdLabel.Location = new System.Drawing.Point(12, 55);
            genreIdLabel.Name = "genreIdLabel";
            genreIdLabel.Size = new System.Drawing.Size(51, 13);
            genreIdLabel.TabIndex = 1;
            genreIdLabel.Text = "Genre Id:";
            // 
            // genreIdTextBox
            // 
            this.genreIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genresBindingSource, "GenreId", true));
            this.genreIdTextBox.Location = new System.Drawing.Point(69, 52);
            this.genreIdTextBox.Name = "genreIdTextBox";
            this.genreIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreIdTextBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 81);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genresBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(69, 78);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 4;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(genreIdLabel);
            this.Controls.Add(this.genreIdTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genresBindingNavigator);
            this.Name = "GenreForm";
            this.Text = "GenreForm";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).EndInit();
            this.genresBindingNavigator.ResumeLayout(false);
            this.genresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private MoviesDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private MoviesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator genresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton genresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox genreIdTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
    }
}