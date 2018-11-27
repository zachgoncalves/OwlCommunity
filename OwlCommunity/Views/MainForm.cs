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
using System.Text.RegularExpressions;

namespace OwlCommunity.Views
{
    public partial class MainForm : Form
    {
        private int selectedMember; // Keeps track of selected member type
        private int ID;
        private string name;
        private DateTime dob;
        private string facultyDepartment;
        private decimal chairStipend;
        private string studentMajor;
        private decimal studentGPA;
        private int studentCredits;
        private decimal studentTuition;
        private decimal gradStipend;
        private bool isValidated = false; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SerializableFile.readFromFile(ref GlobalData.userList, "StoreFile.txt");
            MessageBox.Show(GlobalData.userList.displayList());
        }

        // For Creating Undergraduate Student
        private void btnCreateUndergrad_Click(object sender, EventArgs e)
        {
            selectedMember = 1;
            btnCreateGraduate.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChair.Enabled = false;
            FormController.formAddMode(this);
            FormController.activateUndergraduateStudent(this);
        }

        // For Creating Graduate Student
        private void btnCreateGraduate_Click(object sender, EventArgs e)
        {
            selectedMember = 2;
            btnCreateUndergrad.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChair.Enabled = false;
            FormController.formAddMode(this);
            FormController.activateGraduateStudent(this);
        }

        // For Creating Faculty Member
        private void btnCreateFaculty_Click(object sender, EventArgs e)
        {
            selectedMember = 3;
            btnCreateUndergrad.Enabled = false;
            btnCreateGraduate.Enabled = false;
            btnCreateChair.Enabled = false;
            FormController.formAddMode(this);
            FormController.activateFaculty(this);
        }

        // For Creating Chairperson
        private void btnCreateChair_Click(object sender, EventArgs e)
        {
            selectedMember = 4;
            btnCreateUndergrad.Enabled = false;
            btnCreateGraduate.Enabled = false;
            btnCreateFaculty.Enabled = false;
            FormController.formAddMode(this);
            FormController.activateChairperson(this);
        }

