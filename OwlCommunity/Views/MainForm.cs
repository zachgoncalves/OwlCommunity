using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwlCommunity.Controllers;
using OwlCommunity.Classes;

namespace OwlCommunity.Views
{
    public partial class MainForm : Form
    {
        private int selectedMember; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateUndergrad_Click(object sender, EventArgs e)
        {
            selectedMember = 1;
            btnCreateGraduate.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChair.Enabled = false;
            FormController.formAddMode(this);
            FormController.activateOwlMember(this);
            FormController.activateStudent(this);
            FormController.activateUndergraduateStudent(this);
            FormController.deactivateChairperson(this);
            FormController.deactivateFaculty(this);
            FormController.deactivateGraduateStudent(this);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Undergraduate Student
            if(selectedMember == 1)
            {

            }
        }
    }
}
