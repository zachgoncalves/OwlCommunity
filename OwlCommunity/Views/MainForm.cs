/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Form: Main Form
 * Written by: Zachary Goncalves
 */

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
using System.IO;

namespace OwlCommunity.Views
{
    public partial class MainForm : Form
    {
        private int selectedMember; // Keeps track of selected member type
        // Owl Member Attributes
        private int ID;
        private string name;
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
        private Models.OwlMember member;
        private bool editMode = false;
        private bool addMode = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SerializableFile.readFromFile(ref GlobalData.userList, "StoreFile.bin");
            //MessageBox.Show(GlobalData.userList.displayList());
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
            addMode = true;
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
            addMode = true;
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
            addMode = true;
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
            addMode = true;
        }

        // Validate ID
        public bool ValidID(string strID, out string errorMessage)
        {
            if (String.IsNullOrEmpty(strID))
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
            validateError.SetError(txtMemberID, "");
        }

        // Validate Name
        public bool ValidName(string strName, out string errorMessage)
        {
            if (String.IsNullOrEmpty(strName))
            {
                errorMessage = "Name is required.";
                return false;
            }

            if (!Regex.IsMatch(strName, @"^[a-zA-Z ]*$"))
            {
                errorMessage = "You have illegal characters in your name.";
                return false;
            }
            else
            {
                errorMessage = "";
                name = strName;
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

        // Validate Major
        public bool ValidMajor(string strMajor, out string errorMessage)
        {
            if (String.IsNullOrEmpty(strMajor))
            {
                errorMessage = "Major is required.";
                return false;
            }

            if (!Regex.IsMatch(strMajor, @"^[a-zA-Z\s&]*$"))
            {
                errorMessage = "You have illegal characters in your major.";
                return false;
            }
            else
            {
                errorMessage = "";
                studentMajor = strMajor;
                return true;
            }
        }
        // Major is being validated
        private void ValidatingMajor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMajor(txtStudentMajor.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtStudentMajor.Select(0, txtStudentMajor.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtStudentMajor, errorMsg);
            }
        }
        // Major has been validated 
        private void ValidatedMajor(object sender, System.EventArgs e)
        {
            validateError.SetError(txtStudentMajor, "");
        }

        // Validate GPA
        public bool ValidGPA(string GPA, out string errorMessage)
        {
            if (String.IsNullOrEmpty(GPA))
            {
                errorMessage = "GPA is required.";
                return false;
            }
            else
            {
                try
                {
                    if (!Regex.IsMatch(GPA, @"^[0-4]+(\.\d{2})$"))
                    {
                        errorMessage = "Please enter a GPA both greater than 0 and less than 4.00";
                        return false;
                    }
                    else
                    {
                        studentGPA = Convert.ToDecimal(GPA);
                        errorMessage = "";
                        return true;
                    }
                }
                catch
                {
                    errorMessage = "Please enter a valid GPA.";
                    return false;
                }
            }
        }
        // GPA is being validated
        private void ValidatingGPA(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidGPA(txtStudentGPA.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtStudentGPA.Select(0, txtStudentGPA.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtStudentGPA, errorMsg);
            }
        }
        // GPA has been validated 
        private void ValidatedGPA(object sender, System.EventArgs e)
        {
            validateError.SetError(txtStudentGPA, "");
        }

        // Validate Tutition 
        public bool ValidTuition(string tuition, out string errorMessage)
        {
            if(String.IsNullOrEmpty(tuition))
            {
                errorMessage = "Tuition is required.";
                return false;
            }
            else
            {
                try
                {
                    decimal tempTuition = Convert.ToDecimal(tuition);
                    if(Regex.IsMatch(tuition, @"^\d+(\.\d{2})?$")) {
                        studentTuition = tempTuition;
                        errorMessage = "";
                        return true;
                    }
                    else
                    {
                        studentTuition = 0;
                        errorMessage = "Tuition must be zero or greater and can go up to two decimal places.";
                        return false;
                    }
                }
                catch
                {
                    errorMessage = "Student tuition must be a decimal.";
                    return false;
                }
            }
        }
        // Validating Tuition
        private void ValidatingTuition(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidTuition(txtStudentTuition.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtStudentTuition.Select(0, txtStudentTuition.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtStudentTuition, errorMsg);
            }
        }
        // Tuition has been validated
        private void ValidatedTuition(object sender, System.EventArgs e)
        {
            validateError.SetError(txtStudentTuition, "");
        }

        // Validate Credits 
        public bool ValidCredits(string credits, out string errorMessage)
        {
            if (String.IsNullOrEmpty(credits))
            {
                errorMessage = "The amount of credits is required.";
                return false;
            }
            else
            {
                try
                {
                    int tempCredits = Convert.ToInt16(credits);
                    if (tempCredits < 0)
                    {
                        errorMessage = "The amount of credits cannot be less than 0.";
                        return false;
                    }
                    else
                    {
                        studentCredits = tempCredits;
                        errorMessage = "";
                        return true;
                    }
                }
                catch
                {
                    errorMessage = "Student credits must be an integer.";
                    return false;
                }
            }
        }
        // Validating Credits
        private void ValidatingCredits(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidCredits(txtStudentCredits.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtStudentCredits.Select(0, txtStudentCredits.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtStudentCredits, errorMsg);
            }
        }
        // Credits have been validated
        private void ValidatedCredits(object sender, System.EventArgs e)
        {
            validateError.SetError(txtStudentCredits, "");
        }

        // Validate Graduate Stipend 
        public bool ValidGradStipend(string stipend, out string errorMessage)
        {
            if (String.IsNullOrEmpty(stipend))
            {
                errorMessage = "A stipend amount is required.";
                return false;
            }
            else
            {
                try
                {
                    decimal tempStipend = Convert.ToDecimal(stipend);
                    if (tempStipend < 0)
                    {
                        errorMessage = "The stipend must be greater than 0.";
                        return false;
                    }
                    else
                    {
                        gradStipend = tempStipend;
                        errorMessage = "";
                        return true;
                    }
                }
                catch
                {
                    errorMessage = "The stipend must be an valid decimal.";
                    return false;
                }
            }
        }
        // Validating Grad Stipend
        private void ValidatingGradStipend(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidGradStipend(txtGradStipend.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtGradStipend.Select(0, txtGradStipend.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtGradStipend, errorMsg);
            }
        }
        // Grad Stipend has been validated
        private void ValidatedGradStipend(object sender, System.EventArgs e)
        {
            validateError.SetError(txtGradStipend, "");
        }

        // Validate Chair Stipend 
        public bool ValidChairStipend(string stipend, out string errorMessage)
        {
            if (String.IsNullOrEmpty(stipend))
            {
                errorMessage = "A stipend amount is required.";
                return false;
            }
            else
            {
                try
                {
                    decimal tempStipend = Convert.ToDecimal(stipend);
                    if (tempStipend < 0)
                    {
                        errorMessage = "The stipend must be greater than 0.";
                        return false;
                    }
                    else
                    {
                        chairStipend = tempStipend;
                        errorMessage = "";
                        return true;
                    }
                }
                catch
                {
                    errorMessage = "The stipend must be an valid decimal.";
                    return false;
                }
            }
        }
        // Validating Chair Stipend
        private void ValidatingChairStipend(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidChairStipend(txtChairStipend.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtChairStipend.Select(0, txtChairStipend.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtChairStipend, errorMsg);
            }
        }
        // Chair Stipend has been validated
        private void ValidatedChairStipend(object sender, System.EventArgs e)
        {
            validateError.SetError(txtChairStipend, "");
        }
        // Validate Department
        public bool ValidDepartment(string strDept, out string errorMessage)
        {
            if (String.IsNullOrEmpty(strDept))
            {
                errorMessage = "Department is required.";
                return false;
            }

            if (!Regex.IsMatch(strDept, @"^[a-zA-Z\s&]*$"))
            {
                errorMessage = "You have illegal characters in the department name.";
                return false;
            }
            else
            {
                errorMessage = "";
                facultyDepartment = strDept;
                return true;
            }
        }
        // Department is being validated
        private void ValidatingDepartment(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepartment(txtFacultyDept.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtFacultyDept.Select(0, txtFacultyDept.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.validateError.SetError(txtFacultyDept, errorMsg);
            }
        }
        // Department has been validated 
        private void ValidatedDept(object sender, System.EventArgs e)
        {
            validateError.SetError(txtFacultyDept, "");
        }

        // Clears form and disables edit mode buttons
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
            btnDisplay.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Writes out file and closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            SerializableFile.writeToFile(GlobalData.userList, "StoreFile.bin");
            this.Close();
        }

        // Checks GroupBox controls for validation errors or empty textboxes/dropdowns
        public bool checkValidationStatus(GroupBox control)
        {
            bool isInvalid = true;
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if (validateError.GetError(c) != "" || String.IsNullOrEmpty(c.Text))
                    {
                        isInvalid = true;
                        break;
                    }
                    else
                    {
                        isInvalid = false;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.SelectedItem == null || cb.SelectedIndex == -1 || string.IsNullOrEmpty(cb.Text))
                    {
                        isInvalid = true;
                        break;
                    }
                    else
                    {
                        isInvalid = false;
                    }
                }
            }
            if(isInvalid == true)
            {
                MessageBox.Show("Please correct validation errors." + "\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isInvalid;
        }

        // Instantiates owl member objects, confirms validation rules are met, and updates OwlMembers
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(addMode)
            {
                bool isFound = false;
                GlobalData.userList.searchList(Convert.ToInt32(txtMemberID.Text), ref isFound);
                if (isFound)
                {
                    MessageBox.Show("A user by this TUID already exists. Please enter a new TUID.", "User Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberID.Text = "";
                    txtMemberID.Focus();
                }
                else
                {
                    // Create Undergraduate Student
                    if (selectedMember == 1)
                    {
                        if (checkValidationStatus(gbOwlMember) == false && checkValidationStatus(gbStudent) == false && checkValidationStatus(gbUndergrad) == false)
                        {
                            Models.UndergraduateStudent student = new Models.UndergraduateStudent(name, ID, dtBD.Value, studentGPA, studentMajor, studentTuition, studentCredits, cbYear.SelectedItem.ToString());
                            GlobalData.userList.addToList(student);
                            successfullyCreated();
                        }
                    }
                    // Create Graduate Student
                    if (selectedMember == 2)
                    {
                        if (checkValidationStatus(gbOwlMember) == false && checkValidationStatus(gbStudent) == false && checkValidationStatus(gbGraduate) == false)
                        {
                            Models.GraduateStudent gradStudent = new Models.GraduateStudent(name, ID, dtBD.Value, studentMajor, studentGPA, gradStipend, cbProgram.SelectedItem.ToString());
                            GlobalData.userList.addToList(gradStudent);
                            successfullyCreated();
                        }
                    }
                    // Create Faculty
                    if (selectedMember == 3)
                    {
                        if (checkValidationStatus(gbOwlMember) == false && checkValidationStatus(gbFaculty) == false)
                        {
                            Models.FacultyMember faculty = new Models.FacultyMember(name, ID, dtBD.Value, facultyDepartment, cbRank.SelectedItem.ToString());
                            GlobalData.userList.addToList(faculty);
                            successfullyCreated();
                        }
                    }
                    // Create Department Chair
                    if (selectedMember == 4)
                    {
                        if (checkValidationStatus(gbOwlMember) == false && checkValidationStatus(gbFaculty) == false && checkValidationStatus(gbChair) == false)
                        {
                            Models.FacultyChairperson facultyChair = new Models.FacultyChairperson(name, ID, dtBD.Value, facultyDepartment, cbRank.SelectedItem.ToString(), chairStipend);
                            GlobalData.userList.addToList(facultyChair);
                            successfullyCreated();
                        }
                    }
                }
            }

            // Update existing entry 
            if(editMode)
            {
                member.Save(this);
                MessageBox.Show("OwlMember successfully updated!", "Success");
            }
        }

        // Outputs message about succesful OwlMember creation and clears form
        private void successfullyCreated()
        {
            MessageBox.Show("OwlMember succesfully created!");
            FormController.clear(this);
   
        }
        
        // Validates ID entered and enables additional controls 
        private void btnEnterID_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTUIDEnter.Text.Length != 9)
                {
                    MessageBox.Show("Please enter an ID of 9 integers.", "Validation Error");
                    txtTUIDEnter.Text = "";
                    txtTUIDEnter.Focus();
                }
                else
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

        // Loads OwlMember Data into form
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

        // Loads OwlMember Data into form and allows for editing 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            editMode = true;
            member = GlobalData.userList.searchList(Convert.ToInt32(txtTUIDEnter.Text), ref isFound);
            if (isFound)
            {
                member.Display(this);
                member.Edit(this);
            }
            else
            {
                MessageBox.Show("No member exists with that ID.", "Error: User Not Found");
            }
            txtMemberID.Enabled = false;
        }

        // Deletes OwlMember objects
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            member = GlobalData.userList.searchList(Convert.ToInt32(txtTUIDEnter.Text), ref isFound);
            if (isFound)
            {
                member.Display(this);
                GlobalData.userList.removeFromList(member);
                MessageBox.Show("OwlMember successfully deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormController.clear(this);
                if (File.Exists("StoreFile.bin"))
                {
                    File.Delete("StoreFile.bin");
                }
            }
            else
            {
                MessageBox.Show("No member exists with that ID.", "Error: User Not Found");
            }
        }
    }
}