        // Validate Owl Member ID / Name
        private void validateOwlMember()
        {
            if (!String.IsNullOrEmpty(txtMemberID.Text))
            {
                try
                {
                    ID = Convert.ToInt32(txtMemberID.Text);
                    MessageBox.Show(ID.ToString());
                    isValidated = true;
                }
                catch
                {
                    MessageBox.Show("Please enter a valid integer, with no special characters.", "Validation Error");
                    txtMemberID.Text = "";
                    txtMemberID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID.", "Validation Error");
                txtMemberID.Focus();
            }
            if(!String.IsNullOrEmpty(txtMemberName.Text))
            {
                if (Regex.IsMatch(txtMemberName.Text, @"^[a-zA-Z ]*$"))
                {
                    name = txtMemberName.Text;
                    isValidated = true;
                }
                else { 
                    MessageBox.Show("Numbers or special characters are not allowed in your name.", "Validation Error");
                    txtMemberName.Text = "";
                    txtMemberName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Validation Error");
            }
            dob = dtBD.Value;
        }

        // Validates Student 
        private void validateStudent()
        {
            validateOwlMember();
            if(!String.IsNullOrEmpty(txtStudentMajor.Text))
            {
                // TO DO: Allow Ampersand?
                if (Regex.IsMatch(txtStudentMajor.Text, @"^[a-zA-Z ]*$"))
                {
                    studentMajor = txtStudentMajor.Text;
                    isValidated = true;
                }
                else { 
                    MessageBox.Show("Numbers and special characters are not allowed in student major.", "Validation Error");
                    txtStudentMajor.Text = "";
                    txtStudentMajor.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a student major", "Validation Error");
                txtStudentMajor.Focus(); 
            }
            if(!String.IsNullOrEmpty(txtStudentGPA.Text))
            {
                try
                {
                    studentGPA = Math.Round(Convert.ToDecimal(txtStudentGPA.Text), 2);
                    if (studentGPA > (decimal)4.00 || studentGPA < (decimal)0.00)
                    {
                        MessageBox.Show("Please enter a GPA both greater than 0 and less than 4.00", "Validation Error");
                        txtStudentGPA.Text = "";
                        txtStudentGPA.Focus();
                        studentGPA = 0;
                    }
                    else
                    {
                        txtStudentGPA.Text = studentGPA.ToString();
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid student GPA up to two decimal places.", "Validation Error");
                    txtStudentGPA.Text = "";
                    txtStudentGPA.Focus(); 
                }
            }
        }

        // Validates Undergraduate Student 
        private void validateUndergrad()
        {
            validateStudent();
            if(!String.IsNullOrEmpty(txtStudentTuition.Text))
            {
                try
                {
                    studentTuition = Convert.ToDecimal(txtStudentTuition.Text);
                    if(studentTuition < 0)
                    {
                        MessageBox.Show("Student tuition cannot be less than 0!", "Validation Error");
                        txtStudentTuition.Text = "";
                        txtStudentTuition.Focus();
                        studentTuition = 0;
                    }
                    else
                    {
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Student tuition must be a decimal.", "Validation Error");
                    txtStudentTuition.Text = "";
                    txtStudentTuition.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter the student's tuition");
                txtStudentTuition.Focus();
            }
            if(!String.IsNullOrEmpty(txtStudentCredits.Text))
            {
                try
                {
                    studentCredits = Convert.ToInt16(txtStudentCredits.Text);
                    if (studentCredits < 0)
                    {
                        MessageBox.Show("Student credits cannot be less than 0!", "Validation Error");
                        txtStudentCredits.Text = "";
                        txtStudentCredits.Focus();
                        studentCredits = 0;
                    }
                    else
                    {
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter the amount of credits the student is at.");
                    txtStudentCredits.Focus();
                }
            }
        }

        // Validates Graduate Student 
        private void validateGrad()
        {
            validateStudent();
            if (!String.IsNullOrEmpty(txtGradStipend.Text))
            {
                try
                {
                    gradStipend = Convert.ToDecimal(txtGradStipend.Text);
                    if (gradStipend <= 0)
                    {
                        MessageBox.Show("Please enter a stipend for the graduate student greater than 0.", "Validation Error");
                        txtGradStipend.Text = "";
                        txtGradStipend.Focus();
                    }
                    else
                    {
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a stipend for the gradudate student.", "Validation Error");
                    txtGradStipend.Text = "";
                    txtGradStipend.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a graduate student stipend.", "Validation Error");
                txtGradStipend.Focus();
            }
        }

        // Validates Faculty Department and Rank
        private void validateFaculty()
        {
            validateOwlMember();

            if(!String.IsNullOrEmpty(txtFacultyDept.Text))
            {
                // TO DO: Allow Ampersand? 
                if (Regex.IsMatch(txtFacultyDept.Text, @"^[a-zA-Z ]*$"))
                {
                    facultyDepartment = txtFacultyDept.Text;
                    isValidated = true;
                }
                else
                {
                    MessageBox.Show("Please enter a department.", "Validation Error");
                    txtFacultyDept.Text = "";
                    txtFacultyDept.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a faculty department.", "Validation Error");
                txtFacultyDept.Focus();
            }
        }

        // Validates Department Chairperson
        private void validateChair()
        {
            validateFaculty();
            if(!String.IsNullOrEmpty(txtChairStipend.Text))
            {
                try
                {
                    chairStipend = Convert.ToDecimal(txtChairStipend.Text);
                    if(chairStipend <= 0)
                    {
                        MessageBox.Show("Please enter a stipend for the department chair greater than 0.", "Validation Error");
                        txtChairStipend.Text = "";
                        txtChairStipend.Focus();
                    } else
                    {
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a stipend for the department chair.", "Validation Error");
                    txtChairStipend.Text = "";
                    txtChairStipend.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a chairperson stipend.", "Validation Error");
                txtChairStipend.Focus();
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SerializableFile.writeToFile(GlobalData.userList, "StoreFile.txt");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Undergraduate Student
            if(selectedMember == 1)
            {
                validateUndergrad();
                if(isValidated)
                {
                    Models.UndergraduateStudent student = new Models.UndergraduateStudent(name, ID, dtBD.Value, studentGPA, studentMajor, studentTuition, studentCredits, cbYear.SelectedItem.ToString());
                    GlobalData.userList.addToList(student);
                }
                isValidated = false;
            }
            // Validate Graduate Student
            if(selectedMember == 2)
            {
                validateGrad();
                if(isValidated)
                {
                    Models.GraduateStudent gradStudent = new Models.GraduateStudent(name, ID, dtBD.Value, studentMajor, studentGPA, gradStipend, cbProgram.SelectedItem.ToString());
                    GlobalData.userList.addToList(gradStudent);
                }
                isValidated = false;
            }
            // Validate Faculty
            if (selectedMember == 3)
            {
                validateFaculty();
                if(isValidated)
                {
                    Models.FacultyMember faculty = new Models.FacultyMember(name, ID, dtBD.Value, facultyDepartment, cbRank.SelectedItem.ToString());
                    GlobalData.userList.addToList(faculty);
                }
                isValidated = false;
            }
            // Validate Department Chair
            if(selectedMember == 4)
            {
                validateChair();
                if(isValidated)
                {
                    Models.FacultyChairperson facultyChair = new Models.FacultyChairperson(name, ID, dtBD.Value, facultyDepartment, cbRank.SelectedItem.ToString(), chairStipend);
                    GlobalData.userList.addToList(facultyChair);
                }
                isValidated = false;
            }
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtTUIDEnter.Text);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            Models.OwlMember member = GlobalData.userList.searchList(Convert.ToInt32(txtTUIDEnter.Text), ref isFound);
            if(isFound)
            {
                member.Display(this);
            }
            else
            {
                MessageBox.Show("No member exists with that ID.", "Error: User Not Found");
            }
        }

    }
}
