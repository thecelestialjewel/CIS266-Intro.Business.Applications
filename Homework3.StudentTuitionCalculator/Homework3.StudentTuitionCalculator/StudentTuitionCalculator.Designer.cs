namespace Homework3.StudentTuitionCalculator
{
    partial class StudentTuitionCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tuitionListBox = new System.Windows.Forms.ListBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.creditAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.residentRadioBtn = new System.Windows.Forms.RadioButton();
            this.nonResUsCitizenRadioBtn = new System.Windows.Forms.RadioButton();
            this.nonResNonUsCitizenRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tuitionLabel = new System.Windows.Forms.Label();
            this.tuitionAmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentIDTxtbx = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tuitionListBox
            // 
            this.tuitionListBox.FormattingEnabled = true;
            this.tuitionListBox.ItemHeight = 15;
            this.tuitionListBox.Location = new System.Drawing.Point(40, 142);
            this.tuitionListBox.Name = "tuitionListBox";
            this.tuitionListBox.Size = new System.Drawing.Size(336, 139);
            this.tuitionListBox.TabIndex = 0;
            this.tuitionListBox.SelectedIndexChanged += new System.EventHandler(this.tuitionListBox_SelectedIndexChanged);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 371);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(92, 23);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(128, 371);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(338, 371);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit Amount:";
            // 
            // creditAmountNumericUpDown
            // 
            this.creditAmountNumericUpDown.Location = new System.Drawing.Point(40, 95);
            this.creditAmountNumericUpDown.Name = "creditAmountNumericUpDown";
            this.creditAmountNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.creditAmountNumericUpDown.TabIndex = 5;
            // 
            // residentRadioBtn
            // 
            this.residentRadioBtn.AutoSize = true;
            this.residentRadioBtn.Checked = true;
            this.residentRadioBtn.Location = new System.Drawing.Point(228, 49);
            this.residentRadioBtn.Name = "residentRadioBtn";
            this.residentRadioBtn.Size = new System.Drawing.Size(70, 19);
            this.residentRadioBtn.TabIndex = 6;
            this.residentRadioBtn.TabStop = true;
            this.residentRadioBtn.Text = "Resident";
            this.residentRadioBtn.UseVisualStyleBackColor = true;
            this.residentRadioBtn.CheckedChanged += new System.EventHandler(this.residentRadioBtn_CheckedChanged);
            // 
            // nonResUsCitizenRadioBtn
            // 
            this.nonResUsCitizenRadioBtn.AutoSize = true;
            this.nonResUsCitizenRadioBtn.Location = new System.Drawing.Point(228, 74);
            this.nonResUsCitizenRadioBtn.Name = "nonResUsCitizenRadioBtn";
            this.nonResUsCitizenRadioBtn.Size = new System.Drawing.Size(162, 19);
            this.nonResUsCitizenRadioBtn.TabIndex = 7;
            this.nonResUsCitizenRadioBtn.Text = "Non-Resident (US Citizen)";
            this.nonResUsCitizenRadioBtn.UseVisualStyleBackColor = true;
            this.nonResUsCitizenRadioBtn.CheckedChanged += new System.EventHandler(this.nonResUsCitizenRadioBtn_CheckedChanged);
            // 
            // nonResNonUsCitizenRadioBtn
            // 
            this.nonResNonUsCitizenRadioBtn.AutoSize = true;
            this.nonResNonUsCitizenRadioBtn.Location = new System.Drawing.Point(228, 99);
            this.nonResNonUsCitizenRadioBtn.Name = "nonResNonUsCitizenRadioBtn";
            this.nonResNonUsCitizenRadioBtn.Size = new System.Drawing.Size(189, 19);
            this.nonResNonUsCitizenRadioBtn.TabIndex = 8;
            this.nonResNonUsCitizenRadioBtn.Text = "Non-Resident (Non-Us Citizen)";
            this.nonResNonUsCitizenRadioBtn.UseVisualStyleBackColor = true;
            this.nonResNonUsCitizenRadioBtn.CheckedChanged += new System.EventHandler(this.nonResNonUsCitizenRadioBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resident Status:";
            // 
            // tuitionLabel
            // 
            this.tuitionLabel.AutoSize = true;
            this.tuitionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tuitionLabel.Location = new System.Drawing.Point(97, 327);
            this.tuitionLabel.Name = "tuitionLabel";
            this.tuitionLabel.Size = new System.Drawing.Size(95, 15);
            this.tuitionLabel.TabIndex = 10;
            this.tuitionLabel.Text = "Tuition Charges:";
            // 
            // tuitionAmountLabel
            // 
            this.tuitionAmountLabel.AutoSize = true;
            this.tuitionAmountLabel.Location = new System.Drawing.Point(198, 327);
            this.tuitionAmountLabel.Name = "tuitionAmountLabel";
            this.tuitionAmountLabel.Size = new System.Drawing.Size(34, 15);
            this.tuitionAmountLabel.TabIndex = 11;
            this.tuitionAmountLabel.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student ID:";
            // 
            // studentIDTxtbx
            // 
            this.studentIDTxtbx.Location = new System.Drawing.Point(40, 40);
            this.studentIDTxtbx.Name = "studentIDTxtbx";
            this.studentIDTxtbx.Size = new System.Drawing.Size(100, 23);
            this.studentIDTxtbx.TabIndex = 13;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(237, 371);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // StudentTuitionCalculator
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(425, 413);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.studentIDTxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tuitionAmountLabel);
            this.Controls.Add(this.tuitionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nonResNonUsCitizenRadioBtn);
            this.Controls.Add(this.nonResUsCitizenRadioBtn);
            this.Controls.Add(this.residentRadioBtn);
            this.Controls.Add(this.creditAmountNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.tuitionListBox);
            this.Name = "StudentTuitionCalculator";
            this.Text = "Student Tuition Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tuitionListBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown creditAmountNumericUpDown;
        private System.Windows.Forms.RadioButton residentRadioBtn;
        private System.Windows.Forms.RadioButton nonResUsCitizenRadioBtn;
        private System.Windows.Forms.RadioButton nonResNonUsCitizenRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tuitionLabel;
        private System.Windows.Forms.Label tuitionAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentIDTxtbx;
        private System.Windows.Forms.Button deleteBtn;
    }
}

