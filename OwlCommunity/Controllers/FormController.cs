using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using OwlCommunity.Classes;
using OwlCommunity.Views;

namespace OwlCommunity.Controllers
{
    public class FormController
    {
        private Views.MainForm f;

        // Parametrized Constructor
        public FormController(Views.MainForm parentForm)
        {
            f = parentForm;
        } 

        // Resets form to initial state after form is loaded or
        //    an add Employee operation is performed

        public static void resetForm(Views.MainForm f)
        {
            //  Reset button components
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = true;
            f.btnEdit.Enabled = true;
            f.btnDisplay.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
            f.btnCreateFaculty.Text = "Create Faculty";
            f.btnCreateChair.Enabled = true;
            f.btnCreateChair.Text = "Create Chairperson";
            f.btnCreateGraduate.Enabled = true;
            f.btnCreateGraduate.Text = "Create Graduate Student";
            f.btnCreateUndergrad.Enabled = true;
            f.btnCreateUndergrad.Text = "Create Undergraduate";

            // Reset group components
            f.gbOwlMember.Enabled = true;
            f.gbOwlMember.BackColor = Color.Gainsboro;
            f.gbStudent.Enabled = false;
            f.gbStudent.BackColor = Color.Gainsboro;
            f.gbFaculty.Enabled = false;
            f.gbFaculty.BackColor = Color.Gainsboro;
            f.gbUndergrad.Enabled = false;
            f.gbUndergrad.BackColor = Color.Gainsboro;
            f.gbGraduate.Enabled = false;
            f.gbGraduate.BackColor = Color.Gainsboro;
            f.gbChair.BackColor = Color.Gainsboro;
            f.gbChair.Enabled = false;

            // Reset Text boxes
            f.txtMemberID.Enabled = false;
            f.txtMemberName.Enabled = false;
            f.dtBD.Enabled = false;
            f.txtFacultyDept.Enabled = false;
            f.txtFacultyRank.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentTuition.Enabled = false;
            f.txtStudentYear.Enabled = false;
            f.txtStudentCredits.Enabled = false;
            f.txtGradProgram.Enabled = false;
            f.txtGradStipend.Enabled = false;
            f.txtFacultyDept.Enabled = false;
            f.txtFacultyRank.Enabled = false;
        }


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(Views.MainForm f)
        {
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnDisplay.Enabled = false;
        } 


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(Views.MainForm f)
        {
            f.btnCreateGraduate.Enabled = true;
            f.btnCreateChair.Enabled = true;
            f.btnCreateUndergrad.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
        }  


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(Views.MainForm f)
        {
            f.btnCreateGraduate.Enabled = false;
            f.btnCreateChair.Enabled = false;
            f.btnCreateUndergrad.Enabled = false;
            f.btnCreateFaculty.Enabled = false;
        } 


        // Enables OwlMember textboxes and highlights the OwlMember groupbox
        public static void activateOwlMember(Views.MainForm f)
        {
            f.gbOwlMember.Enabled = true;
            f.gbOwlMember.BackColor = Color.LimeGreen;

        }


        //  Enables Student textboxes and highlights the Student groupbox
        public static void activateStudent(Views.MainForm f)
        {
            activateOwlMember(f);
            f.gbStudent.Enabled = true;
            f.gbStudent.BackColor = Color.LimeGreen;
        }  


        // Enables Faculty textboxes and highlights the Faculty groupbox
        public static void activateFaculty(Views.MainForm f)
        {
            activateOwlMember(f);
            f.gbFaculty.Enabled = true;
            f.gbFaculty.BackColor = Color.LimeGreen;
            f.gbStudent.BackColor = Color.Red;
        } 


        // Enables Undergrad Student textboxes and highlights the Undergrad Student groupbox
        public static void activateUndergraduateStudent(Views.MainForm f)
        {
            activateStudent(f);   // Student must be activated too
            f.gbUndergrad.Enabled = true;
            f.gbUndergrad.BackColor = Color.LimeGreen;
        }  


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateGraduateStudent(Views.MainForm f)
        {
            activateStudent(f);  // Student must be activated too
            f.gbGraduate.Enabled = true;
            f.gbGraduate.BackColor = Color.LimeGreen;
        }


        // Enables Chairperson textboxes and highlights the Chairperson groupbox
        public static void activateChairperson(Views.MainForm f)
        {
            activateFaculty(f);  // Faculty must be activated too
            f.gbChair.Enabled = true;
            f.gbChair.BackColor = Color.LimeGreen;
        }


        // Disables OwlMember textboxes and highlights the OwlMember groupbox
        public static void deactivateOwlMember(Views.MainForm f)
        {
            deactivateStudent(f);
            deactivateFaculty(f);
            f.gbOwlMember.Enabled = false;
            f.gbOwlMember.BackColor = Color.Red;
        }


        // Disables Student textboxes and highlights the Student groupbox
        public static void deactivateStudent(Views.MainForm f)
        {
            deactivateUndergraduateStudent(f);   // Must deactivate UG Student too
            deactivateGraduateStudent(f);        // Must deactivate Grad Student too
            f.gbStudent.Enabled = false;
            f.gbStudent.BackColor = Color.Red;
        }  // end deactivateStudent


        // Disables Faculty textboxes and highlights the Faculty groupbox
        public static void deactivateFaculty(Views.MainForm f)
        {
            f.gbFaculty.Enabled = false;
            f.gbFaculty.BackColor = Color.Red;
        } 


        // Disables Undergraduate Student textboxes and highlights the Undergrad groupbox
        public static void deactivateUndergraduateStudent(Views.MainForm f)
        {
            f.gbUndergrad.Enabled = false;
            f.gbUndergrad.BackColor = Color.Red;
        }


        // Disables Graduate Student textboxes and highlights the Grad Student groupbox
        public static void deactivateGraduateStudent(Views.MainForm f)
        {
            f.gbGraduate.Enabled = false;
            f.gbGraduate.BackColor = Color.Red;
        } 


        // Disables Chairperson textboxes and highlights the Chairperson groupbox
        public static void deactivateChairperson(Views.MainForm f)
        {
            f.gbFaculty.Enabled = false;
            f.gbChair.BackColor = Color.Red;
        }  



        // Clear all textboxes on the form
        public static void clear(Views.MainForm f)
        {
            f.txtMemberName.Text = "";
            f.dtBD.Text = "";
            f.txtMemberID.Text = "";
            f.txtMemberID.Focus();
            f.txtFacultyDept.Text = "";
            f.txtFacultyRank.Text = "";
            f.txtStudentMajor.Text = "";
            f.txtStudentGPA.Text = "";
            f.txtStudentTuition.Text = "";
            f.txtStudentYear.Text = "";
            f.txtStudentCredits.Text = "";
            f.txtGradStipend.Text = "";
            f.txtGradProgram.Text = "";
            f.txtChairStipend.Text = "";
            resetForm(f);
        } 

    }  
} 
