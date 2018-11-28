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
        // Owl Member Attributes
        private int ID;
        private string name;
        private DateTime dob;
        // Faculty Attributes
        private string facultyDepartment;
        private decimal chairStipend;
        // Student Attributes
        private string studentMajor;
        private decimal studentGPA;
        private int studentCredits;
        private decimal studentTuition;
        private decimal gradStipend;
        // Attributes used for tracking state
        Models.OwlMember member;
        private bool isValidated = false;
        private bool editMode = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SerializableFile.readFromFile(ref GlobalData.userList, "StoreFile.bin");
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
        
        // Validate ID
        public bool ValidID(string strID, out string errorMessage)
        {
            if (strID.Length == 0)
            {
                errorMessage = "ID is required.";
                return false;
            }

            if (strID.Length != 9)
            {
                errorMessage = "Please enter an integer ID of length 9.";
                return false;
            }
            else
            {
                try
                {
                    ID = Convert.ToInt32(strID);
                    errorMessage = "";
                    return true;
                }
                catch
                {
                    errorMessage = "Please enter a valid integer.";
                    return false;
                }
            }
        }
        // ID is being validated
        private void ValidatingID(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidID(txtMemberID.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtMemberID.Select(0, txtMemberID.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtMemberID, errorMsg);
            }
        }
        // ID has been validated 
        private void ValidatedID(object sender, System.EventArgs e)
        {
            validateError.SetError(txtMemberName, "");
        }

        // Validate Name
        public bool ValidName(string strName, out string errorMessage)
        {
            if (strName.Length == 0)
            {
                errorMessage = "Name is required.";
                return false;
            }

            if (!Regex.IsMatch(txtMemberName.Text, @"^[a-zA-Z ]*$"))
            {
                errorMessage = "You have illegal characters in your name.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
        // Name is being validated
        private void ValidatingName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(txtMemberName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtMemberName.Select(0, txtMemberName.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtMemberName, errorMsg);
            }
        }
        // Name has been validated 
        private void ValidatedName(object sender, System.EventArgs e)
        {
            validateError.SetError(txtMemberName, "");
        }

        /*
        // Validate Owl Member ID / Name
        private void validateOwlMember()
        {
            if (!String.IsNullOrEmpty(txtMemberID.Text))
            {
                if (txtMemberID.Text.Length == 9)
                {
                    try
                    {
                        ID = Convert.ToInt32(txtMemberID.Text);
                        isValidated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid integer ID with no special characters.", "Validation Error");
                        txtMemberID.Text = "";
                        txtMemberID.Focus();
                        isValidated = false;
                    }

                }
                else
                {
                    MessageBox.Show("Please enter an ID of 9 integers.", "Validation Error");
                    txtMemberID.Text = "";
                    txtMemberID.Focus();
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID.", "Validation Error");
                txtMemberID.Focus();
                isValidated = false;
            }
            if (!String.IsNullOrEmpty(txtMemberName.Text))
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
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Validation Error");
                isValidated = false;
            }
            dob = dtBD.Value;
        }
        */
        // Validates Student 
        private void validateStudent()
        {
           // validateOwlMember();
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
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a student major", "Validation Error");
                txtStudentMajor.Focus();
                isValidated = false;
            }
            if (!String.IsNullOrEmpty(txtStudentGPA.Text))
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
                        isValidated = false;
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
                    isValidated = false;
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
                        isValidated = false;
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
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the student's tuition");
                txtStudentTuition.Focus();
                isValidated = false;
            }
            if (!String.IsNullOrEmpty(txtStudentCredits.Text))
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
                        isValidated = false;
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
                    isValidated = false;
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
                        isValidated = false;
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
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a graduate student stipend.", "Validation Error");
                txtGradStipend.Focus();
                isValidated = false;
            }
        }

        // Validates Faculty Department and Rank
        private void validateFaculty()
        {
            // validateOwlMember();

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
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a faculty department.", "Validation Error");
                txtFacultyDept.Focus();
                isValidated = false;
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
                        isValidated = false;
                    }
                    else
                    {
                        isValidated = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a stipend for the department chair.", "Validation Error");
                    txtChairStipend.Text = "";
                    txtChairStipend.Focus();
                    isValidated = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a chairperson stipend.", "Validation Error");
                txtChairStipend.Focus();
                isValidated = false;
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
            btnDisplay.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SerializableFile.writeToFile(GlobalData.userList, "StoreFile.bin");
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
                    successfullyCreated();
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
                    successfullyCreated();
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
                    successfullyCreated();
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
                    successfullyCreated();
                }
                isValidated = false;
            }
            // Update existing entry 
            if(editMode)
            {
                member.Save(this);
                MessageBox.Show("OwlMember successfully updated!", "Success");
            }
        }

        private void successfullyCreated()
        {
            MessageBox.Show("OwlMember succesfully created!");
            FormController.clear(this);
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTUIDEnter.Text.Length != 9)
                {
                    MessageBox.Show("Please enter an ID of 9 integers.", "Validation Error");
                    txtTUIDEnter.Text = "";
                    txtTUIDEnter.Focus();
                } else
                {
                    ID = Convert.ToInt32(txtTUIDEnter.Text);
                    btnDisplay.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid 9 integer ID number.", "Validation Error");
                txtTUIDEnter.Text = "";
                txtTUIDEnter.Focus();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            member = GlobalData.userList.searchList(Convert.ToInt32(txtTUIDEnter.Text), ref isFound);
            if(isFound)
            {
                member.Display(this);
            }
            else
            {
                MessageBox.Show("No member exists with that ID.", "Error: User Not Found");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            editMode = true;
            Models.OwlMember member = GlobalData.userList.searchList(Convert.ToInt32(txtTUIDEnter.Text), ref isFound);
            if (isFound)
            {
                member.Display(this);
                member.Edit(this);
            }
            else
            {
                MessageBox.Show("No member exists with that ID.", "Error: User Not Found");
            }
        }
    }
}
