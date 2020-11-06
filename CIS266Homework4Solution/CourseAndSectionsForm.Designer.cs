namespace Homework4
{
    partial class CourseAndSectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAndSectionsForm));
            System.Windows.Forms.Label courseIdLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label courseNumberLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label creditsLabel;
            System.Windows.Forms.Label courseIdentifierLabel;
            this.registrationDataSet = new Homework4.RegistrationDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Homework4.RegistrationDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new Homework4.RegistrationDataSetTableAdapters.TableAdapterManager();
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.courseNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.courseIdentifierTextBox = new System.Windows.Forms.TextBox();
            courseIdLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            courseNumberLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            creditsLabel = new System.Windows.Forms.Label();
            courseIdentifierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.registrationDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.SectionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Homework4.RegistrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coursesBindingNavigatorSaveItem});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click);
            // 
            // courseIdLabel
            // 
            courseIdLabel.AutoSize = true;
            courseIdLabel.Location = new System.Drawing.Point(12, 46);
            courseIdLabel.Name = "courseIdLabel";
            courseIdLabel.Size = new System.Drawing.Size(55, 13);
            courseIdLabel.TabIndex = 1;
            courseIdLabel.Text = "Course Id:";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseId", true));
            this.courseIdTextBox.Location = new System.Drawing.Point(104, 43);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(60, 20);
            this.courseIdTextBox.TabIndex = 2;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(12, 72);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(104, 69);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(60, 20);
            this.departmentTextBox.TabIndex = 4;
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(12, 98);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(83, 13);
            courseNumberLabel.TabIndex = 5;
            courseNumberLabel.Text = "Course Number:";
            // 
            // courseNumberTextBox
            // 
            this.courseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseNumber", true));
            this.courseNumberTextBox.Location = new System.Drawing.Point(104, 95);
            this.courseNumberTextBox.Name = "courseNumberTextBox";
            this.courseNumberTextBox.Size = new System.Drawing.Size(60, 20);
            this.courseNumberTextBox.TabIndex = 6;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 124);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(104, 121);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(163, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // creditsLabel
            // 
            creditsLabel.AutoSize = true;
            creditsLabel.Location = new System.Drawing.Point(12, 150);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new System.Drawing.Size(42, 13);
            creditsLabel.TabIndex = 9;
            creditsLabel.Text = "Credits:";
            // 
            // creditsTextBox
            // 
            this.creditsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Credits", true));
            this.creditsTextBox.Location = new System.Drawing.Point(104, 147);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(42, 20);
            this.creditsTextBox.TabIndex = 10;
            // 
            // courseIdentifierLabel
            // 
            courseIdentifierLabel.AutoSize = true;
            courseIdentifierLabel.Location = new System.Drawing.Point(12, 176);
            courseIdentifierLabel.Name = "courseIdentifierLabel";
            courseIdentifierLabel.Size = new System.Drawing.Size(86, 13);
            courseIdentifierLabel.TabIndex = 11;
            courseIdentifierLabel.Text = "Course Identifier:";
            // 
            // courseIdentifierTextBox
            // 
            this.courseIdentifierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseIdentifier", true));
            this.courseIdentifierTextBox.Location = new System.Drawing.Point(104, 173);
            this.courseIdentifierTextBox.Name = "courseIdentifierTextBox";
            this.courseIdentifierTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIdentifierTextBox.TabIndex = 12;
            // 
            // CourseAndSectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(courseIdLabel);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(courseNumberLabel);
            this.Controls.Add(this.courseNumberTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(creditsLabel);
            this.Controls.Add(this.creditsTextBox);
            this.Controls.Add(courseIdentifierLabel);
            this.Controls.Add(this.courseIdentifierTextBox);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "CourseAndSectionsForm";
            this.Text = "CourseAndSectionsForm";
            this.Load += new System.EventHandler(this.CourseAndSectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegistrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private RegistrationDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private RegistrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coursesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox courseNumberTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox creditsTextBox;
        private System.Windows.Forms.TextBox courseIdentifierTextBox;
    }
}