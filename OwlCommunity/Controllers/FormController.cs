using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OwlCommunity.Controllers
{
    class FormController
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
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = true;
            f.btnEdit.Enabled = true;
            f.btnFind.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
            f.btnCreateFaculty.Text = "Create Faculty";
            f.btnCreateChairperson.Enabled = true;
            f.btnCreateChairperson.Text = "Create Chairperson";
            f.btnCreateGraduateStudent.Enabled = true;
            f.btnCreateGraduateStudent.Text = "Create Graduate Student";
            f.btnCreateUndergraduateStudent.Enabled = true;
            f.btnCreateUndergraduateStudent.Text = "Create Undergraduate";

            // Reset group components
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.Gainsboro;
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Gainsboro;
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Gainsboro;
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Gainsboro;
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Gainsboro;
            f.grpChairperson.BackColor = Color.Gainsboro;
            f.grpChairperson.Enabled = false;

            // Reset Text boxes
            f.txtOwlMemberID.Enabled = false;
            f.txtOwlMemberName.Enabled = false;
            f.txtOwlMemberBirthDate.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.txtFacultyRank.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtUndergraduateStudentTuition.Enabled = false;
            f.txtUndergraduateStudentYear.Enabled = false;
            f.txtUndergraduateStudentCredits.Enabled = false;
            f.txtGraduateStudentDegreeProgram.Enabled = false;
            f.txtGraduateStudentStipend.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.txtFacultyRank.Enabled = false;
        }


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(Views.MainForm f)
        {
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
        } 


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(Views.MainForm f)
        {
            f.btnCreateGraduateStudent.Enabled = true;
            f.btnCreateChairperson.Enabled = true;
            f.btnCreateUndergraduateStudent.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
        }  


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(Views.MainForm f)
        {
            f.btnCreateGraduateStudent.Enabled = false;
            f.btnCreateChairperson.Enabled = false;
            f.btnCreateUndergraduateStudent.Enabled = false;
            f.btnCreateFaculty.Enabled = false;
        } 


        // Enables OwlMember textboxes and highlights the OwlMember groupbox
        public static void activateOwlMember(Views.MainForm f)
        {
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.LimeGreen;

        }


        //  Enables Student textboxes and highlights the Student groupbox
        public static void activateStudent(Views.MainForm f)
        {
            activateOwlMember(f);
            f.grpStudent.Enabled = true;
            f.grpStudent.BackColor = Color.LimeGreen;
        }  


        // Enables Faculty textboxes and highlights the Faculty groupbox
        public static void activateFaculty(Views.MainForm f)
        {
            activateOwlMember(f);
            f.grpFaculty.Enabled = true;
            f.grpFaculty.BackColor = Color.LimeGreen;
            f.grpStudent.BackColor = Color.Red;
        } 


        // Enables Undergrad Student textboxes and highlights the Undergrad Student groupbox
        public static void activateUndergraduateStudent(Views.MainForm f)
        {
            activateStudent(f);   // Student must be activated too
            f.grpUndergraduateStudent.Enabled = true;
            f.grpUndergraduateStudent.BackColor = Color.LimeGreen;
        }  


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateGraduateStudent(Views.MainForm f)
        {
            activateStudent(f);  // Student must be activated too
            f.grpGraduateStudent.Enabled = true;
            f.grpGraduateStudent.BackColor = Color.LimeGreen;
        }


        // Enables Chairperson textboxes and highlights the Chairperson groupbox
        public static void activateChairperson(Views.MainForm f)
        {
            activateFaculty(f);  // Faculty must be activated too
            f.grpChairperson.Enabled = true;
            f.grpChairperson.BackColor = Color.LimeGreen;
        }


        // Disables OwlMember textboxes and highlights the OwlMember groupbox
        public static void deactivateOwlMember(Views.MainForm f)
        {
            deactivateStudent(f);
            deactivateFaculty(f);
            f.grpOwlMember.Enabled = false;
            f.grpOwlMember.BackColor = Color.Red;
        }


        // Disables Student textboxes and highlights the Student groupbox
        public static void deactivateStudent(Views.MainForm f)
        {
            deactivateUndergraduateStudent(f);   // Must deactivate UG Student too
            deactivateGraduateStudent(f);        // Must deactivate Grad Student too
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Red;
        }  // end deactivateStudent


        // Disables Faculty textboxes and highlights the Faculty groupbox
        public static void deactivateFaculty(Views.MainForm f)
        {
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Red;
        } 


        // Disables Undergraduate Student textboxes and highlights the Undergrad groupbox
        public static void deactivateUndergraduateStudent(Views.MainForm f)
        {
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Red;
        }


        // Disables Graduate Student textboxes and highlights the Grad Student groupbox
        public static void deactivateGraduateStudent(Views.MainForm f)
        {
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Red;
        } 


        // Disables Chairperson textboxes and highlights the Chairperson groupbox
        public static void deactivateChairperson(Views.MainForm f)
        {
            f.grpFaculty.Enabled = false;
            f.grpChairperson.BackColor = Color.Red;
        }  



        // Clear all textboxes on the form
        public static void clear(Views.MainForm f)
        {
            f.txtOwlMemberName.Text = "";
            f.txtOwlMemberBirthDate.Text = "";
            f.txtOwlMemberID.Text = "";
            f.txtOwlMemberID.Focus();
            f.txtFacultyDepartment.Text = "";
            f.txtFacultyRank.Text = "";
            f.txtStudentMajor.Text = "";
            f.txtStudentGPA.Text = "";
            f.txtUndergraduateStudentTuition.Text = "";
            f.txtUndergraduateStudentYear.Text = "";
            f.txtUndergraduateStudentCredits.Text = "";
            f.txtGraduateStudentStipend.Text = "";
            f.txtGraduateStudentDegreeProgram.Text = "";
            f.txtChairpersonStipend.Text = "";
            resetForm(f);
        } 

    }  
} 
