namespace StudentRegistration
{
    partial class SectionForm
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
            System.Windows.Forms.Label sec_autSectionIDLabel;
            System.Windows.Forms.Label sec_txtQuarterLabel;
            System.Windows.Forms.Label sec_txtItemLabel;
            System.Windows.Forms.Label sec_lngCourseLabel;
            System.Windows.Forms.Label sec_txtDaysLabel;
            System.Windows.Forms.Label sec_dtmStartLabel;
            System.Windows.Forms.Label sec_dtmEndLabel;
            System.Windows.Forms.Label sec_txtRoomLabel;
            System.Windows.Forms.Label sec_txtInstructorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.registrationDataSet = new StudentRegistration.RegistrationDataSet();
            this.tblSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSectionsTableAdapter = new StudentRegistration.RegistrationDataSetTableAdapters.tblSectionsTableAdapter();
            this.tableAdapterManager = new StudentRegistration.RegistrationDataSetTableAdapters.TableAdapterManager();
            this.tblCoursesTableAdapter = new StudentRegistration.RegistrationDataSetTableAdapters.tblCoursesTableAdapter();
            this.tblSectionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblSectionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sec_autSectionIDTextBox = new System.Windows.Forms.TextBox();
            this.sec_txtQuarterTextBox = new System.Windows.Forms.TextBox();
            this.sec_txtItemTextBox = new System.Windows.Forms.TextBox();
            this.sec_lngCourseTextBox = new System.Windows.Forms.TextBox();
            this.sec_txtDaysTextBox = new System.Windows.Forms.TextBox();
            this.sec_dtmStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sec_dtmEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sec_txtRoomTextBox = new System.Windows.Forms.TextBox();
            this.sec_txtInstructorTextBox = new System.Windows.Forms.TextBox();
            this.tblCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sec_autSectionIDLabel = new System.Windows.Forms.Label();
            sec_txtQuarterLabel = new System.Windows.Forms.Label();
            sec_txtItemLabel = new System.Windows.Forms.Label();
            sec_lngCourseLabel = new System.Windows.Forms.Label();
            sec_txtDaysLabel = new System.Windows.Forms.Label();
            sec_dtmStartLabel = new System.Windows.Forms.Label();
            sec_dtmEndLabel = new System.Windows.Forms.Label();
            sec_txtRoomLabel = new System.Windows.Forms.Label();
            sec_txtInstructorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSectionsBindingNavigator)).BeginInit();
            this.tblSectionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sec_autSectionIDLabel
            // 
            sec_autSectionIDLabel.AutoSize = true;
            sec_autSectionIDLabel.Location = new System.Drawing.Point(23, 42);
            sec_autSectionIDLabel.Name = "sec_autSectionIDLabel";
            sec_autSectionIDLabel.Size = new System.Drawing.Size(60, 13);
            sec_autSectionIDLabel.TabIndex = 1;
            sec_autSectionIDLabel.Text = "Section ID:";
            // 
            // sec_txtQuarterLabel
            // 
            sec_txtQuarterLabel.AutoSize = true;
            sec_txtQuarterLabel.Location = new System.Drawing.Point(23, 68);
            sec_txtQuarterLabel.Name = "sec_txtQuarterLabel";
            sec_txtQuarterLabel.Size = new System.Drawing.Size(45, 13);
            sec_txtQuarterLabel.TabIndex = 3;
            sec_txtQuarterLabel.Text = "Quarter:";
            // 
            // sec_txtItemLabel
            // 
            sec_txtItemLabel.AutoSize = true;
            sec_txtItemLabel.Location = new System.Drawing.Point(23, 94);
            sec_txtItemLabel.Name = "sec_txtItemLabel";
            sec_txtItemLabel.Size = new System.Drawing.Size(30, 13);
            sec_txtItemLabel.TabIndex = 5;
            sec_txtItemLabel.Text = "Item:";
            // 
            // sec_lngCourseLabel
            // 
            sec_lngCourseLabel.AutoSize = true;
            sec_lngCourseLabel.Location = new System.Drawing.Point(23, 120);
            sec_lngCourseLabel.Name = "sec_lngCourseLabel";
            sec_lngCourseLabel.Size = new System.Drawing.Size(57, 13);
            sec_lngCourseLabel.TabIndex = 7;
            sec_lngCourseLabel.Text = "Course ID:";
            // 
            // sec_txtDaysLabel
            // 
            sec_txtDaysLabel.AutoSize = true;
            sec_txtDaysLabel.Location = new System.Drawing.Point(23, 146);
            sec_txtDaysLabel.Name = "sec_txtDaysLabel";
            sec_txtDaysLabel.Size = new System.Drawing.Size(34, 13);
            sec_txtDaysLabel.TabIndex = 9;
            sec_txtDaysLabel.Text = "Days:";
            // 
            // sec_dtmStartLabel
            // 
            sec_dtmStartLabel.AutoSize = true;
            sec_dtmStartLabel.Location = new System.Drawing.Point(23, 173);
            sec_dtmStartLabel.Name = "sec_dtmStartLabel";
            sec_dtmStartLabel.Size = new System.Drawing.Size(58, 13);
            sec_dtmStartLabel.TabIndex = 11;
            sec_dtmStartLabel.Text = "Start Date:";
            // 
            // sec_dtmEndLabel
            // 
            sec_dtmEndLabel.AutoSize = true;
            sec_dtmEndLabel.Location = new System.Drawing.Point(23, 199);
            sec_dtmEndLabel.Name = "sec_dtmEndLabel";
            sec_dtmEndLabel.Size = new System.Drawing.Size(55, 13);
            sec_dtmEndLabel.TabIndex = 13;
            sec_dtmEndLabel.Text = "End Date:";
            // 
            // sec_txtRoomLabel
            // 
            sec_txtRoomLabel.AutoSize = true;
            sec_txtRoomLabel.Location = new System.Drawing.Point(23, 224);
            sec_txtRoomLabel.Name = "sec_txtRoomLabel";
            sec_txtRoomLabel.Size = new System.Drawing.Size(38, 13);
            sec_txtRoomLabel.TabIndex = 15;
            sec_txtRoomLabel.Text = "Room:";
            // 
            // sec_txtInstructorLabel
            // 
            sec_txtInstructorLabel.AutoSize = true;
            sec_txtInstructorLabel.Location = new System.Drawing.Point(23, 250);
            sec_txtInstructorLabel.Name = "sec_txtInstructorLabel";
            sec_txtInstructorLabel.Size = new System.Drawing.Size(54, 13);
            sec_txtInstructorLabel.TabIndex = 17;
            sec_txtInstructorLabel.Text = "Instructor:";
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSectionsBindingSource
            // 
            this.tblSectionsBindingSource.DataMember = "tblSections";
            this.tblSectionsBindingSource.DataSource = this.registrationDataSet;
            // 
            // tblSectionsTableAdapter
            // 
            this.tblSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCoursesTableAdapter = this.tblCoursesTableAdapter;
            this.tableAdapterManager.tblEnrollmentTableAdapter = null;
            this.tableAdapterManager.tblSectionsTableAdapter = this.tblSectionsTableAdapter;
            this.tableAdapterManager.tblStudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentRegistration.RegistrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCoursesTableAdapter
            // 
            this.tblCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // tblSectionsBindingNavigator
            // 
            this.tblSectionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblSectionsBindingNavigator.BindingSource = this.tblSectionsBindingSource;
            this.tblSectionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblSectionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblSectionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblSectionsBindingNavigatorSaveItem});
            this.tblSectionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblSectionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblSectionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblSectionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblSectionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblSectionsBindingNavigator.Name = "tblSectionsBindingNavigator";
            this.tblSectionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblSectionsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblSectionsBindingNavigator.TabIndex = 0;
            this.tblSectionsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblSectionsBindingNavigatorSaveItem
            // 
            this.tblSectionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblSectionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblSectionsBindingNavigatorSaveItem.Image")));
            this.tblSectionsBindingNavigatorSaveItem.Name = "tblSectionsBindingNavigatorSaveItem";
            this.tblSectionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblSectionsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblSectionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblSectionsBindingNavigatorSaveItem_Click);
            // 
            // sec_autSectionIDTextBox
            // 
            this.sec_autSectionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_autSectionID", true));
            this.sec_autSectionIDTextBox.Location = new System.Drawing.Point(127, 39);
            this.sec_autSectionIDTextBox.Name = "sec_autSectionIDTextBox";
            this.sec_autSectionIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_autSectionIDTextBox.TabIndex = 2;
            // 
            // sec_txtQuarterTextBox
            // 
            this.sec_txtQuarterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_txtQuarter", true));
            this.sec_txtQuarterTextBox.Location = new System.Drawing.Point(127, 65);
            this.sec_txtQuarterTextBox.Name = "sec_txtQuarterTextBox";
            this.sec_txtQuarterTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_txtQuarterTextBox.TabIndex = 4;
            // 
            // sec_txtItemTextBox
            // 
            this.sec_txtItemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_txtItem", true));
            this.sec_txtItemTextBox.Location = new System.Drawing.Point(127, 91);
            this.sec_txtItemTextBox.Name = "sec_txtItemTextBox";
            this.sec_txtItemTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_txtItemTextBox.TabIndex = 6;
            // 
            // sec_lngCourseTextBox
            // 
            this.sec_lngCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_lngCourse", true));
            this.sec_lngCourseTextBox.Location = new System.Drawing.Point(127, 117);
            this.sec_lngCourseTextBox.Name = "sec_lngCourseTextBox";
            this.sec_lngCourseTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_lngCourseTextBox.TabIndex = 8;
            // 
            // sec_txtDaysTextBox
            // 
            this.sec_txtDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_txtDays", true));
            this.sec_txtDaysTextBox.Location = new System.Drawing.Point(127, 143);
            this.sec_txtDaysTextBox.Name = "sec_txtDaysTextBox";
            this.sec_txtDaysTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_txtDaysTextBox.TabIndex = 10;
            // 
            // sec_dtmStartDateTimePicker
            // 
            this.sec_dtmStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSectionsBindingSource, "sec_dtmStart", true));
            this.sec_dtmStartDateTimePicker.Location = new System.Drawing.Point(127, 169);
            this.sec_dtmStartDateTimePicker.Name = "sec_dtmStartDateTimePicker";
            this.sec_dtmStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sec_dtmStartDateTimePicker.TabIndex = 12;
            // 
            // sec_dtmEndDateTimePicker
            // 
            this.sec_dtmEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSectionsBindingSource, "sec_dtmEnd", true));
            this.sec_dtmEndDateTimePicker.Location = new System.Drawing.Point(127, 195);
            this.sec_dtmEndDateTimePicker.Name = "sec_dtmEndDateTimePicker";
            this.sec_dtmEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sec_dtmEndDateTimePicker.TabIndex = 14;
            // 
            // sec_txtRoomTextBox
            // 
            this.sec_txtRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_txtRoom", true));
            this.sec_txtRoomTextBox.Location = new System.Drawing.Point(127, 221);
            this.sec_txtRoomTextBox.Name = "sec_txtRoomTextBox";
            this.sec_txtRoomTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_txtRoomTextBox.TabIndex = 16;
            // 
            // sec_txtInstructorTextBox
            // 
            this.sec_txtInstructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSectionsBindingSource, "sec_txtInstructor", true));
            this.sec_txtInstructorTextBox.Location = new System.Drawing.Point(127, 247);
            this.sec_txtInstructorTextBox.Name = "sec_txtInstructorTextBox";
            this.sec_txtInstructorTextBox.Size = new System.Drawing.Size(200, 20);
            this.sec_txtInstructorTextBox.TabIndex = 18;
            // 
            // tblCoursesBindingSource
            // 
            this.tblCoursesBindingSource.DataMember = "tblCourses";
            this.tblCoursesBindingSource.DataSource = this.registrationDataSet;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(sec_autSectionIDLabel);
            this.Controls.Add(this.sec_autSectionIDTextBox);
            this.Controls.Add(sec_txtQuarterLabel);
            this.Controls.Add(this.sec_txtQuarterTextBox);
            this.Controls.Add(sec_txtItemLabel);
            this.Controls.Add(this.sec_txtItemTextBox);
            this.Controls.Add(sec_lngCourseLabel);
            this.Controls.Add(this.sec_lngCourseTextBox);
            this.Controls.Add(sec_txtDaysLabel);
            this.Controls.Add(this.sec_txtDaysTextBox);
            this.Controls.Add(sec_dtmStartLabel);
            this.Controls.Add(this.sec_dtmStartDateTimePicker);
            this.Controls.Add(sec_dtmEndLabel);
            this.Controls.Add(this.sec_dtmEndDateTimePicker);
            this.Controls.Add(sec_txtRoomLabel);
            this.Controls.Add(this.sec_txtRoomTextBox);
            this.Controls.Add(sec_txtInstructorLabel);
            this.Controls.Add(this.sec_txtInstructorTextBox);
            this.Controls.Add(this.tblSectionsBindingNavigator);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.Load += new System.EventHandler(this.SectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSectionsBindingNavigator)).EndInit();
            this.tblSectionsBindingNavigator.ResumeLayout(false);
            this.tblSectionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegistrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource tblSectionsBindingSource;
        private RegistrationDataSetTableAdapters.tblSectionsTableAdapter tblSectionsTableAdapter;
        private RegistrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblSectionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblSectionsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sec_autSectionIDTextBox;
        private System.Windows.Forms.TextBox sec_txtQuarterTextBox;
        private System.Windows.Forms.TextBox sec_txtItemTextBox;
        private System.Windows.Forms.TextBox sec_lngCourseTextBox;
        private System.Windows.Forms.TextBox sec_txtDaysTextBox;
        private System.Windows.Forms.DateTimePicker sec_dtmStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker sec_dtmEndDateTimePicker;
        private System.Windows.Forms.TextBox sec_txtRoomTextBox;
        private System.Windows.Forms.TextBox sec_txtInstructorTextBox;
        private RegistrationDataSetTableAdapters.tblCoursesTableAdapter tblCoursesTableAdapter;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource;
    }
}