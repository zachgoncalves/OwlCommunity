namespace OwlCommunity.Views
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCreateUndergrad = new System.Windows.Forms.Button();
            this.btnCreateGraduate = new System.Windows.Forms.Button();
            this.gbOwlMember = new System.Windows.Forms.GroupBox();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.gbGraduate = new System.Windows.Forms.GroupBox();
            this.lblGradProgram = new System.Windows.Forms.Label();
            this.txtGradProgram = new System.Windows.Forms.TextBox();
            this.txtGradStipend = new System.Windows.Forms.TextBox();
            this.lblGradStipend = new System.Windows.Forms.Label();
            this.gbUndergrad = new System.Windows.Forms.GroupBox();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.txtStudentYear = new System.Windows.Forms.TextBox();
            this.lblStudentCredits = new System.Windows.Forms.Label();
            this.txtStudentCredits = new System.Windows.Forms.TextBox();
            this.lblTuition = new System.Windows.Forms.Label();
            this.txtStudentTuition = new System.Windows.Forms.TextBox();
            this.lblStudentGPA = new System.Windows.Forms.Label();
            this.txtStudentGPA = new System.Windows.Forms.TextBox();
            this.lblStudentMajor = new System.Windows.Forms.Label();
            this.txtStudentMajor = new System.Windows.Forms.TextBox();
            this.lblMemberBD = new System.Windows.Forms.Label();
            this.txtMemberBD = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.gbFaculty = new System.Windows.Forms.GroupBox();
            this.lblFacultyRank = new System.Windows.Forms.Label();
            this.txtFacultyRank = new System.Windows.Forms.TextBox();
            this.lblFacultyDept = new System.Windows.Forms.Label();
            this.gbChair = new System.Windows.Forms.GroupBox();
            this.lblChairStipend = new System.Windows.Forms.Label();
            this.txtChairStipend = new System.Windows.Forms.TextBox();
            this.txtFacultyDept = new System.Windows.Forms.TextBox();
            this.btnCreateFaculty = new System.Windows.Forms.Button();
            this.btnCreateChair = new System.Windows.Forms.Button();
            this.gbFormControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOwlMember.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.gbGraduate.SuspendLayout();
            this.gbUndergrad.SuspendLayout();
            this.gbFaculty.SuspendLayout();
            this.gbChair.SuspendLayout();
            this.gbFormControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Owl Community Data Entry";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 40);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(301, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Please select the action you wish to complete. ";
            // 
            // btnCreateUndergrad
            // 
            this.btnCreateUndergrad.Location = new System.Drawing.Point(14, 70);
            this.btnCreateUndergrad.Name = "btnCreateUndergrad";
            this.btnCreateUndergrad.Size = new System.Drawing.Size(154, 27);
            this.btnCreateUndergrad.TabIndex = 2;
            this.btnCreateUndergrad.Text = "New Undergraduate Student";
            this.btnCreateUndergrad.UseVisualStyleBackColor = true;
            // 
            // btnCreateGraduate
            // 
            this.btnCreateGraduate.Location = new System.Drawing.Point(174, 70);
            this.btnCreateGraduate.Name = "btnCreateGraduate";
            this.btnCreateGraduate.Size = new System.Drawing.Size(154, 27);
            this.btnCreateGraduate.TabIndex = 3;
            this.btnCreateGraduate.Text = "New Graduate Student";
            this.btnCreateGraduate.UseVisualStyleBackColor = true;
            // 
            // gbOwlMember
            // 
            this.gbOwlMember.Controls.Add(this.gbStudent);
            this.gbOwlMember.Controls.Add(this.lblMemberBD);
            this.gbOwlMember.Controls.Add(this.txtMemberBD);
            this.gbOwlMember.Controls.Add(this.lblMemberName);
            this.gbOwlMember.Controls.Add(this.txtMemberName);
            this.gbOwlMember.Controls.Add(this.lblMemberID);
            this.gbOwlMember.Controls.Add(this.txtMemberID);
            this.gbOwlMember.Controls.Add(this.gbFaculty);
            this.gbOwlMember.Location = new System.Drawing.Point(16, 121);
            this.gbOwlMember.Name = "gbOwlMember";
            this.gbOwlMember.Size = new System.Drawing.Size(545, 357);
            this.gbOwlMember.TabIndex = 4;
            this.gbOwlMember.TabStop = false;
            this.gbOwlMember.Text = "Create Owl Member";
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.gbGraduate);
            this.gbStudent.Controls.Add(this.gbUndergrad);
            this.gbStudent.Controls.Add(this.lblStudentGPA);
            this.gbStudent.Controls.Add(this.txtStudentGPA);
            this.gbStudent.Controls.Add(this.lblStudentMajor);
            this.gbStudent.Controls.Add(this.txtStudentMajor);
            this.gbStudent.Location = new System.Drawing.Point(7, 193);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(532, 164);
            this.gbStudent.TabIndex = 7;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // gbGraduate
            // 
            this.gbGraduate.Controls.Add(this.lblGradProgram);
            this.gbGraduate.Controls.Add(this.txtGradProgram);
            this.gbGraduate.Controls.Add(this.txtGradStipend);
            this.gbGraduate.Controls.Add(this.lblGradStipend);
            this.gbGraduate.Location = new System.Drawing.Point(262, 53);
            this.gbGraduate.Name = "gbGraduate";
            this.gbGraduate.Size = new System.Drawing.Size(270, 111);
            this.gbGraduate.TabIndex = 13;
            this.gbGraduate.TabStop = false;
            this.gbGraduate.Text = "Graduate Student";
            // 
            // lblGradProgram
            // 
            this.lblGradProgram.AutoSize = true;
            this.lblGradProgram.Location = new System.Drawing.Point(23, 48);
            this.lblGradProgram.Name = "lblGradProgram";
            this.lblGradProgram.Size = new System.Drawing.Size(84, 13);
            this.lblGradProgram.TabIndex = 17;
            this.lblGradProgram.Text = "Degree Program";
            // 
            // txtGradProgram
            // 
            this.txtGradProgram.Location = new System.Drawing.Point(113, 45);
            this.txtGradProgram.Name = "txtGradProgram";
            this.txtGradProgram.Size = new System.Drawing.Size(103, 20);
            this.txtGradProgram.TabIndex = 16;
            this.txtGradProgram.Tag = "";
            // 
            // txtGradStipend
            // 
            this.txtGradStipend.Location = new System.Drawing.Point(113, 19);
            this.txtGradStipend.Name = "txtGradStipend";
            this.txtGradStipend.Size = new System.Drawing.Size(103, 20);
            this.txtGradStipend.TabIndex = 14;
            this.txtGradStipend.Tag = "";
            // 
            // lblGradStipend
            // 
            this.lblGradStipend.AutoSize = true;
            this.lblGradStipend.Location = new System.Drawing.Point(22, 22);
            this.lblGradStipend.Name = "lblGradStipend";
            this.lblGradStipend.Size = new System.Drawing.Size(43, 13);
            this.lblGradStipend.TabIndex = 15;
            this.lblGradStipend.Text = "Stipend";
            // 
            // gbUndergrad
            // 
            this.gbUndergrad.Controls.Add(this.lblStudentYear);
            this.gbUndergrad.Controls.Add(this.txtStudentYear);
            this.gbUndergrad.Controls.Add(this.lblStudentCredits);
            this.gbUndergrad.Controls.Add(this.txtStudentCredits);
            this.gbUndergrad.Controls.Add(this.lblTuition);
            this.gbUndergrad.Controls.Add(this.txtStudentTuition);
            this.gbUndergrad.Location = new System.Drawing.Point(0, 53);
            this.gbUndergrad.Name = "gbUndergrad";
            this.gbUndergrad.Size = new System.Drawing.Size(263, 111);
            this.gbUndergrad.TabIndex = 12;
            this.gbUndergrad.TabStop = false;
            this.gbUndergrad.Text = "Undergraduate Student";
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(24, 73);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(29, 13);
            this.lblStudentYear.TabIndex = 13;
            this.lblStudentYear.Text = "Year";
            // 
            // txtStudentYear
            // 
            this.txtStudentYear.Location = new System.Drawing.Point(72, 71);
            this.txtStudentYear.Name = "txtStudentYear";
            this.txtStudentYear.Size = new System.Drawing.Size(56, 20);
            this.txtStudentYear.TabIndex = 12;
            this.txtStudentYear.Tag = "";
            // 
            // lblStudentCredits
            // 
            this.lblStudentCredits.AutoSize = true;
            this.lblStudentCredits.Location = new System.Drawing.Point(24, 48);
            this.lblStudentCredits.Name = "lblStudentCredits";
            this.lblStudentCredits.Size = new System.Drawing.Size(39, 13);
            this.lblStudentCredits.TabIndex = 11;
            this.lblStudentCredits.Text = "Credits";
            // 
            // txtStudentCredits
            // 
            this.txtStudentCredits.Location = new System.Drawing.Point(72, 45);
            this.txtStudentCredits.Name = "txtStudentCredits";
            this.txtStudentCredits.Size = new System.Drawing.Size(56, 20);
            this.txtStudentCredits.TabIndex = 10;
            this.txtStudentCredits.Tag = "";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(23, 22);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(39, 13);
            this.lblTuition.TabIndex = 9;
            this.lblTuition.Text = "Tuition";
            // 
            // txtStudentTuition
            // 
            this.txtStudentTuition.Location = new System.Drawing.Point(72, 19);
            this.txtStudentTuition.Name = "txtStudentTuition";
            this.txtStudentTuition.Size = new System.Drawing.Size(100, 20);
            this.txtStudentTuition.TabIndex = 8;
            this.txtStudentTuition.Tag = "";
            // 
            // lblStudentGPA
            // 
            this.lblStudentGPA.AutoSize = true;
            this.lblStudentGPA.Location = new System.Drawing.Point(274, 22);
            this.lblStudentGPA.Name = "lblStudentGPA";
            this.lblStudentGPA.Size = new System.Drawing.Size(29, 13);
            this.lblStudentGPA.TabIndex = 11;
            this.lblStudentGPA.Text = "GPA";
            // 
            // txtStudentGPA
            // 
            this.txtStudentGPA.Location = new System.Drawing.Point(313, 19);
            this.txtStudentGPA.Name = "txtStudentGPA";
            this.txtStudentGPA.Size = new System.Drawing.Size(76, 20);
            this.txtStudentGPA.TabIndex = 10;
            this.txtStudentGPA.Tag = "";
            // 
            // lblStudentMajor
            // 
            this.lblStudentMajor.AutoSize = true;
            this.lblStudentMajor.Location = new System.Drawing.Point(23, 22);
            this.lblStudentMajor.Name = "lblStudentMajor";
            this.lblStudentMajor.Size = new System.Drawing.Size(33, 13);
            this.lblStudentMajor.TabIndex = 9;
            this.lblStudentMajor.Text = "Major";
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(62, 19);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(171, 20);
            this.txtStudentMajor.TabIndex = 8;
            this.txtStudentMajor.Tag = "";
            // 
            // lblMemberBD
            // 
            this.lblMemberBD.AutoSize = true;
            this.lblMemberBD.Location = new System.Drawing.Point(347, 22);
            this.lblMemberBD.Name = "lblMemberBD";
            this.lblMemberBD.Size = new System.Drawing.Size(49, 13);
            this.lblMemberBD.TabIndex = 6;
            this.lblMemberBD.Text = "Birthdate";
            // 
            // txtMemberBD
            // 
            this.txtMemberBD.Location = new System.Drawing.Point(402, 19);
            this.txtMemberBD.Name = "txtMemberBD";
            this.txtMemberBD.Size = new System.Drawing.Size(137, 20);
            this.txtMemberBD.TabIndex = 5;
            this.txtMemberBD.Tag = "";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(154, 22);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(35, 13);
            this.lblMemberName.TabIndex = 4;
            this.lblMemberName.Text = "Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(191, 19);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(137, 20);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.Tag = "";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(11, 22);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(18, 13);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Text = "ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(35, 19);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.Tag = "";
            // 
            // gbFaculty
            // 
            this.gbFaculty.Controls.Add(this.lblFacultyRank);
            this.gbFaculty.Controls.Add(this.txtFacultyRank);
            this.gbFaculty.Controls.Add(this.lblFacultyDept);
            this.gbFaculty.Controls.Add(this.gbChair);
            this.gbFaculty.Controls.Add(this.txtFacultyDept);
            this.gbFaculty.Location = new System.Drawing.Point(7, 67);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Size = new System.Drawing.Size(532, 119);
            this.gbFaculty.TabIndex = 0;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Faculty";
            // 
            // lblFacultyRank
            // 
            this.lblFacultyRank.AutoSize = true;
            this.lblFacultyRank.Location = new System.Drawing.Point(230, 22);
            this.lblFacultyRank.Name = "lblFacultyRank";
            this.lblFacultyRank.Size = new System.Drawing.Size(33, 13);
            this.lblFacultyRank.TabIndex = 10;
            this.lblFacultyRank.Text = "Rank";
            // 
            // txtFacultyRank
            // 
            this.txtFacultyRank.Location = new System.Drawing.Point(269, 19);
            this.txtFacultyRank.Name = "txtFacultyRank";
            this.txtFacultyRank.Size = new System.Drawing.Size(100, 20);
            this.txtFacultyRank.TabIndex = 9;
            this.txtFacultyRank.Tag = "";
            // 
            // lblFacultyDept
            // 
            this.lblFacultyDept.AutoSize = true;
            this.lblFacultyDept.Location = new System.Drawing.Point(23, 22);
            this.lblFacultyDept.Name = "lblFacultyDept";
            this.lblFacultyDept.Size = new System.Drawing.Size(62, 13);
            this.lblFacultyDept.TabIndex = 8;
            this.lblFacultyDept.Text = "Department";
            // 
            // gbChair
            // 
            this.gbChair.Controls.Add(this.lblChairStipend);
            this.gbChair.Controls.Add(this.txtChairStipend);
            this.gbChair.Location = new System.Drawing.Point(0, 55);
            this.gbChair.Name = "gbChair";
            this.gbChair.Size = new System.Drawing.Size(532, 64);
            this.gbChair.TabIndex = 0;
            this.gbChair.TabStop = false;
            this.gbChair.Text = "Chairperson";
            // 
            // lblChairStipend
            // 
            this.lblChairStipend.AutoSize = true;
            this.lblChairStipend.Location = new System.Drawing.Point(23, 29);
            this.lblChairStipend.Name = "lblChairStipend";
            this.lblChairStipend.Size = new System.Drawing.Size(102, 13);
            this.lblChairStipend.TabIndex = 12;
            this.lblChairStipend.Text = "Chairperson Stipend";
            // 
            // txtChairStipend
            // 
            this.txtChairStipend.Location = new System.Drawing.Point(133, 26);
            this.txtChairStipend.Name = "txtChairStipend";
            this.txtChairStipend.Size = new System.Drawing.Size(100, 20);
            this.txtChairStipend.TabIndex = 11;
            this.txtChairStipend.Tag = "";
            // 
            // txtFacultyDept
            // 
            this.txtFacultyDept.Location = new System.Drawing.Point(91, 19);
            this.txtFacultyDept.Name = "txtFacultyDept";
            this.txtFacultyDept.Size = new System.Drawing.Size(100, 20);
            this.txtFacultyDept.TabIndex = 7;
            this.txtFacultyDept.Tag = "";
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(334, 70);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(154, 27);
            this.btnCreateFaculty.TabIndex = 5;
            this.btnCreateFaculty.Text = "New Faculty Member";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            // 
            // btnCreateChair
            // 
            this.btnCreateChair.Location = new System.Drawing.Point(494, 70);
            this.btnCreateChair.Name = "btnCreateChair";
            this.btnCreateChair.Size = new System.Drawing.Size(154, 27);
            this.btnCreateChair.TabIndex = 6;
            this.btnCreateChair.Text = "New Chairperson";
            this.btnCreateChair.UseVisualStyleBackColor = true;
            // 
            // gbFormControls
            // 
            this.gbFormControls.Controls.Add(this.btnDelete);
            this.gbFormControls.Controls.Add(this.btnSave);
            this.gbFormControls.Controls.Add(this.btnEdit);
            this.gbFormControls.Controls.Add(this.btnDisplay);
            this.gbFormControls.Controls.Add(this.lblEnterID);
            this.gbFormControls.Controls.Add(this.textBox1);
            this.gbFormControls.Location = new System.Drawing.Point(16, 495);
            this.gbFormControls.Name = "gbFormControls";
            this.gbFormControls.Size = new System.Drawing.Size(545, 100);
            this.gbFormControls.TabIndex = 7;
            this.gbFormControls.TabStop = false;
            this.gbFormControls.Text = "Data Processing Controls";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(435, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(31, 63);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(30, 31);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(130, 13);
            this.lblEnterID.TabIndex = 15;
            this.lblEnterID.Text = "Please Enter Target TUID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Tag = "";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(584, 128);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(64, 50);
            this.btnClearForm.TabIndex = 8;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(584, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 630);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.gbFormControls);
            this.Controls.Add(this.btnCreateChair);
            this.Controls.Add(this.btnCreateFaculty);
            this.Controls.Add(this.gbOwlMember);
            this.Controls.Add(this.btnCreateGraduate);
            this.Controls.Add(this.btnCreateUndergrad);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbOwlMember.ResumeLayout(false);
            this.gbOwlMember.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbGraduate.ResumeLayout(false);
            this.gbGraduate.PerformLayout();
            this.gbUndergrad.ResumeLayout(false);
            this.gbUndergrad.PerformLayout();
            this.gbFaculty.ResumeLayout(false);
            this.gbFaculty.PerformLayout();
            this.gbChair.ResumeLayout(false);
            this.gbChair.PerformLayout();
            this.gbFormControls.ResumeLayout(false);
            this.gbFormControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDesc;
        public System.Windows.Forms.Button btnCreateUndergrad;
        public System.Windows.Forms.Button btnCreateGraduate;
        public System.Windows.Forms.Button btnCreateFaculty;
        public System.Windows.Forms.Button btnCreateChair;
        public System.Windows.Forms.Label lblMemberBD;
        public System.Windows.Forms.TextBox txtMemberBD;
        public System.Windows.Forms.Label lblMemberName;
        public System.Windows.Forms.TextBox txtMemberName;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.Button btnClearForm;
        public System.Windows.Forms.GroupBox gbOwlMember;
        public System.Windows.Forms.GroupBox gbFaculty;
        public System.Windows.Forms.GroupBox gbChair;
        public System.Windows.Forms.GroupBox gbStudent;
        public System.Windows.Forms.GroupBox gbUndergrad;
        public System.Windows.Forms.GroupBox gbGraduate;
        public System.Windows.Forms.Label lblFacultyRank;
        public System.Windows.Forms.TextBox txtFacultyRank;
        public System.Windows.Forms.Label lblFacultyDept;
        public System.Windows.Forms.TextBox txtFacultyDept;
        public System.Windows.Forms.Label lblChairStipend;
        public System.Windows.Forms.TextBox txtChairStipend;
        public System.Windows.Forms.Label lblStudentGPA;
        public System.Windows.Forms.TextBox txtStudentGPA;
        public System.Windows.Forms.Label lblStudentMajor;
        public System.Windows.Forms.TextBox txtStudentMajor;
        public System.Windows.Forms.Label lblStudentCredits;
        public System.Windows.Forms.TextBox txtStudentCredits;
        public System.Windows.Forms.Label lblTuition;
        public System.Windows.Forms.TextBox txtStudentTuition;
        public System.Windows.Forms.Label lblStudentYear;
        public System.Windows.Forms.TextBox txtStudentYear;
        public System.Windows.Forms.Label lblGradProgram;
        public System.Windows.Forms.TextBox txtGradProgram;
        public System.Windows.Forms.TextBox txtGradStipend;
        public System.Windows.Forms.Label lblGradStipend;
        public System.Windows.Forms.GroupBox gbFormControls;
        public System.Windows.Forms.Label lblEnterID;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnExit;
    }
}