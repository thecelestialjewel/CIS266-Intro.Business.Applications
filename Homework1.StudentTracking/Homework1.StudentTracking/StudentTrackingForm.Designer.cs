namespace Homework1.StudentTracking
{
    partial class StudentTrackingForm
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
            this.firstNameTxtbx = new System.Windows.Forms.TextBox();
            this.lastNameTxtbx = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.waResidentCheckBox = new System.Windows.Forms.CheckBox();
            this.majorCombobox = new System.Windows.Forms.ComboBox();
            this.applicationPicker = new System.Windows.Forms.DateTimePicker();
            this.requiredGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optionalGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.emailTxtbx = new System.Windows.Forms.TextBox();
            this.studentApplications = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.phoneTxtbx = new System.Windows.Forms.MaskedTextBox();
            this.requiredGroupBox.SuspendLayout();
            this.optionalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTxtbx
            // 
            this.firstNameTxtbx.Location = new System.Drawing.Point(180, 19);
            this.firstNameTxtbx.Name = "firstNameTxtbx";
            this.firstNameTxtbx.Size = new System.Drawing.Size(177, 20);
            this.firstNameTxtbx.TabIndex = 0;
            // 
            // lastNameTxtbx
            // 
            this.lastNameTxtbx.Location = new System.Drawing.Point(180, 72);
            this.lastNameTxtbx.Name = "lastNameTxtbx";
            this.lastNameTxtbx.Size = new System.Drawing.Size(177, 20);
            this.lastNameTxtbx.TabIndex = 1;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(180, 128);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(177, 20);
            this.idTxtBox.TabIndex = 2;
            // 
            // waResidentCheckBox
            // 
            this.waResidentCheckBox.AutoSize = true;
            this.waResidentCheckBox.Location = new System.Drawing.Point(101, 180);
            this.waResidentCheckBox.Name = "waResidentCheckBox";
            this.waResidentCheckBox.Size = new System.Drawing.Size(128, 17);
            this.waResidentCheckBox.TabIndex = 3;
            this.waResidentCheckBox.Text = "Washington Resident";
            this.waResidentCheckBox.UseVisualStyleBackColor = true;
            // 
            // majorCombobox
            // 
            this.majorCombobox.FormattingEnabled = true;
            this.majorCombobox.Items.AddRange(new object[] {
            "Computer Programming",
            "Database Management",
            "Other",
            "Undeclared"});
            this.majorCombobox.Location = new System.Drawing.Point(180, 222);
            this.majorCombobox.Name = "majorCombobox";
            this.majorCombobox.Size = new System.Drawing.Size(177, 21);
            this.majorCombobox.TabIndex = 4;
            // 
            // applicationPicker
            // 
            this.applicationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.applicationPicker.Location = new System.Drawing.Point(183, 282);
            this.applicationPicker.Name = "applicationPicker";
            this.applicationPicker.Size = new System.Drawing.Size(177, 20);
            this.applicationPicker.TabIndex = 5;
            // 
            // requiredGroupBox
            // 
            this.requiredGroupBox.Controls.Add(this.label6);
            this.requiredGroupBox.Controls.Add(this.label5);
            this.requiredGroupBox.Controls.Add(this.label3);
            this.requiredGroupBox.Controls.Add(this.label2);
            this.requiredGroupBox.Controls.Add(this.label1);
            this.requiredGroupBox.Controls.Add(this.firstNameTxtbx);
            this.requiredGroupBox.Controls.Add(this.lastNameTxtbx);
            this.requiredGroupBox.Controls.Add(this.idTxtBox);
            this.requiredGroupBox.Controls.Add(this.waResidentCheckBox);
            this.requiredGroupBox.Controls.Add(this.majorCombobox);
            this.requiredGroupBox.Controls.Add(this.applicationPicker);
            this.requiredGroupBox.Location = new System.Drawing.Point(15, 21);
            this.requiredGroupBox.Name = "requiredGroupBox";
            this.requiredGroupBox.Size = new System.Drawing.Size(365, 395);
            this.requiredGroupBox.TabIndex = 6;
            this.requiredGroupBox.TabStop = false;
            this.requiredGroupBox.Text = "Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Application Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Major:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // optionalGroupBox
            // 
            this.optionalGroupBox.Controls.Add(this.phoneTxtbx);
            this.optionalGroupBox.Controls.Add(this.label9);
            this.optionalGroupBox.Controls.Add(this.label8);
            this.optionalGroupBox.Controls.Add(this.label7);
            this.optionalGroupBox.Controls.Add(this.birthdayPicker);
            this.optionalGroupBox.Controls.Add(this.emailTxtbx);
            this.optionalGroupBox.Location = new System.Drawing.Point(397, 21);
            this.optionalGroupBox.Name = "optionalGroupBox";
            this.optionalGroupBox.Size = new System.Drawing.Size(324, 155);
            this.optionalGroupBox.TabIndex = 7;
            this.optionalGroupBox.TabStop = false;
            this.optionalGroupBox.Text = "Optional";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Birthday:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email Address";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "";
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(150, 87);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(130, 20);
            this.birthdayPicker.TabIndex = 2;
            // 
            // emailTxtbx
            // 
            this.emailTxtbx.Location = new System.Drawing.Point(150, 19);
            this.emailTxtbx.Name = "emailTxtbx";
            this.emailTxtbx.Size = new System.Drawing.Size(155, 20);
            this.emailTxtbx.TabIndex = 0;
            // 
            // studentApplications
            // 
            this.studentApplications.FormattingEnabled = true;
            this.studentApplications.Location = new System.Drawing.Point(397, 210);
            this.studentApplications.Name = "studentApplications";
            this.studentApplications.Size = new System.Drawing.Size(324, 160);
            this.studentApplications.TabIndex = 9;
            this.studentApplications.SelectedIndexChanged += new System.EventHandler(this.studentApplications_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(71, 445);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(245, 445);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(417, 445);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(585, 445);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // phoneTxtbx
            // 
            this.phoneTxtbx.Location = new System.Drawing.Point(150, 57);
            this.phoneTxtbx.Mask = "(999) 000-0000";
            this.phoneTxtbx.Name = "phoneTxtbx";
            this.phoneTxtbx.Size = new System.Drawing.Size(155, 20);
            this.phoneTxtbx.TabIndex = 15;
            this.phoneTxtbx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // StudentTrackingForm
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(731, 480);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.studentApplications);
            this.Controls.Add(this.optionalGroupBox);
            this.Controls.Add(this.requiredGroupBox);
            this.Name = "StudentTrackingForm";
            this.Text = "Student Tracking";
            this.requiredGroupBox.ResumeLayout(false);
            this.requiredGroupBox.PerformLayout();
            this.optionalGroupBox.ResumeLayout(false);
            this.optionalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxtbx;
        private System.Windows.Forms.TextBox lastNameTxtbx;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.CheckBox waResidentCheckBox;
        private System.Windows.Forms.ComboBox majorCombobox;
        private System.Windows.Forms.DateTimePicker applicationPicker;
        private System.Windows.Forms.GroupBox requiredGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox optionalGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.TextBox emailTxtbx;
        private System.Windows.Forms.ListBox studentApplications;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.MaskedTextBox phoneTxtbx;
    }
}

