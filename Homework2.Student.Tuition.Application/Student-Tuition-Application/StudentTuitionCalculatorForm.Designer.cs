namespace Student_Tuition_Application
{
    partial class StudentTuitionCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTuitionCalculatorForm));
            this.creditAmountLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.residentRadioBtn = new System.Windows.Forms.RadioButton();
            this.nonResUSCitRadioBtn = new System.Windows.Forms.RadioButton();
            this.NonResNonUSRadioBtn = new System.Windows.Forms.RadioButton();
            this.tuitionLabel = new System.Windows.Forms.Label();
            this.tuitionAmountLabel = new System.Windows.Forms.Label();
            this.creditsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // creditAmountLabel
            // 
            this.creditAmountLabel.AutoSize = true;
            this.creditAmountLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountLabel.Location = new System.Drawing.Point(20, 22);
            this.creditAmountLabel.Name = "creditAmountLabel";
            this.creditAmountLabel.Size = new System.Drawing.Size(83, 16);
            this.creditAmountLabel.TabIndex = 1;
            this.creditAmountLabel.Text = "Credit Amount:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(23, 234);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(119, 234);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(211, 234);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resident:";
            // 
            // residentRadioBtn
            // 
            this.residentRadioBtn.AutoSize = true;
            this.residentRadioBtn.Checked = true;
            this.residentRadioBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residentRadioBtn.Location = new System.Drawing.Point(23, 103);
            this.residentRadioBtn.Name = "residentRadioBtn";
            this.residentRadioBtn.Size = new System.Drawing.Size(69, 20);
            this.residentRadioBtn.TabIndex = 6;
            this.residentRadioBtn.TabStop = true;
            this.residentRadioBtn.Text = "Resident";
            this.residentRadioBtn.UseVisualStyleBackColor = true;
            this.residentRadioBtn.CheckedChanged += new System.EventHandler(this.residentRadioBtn_CheckedChanged);
            // 
            // nonResUSCitRadioBtn
            // 
            this.nonResUSCitRadioBtn.AutoSize = true;
            this.nonResUSCitRadioBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonResUSCitRadioBtn.Location = new System.Drawing.Point(23, 126);
            this.nonResUSCitRadioBtn.Name = "nonResUSCitRadioBtn";
            this.nonResUSCitRadioBtn.Size = new System.Drawing.Size(154, 20);
            this.nonResUSCitRadioBtn.TabIndex = 7;
            this.nonResUSCitRadioBtn.TabStop = true;
            this.nonResUSCitRadioBtn.Text = "Non-Resident (US Citizen)";
            this.nonResUSCitRadioBtn.UseVisualStyleBackColor = true;
            this.nonResUSCitRadioBtn.CheckedChanged += new System.EventHandler(this.nonResUSCitRadioBtn_CheckedChanged);
            // 
            // NonResNonUSRadioBtn
            // 
            this.NonResNonUSRadioBtn.AutoSize = true;
            this.NonResNonUSRadioBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonResNonUSRadioBtn.Location = new System.Drawing.Point(23, 149);
            this.NonResNonUSRadioBtn.Name = "NonResNonUSRadioBtn";
            this.NonResNonUSRadioBtn.Size = new System.Drawing.Size(177, 20);
            this.NonResNonUSRadioBtn.TabIndex = 8;
            this.NonResNonUSRadioBtn.TabStop = true;
            this.NonResNonUSRadioBtn.Text = "Non-Resident (Non-US Citizen)";
            this.NonResNonUSRadioBtn.UseVisualStyleBackColor = true;
            this.NonResNonUSRadioBtn.CheckedChanged += new System.EventHandler(this.NonResNonUSRadioBtn_CheckedChanged);
            // 
            // tuitionLabel
            // 
            this.tuitionLabel.AutoSize = true;
            this.tuitionLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionLabel.Location = new System.Drawing.Point(20, 194);
            this.tuitionLabel.Name = "tuitionLabel";
            this.tuitionLabel.Size = new System.Drawing.Size(109, 18);
            this.tuitionLabel.TabIndex = 9;
            this.tuitionLabel.Text = "Tuition Charges:";
            // 
            // tuitionAmountLabel
            // 
            this.tuitionAmountLabel.AutoSize = true;
            this.tuitionAmountLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionAmountLabel.Location = new System.Drawing.Point(153, 194);
            this.tuitionAmountLabel.Name = "tuitionAmountLabel";
            this.tuitionAmountLabel.Size = new System.Drawing.Size(41, 18);
            this.tuitionAmountLabel.TabIndex = 10;
            this.tuitionAmountLabel.Text = "$0.00";
            // 
            // creditsUpDown
            // 
            this.creditsUpDown.Location = new System.Drawing.Point(23, 41);
            this.creditsUpDown.Name = "creditsUpDown";
            this.creditsUpDown.Size = new System.Drawing.Size(120, 20);
            this.creditsUpDown.TabIndex = 11;
            // 
            // StudentTuitionCalculatorForm
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(298, 282);
            this.Controls.Add(this.creditsUpDown);
            this.Controls.Add(this.tuitionAmountLabel);
            this.Controls.Add(this.tuitionLabel);
            this.Controls.Add(this.NonResNonUSRadioBtn);
            this.Controls.Add(this.nonResUSCitRadioBtn);
            this.Controls.Add(this.residentRadioBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.creditAmountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentTuitionCalculatorForm";
            this.Text = "Student Tuition Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label creditAmountLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton residentRadioBtn;
        private System.Windows.Forms.RadioButton nonResUSCitRadioBtn;
        private System.Windows.Forms.RadioButton NonResNonUSRadioBtn;
        private System.Windows.Forms.Label tuitionLabel;
        private System.Windows.Forms.Label tuitionAmountLabel;
        private System.Windows.Forms.NumericUpDown creditsUpDown;
    }
}

