//Christine Jordan
//HW4 10.30.2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class SectionForm : Form
    {
        public SectionForm()
        {
            InitializeComponent();
        }

        private void tblSectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ParentMDIForm form = (ParentMDIForm)ParentForm;
            if (this.Validate()) //checking if valid
            {
                this.tblSectionsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registrationDataSet);
                form.UpdateStatusBar($"Updated/Saved {this.registrationDataSet.tblSections.Count} sections.");
            }
            else //if not valid status bar will update letting user know
            {
                form.UpdateStatusBar("Invalid Data. Save failed.");
            }

        }

        private void SectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.tblSections' table. You can move, or remove it, as needed.
            this.tblSectionsTableAdapter.Fill(this.registrationDataSet.tblSections);

            ParentMDIForm form = (ParentMDIForm)ParentForm;
            form.UpdateStatusBar($"Loaded {this.registrationDataSet.tblSections.Count} sections.");
        }
    }
}
