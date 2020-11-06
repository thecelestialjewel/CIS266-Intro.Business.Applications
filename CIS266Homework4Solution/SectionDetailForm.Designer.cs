namespace Homework4
{
    partial class SectionDetailForm
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
            System.Windows.Forms.Label sectionIdLabel;
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label schoolQuarterLabel;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label instructorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionDetailForm));
            this.registrationDataSet = new Homework4.RegistrationDataSet();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter = new Homework4.RegistrationDataSetTableAdapters.SectionsTableAdapter();
            this.tableAdapterManager = new Homework4.RegistrationDataSetTableAdapters.TableAdapterManager();
            this.sectionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sectionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sectionIdLabel1 = new System.Windows.Forms.Label();
            this.courseIDComboBox = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolQuarterTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            sectionIdLabel = new System.Windows.Forms.Label();
            courseIDLabel = new System.Windows.Forms.Label();
            schoolQuarterLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            instructorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingNavigator)).BeginInit();
            this.sectionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionIdLabel
            // 
            sectionIdLabel.AutoSize = true;
            sectionIdLabel.Location = new System.Drawing.Point(16, 51);
            sectionIdLabel.Name = "sectionIdLabel";
            sectionIdLabel.Size = new System.Drawing.Size(74, 17);
            sectionIdLabel.TabIndex = 1;
            sectionIdLabel.Text = "Section Id:";
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(16, 80);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(74, 17);
            courseIDLabel.TabIndex = 3;
            courseIDLabel.Text = "Course ID:";
            // 
            // schoolQuarterLabel
            // 
            schoolQuarterLabel.AutoSize = true;
            schoolQuarterLabel.Location = new System.Drawing.Point(16, 111);
            schoolQuarterLabel.Name = "schoolQuarterLabel";
            schoolQuarterLabel.Size = new System.Drawing.Size(108, 17);
            schoolQuarterLabel.TabIndex = 5;
            schoolQuarterLabel.Text = "School Quarter:";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(16, 139);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(38, 17);
            itemLabel.TabIndex = 7;
            itemLabel.Text = "Item:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(16, 167);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(77, 17);
            startTimeLabel.TabIndex = 9;
            startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(16, 195);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(72, 17);
            endTimeLabel.TabIndex = 11;
            endTimeLabel.Text = "End Time:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Location = new System.Drawing.Point(16, 223);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(103, 17);
            roomNumberLabel.TabIndex = 13;
            roomNumberLabel.Text = "Room Number:";
            // 
            // instructorLabel
            // 
            instructorLabel.AutoSize = true;
            instructorLabel.Location = new System.Drawing.Point(16, 251);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new System.Drawing.Size(71, 17);
            instructorLabel.TabIndex = 15;
            instructorLabel.Text = "Instructor:";
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.registrationDataSet;
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.SectionsTableAdapter = this.sectionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Homework4.RegistrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sectionsBindingNavigator
            // 
            this.sectionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sectionsBindingNavigator.BindingSource = this.sectionsBindingSource;
            this.sectionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sectionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sectionsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sectionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sectionsBindingNavigatorSaveItem});
            this.sectionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sectionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sectionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sectionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sectionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sectionsBindingNavigator.Name = "sectionsBindingNavigator";
            this.sectionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sectionsBindingNavigator.Size = new System.Drawing.Size(345, 27);
            this.sectionsBindingNavigator.TabIndex = 0;
            this.sectionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sectionsBindingNavigatorSaveItem
            // 
            this.sectionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionsBindingNavigatorSaveItem.Image")));
            this.sectionsBindingNavigatorSaveItem.Name = "sectionsBindingNavigatorSaveItem";
            this.sectionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sectionsBindingNavigatorSaveItem.Text = "Save Data";
            this.sectionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.sectionsBindingNavigatorSaveItem_Click);
            // 
            // sectionIdLabel1
            // 
            this.sectionIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "SectionId", true));
            this.sectionIdLabel1.Location = new System.Drawing.Point(130, 51);
            this.sectionIdLabel1.Name = "sectionIdLabel1";
            this.sectionIdLabel1.Size = new System.Drawing.Size(121, 23);
            this.sectionIdLabel1.TabIndex = 2;
            this.sectionIdLabel1.Text = "label1";
            // 
            // courseIDComboBox
            // 
            this.courseIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionsBindingSource, "CourseID", true));
            this.courseIDComboBox.DataSource = this.coursesBindingSource;
            this.courseIDComboBox.DisplayMember = "CourseIdentifier";
            this.courseIDComboBox.FormattingEnabled = true;
            this.courseIDComboBox.Location = new System.Drawing.Point(130, 77);
            this.courseIDComboBox.Name = "courseIDComboBox";
            this.courseIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseIDComboBox.TabIndex = 4;
            this.courseIDComboBox.ValueMember = "CourseId";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.registrationDataSet;
            // 
            // schoolQuarterTextBox
            // 
            this.schoolQuarterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "SchoolQuarter", true));
            this.schoolQuarterTextBox.Location = new System.Drawing.Point(130, 108);
            this.schoolQuarterTextBox.Name = "schoolQuarterTextBox";
            this.schoolQuarterTextBox.Size = new System.Drawing.Size(121, 22);
            this.schoolQuarterTextBox.TabIndex = 6;
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "Item", true));
            this.itemTextBox.Location = new System.Drawing.Point(130, 136);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(57, 22);
            this.itemTextBox.TabIndex = 8;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(130, 164);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(81, 22);
            this.startTimeTextBox.TabIndex = 10;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(130, 192);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(81, 22);
            this.endTimeTextBox.TabIndex = 12;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "RoomNumber", true));
            this.roomNumberTextBox.Location = new System.Drawing.Point(130, 220);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(68, 22);
            this.roomNumberTextBox.TabIndex = 14;
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "Instructor", true));
            this.instructorTextBox.Location = new System.Drawing.Point(130, 248);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(121, 22);
            this.instructorTextBox.TabIndex = 16;
            // 
            // SectionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 300);
            this.Controls.Add(sectionIdLabel);
            this.Controls.Add(this.sectionIdLabel1);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDComboBox);
            this.Controls.Add(schoolQuarterLabel);
            this.Controls.Add(this.schoolQuarterTextBox);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(roomNumberLabel);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(instructorLabel);
            this.Controls.Add(this.instructorTextBox);
            this.Controls.Add(this.sectionsBindingNavigator);
            this.Name = "SectionDetailForm";
            this.Text = "Section Detail";
            this.Load += new System.EventHandler(this.SectionDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingNavigator)).EndInit();
            this.sectionsBindingNavigator.ResumeLayout(false);
            this.sectionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegistrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private RegistrationDataSetTableAdapters.SectionsTableAdapter sectionsTableAdapter;
        private RegistrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sectionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sectionsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label sectionIdLabel1;
        private System.Windows.Forms.ComboBox courseIDComboBox;
        private System.Windows.Forms.TextBox schoolQuarterTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.BindingSource coursesBindingSource;
    }
}