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
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.cbYear = new System.Windows.Forms.ComboBox();
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
            this.lblTitle.Location = new System.Drawing.Point(16, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Owl Community Data Entry";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(16, 49);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(359, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Please select the action you wish to complete. ";
            // 
            // btnCreateUndergrad
            // 
            this.btnCreateUndergrad.Location = new System.Drawing.Point(19, 86);
            this.btnCreateUndergrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateUndergrad.Name = "btnCreateUndergrad";
            this.btnCreateUndergrad.Size = new System.Drawing.Size(205, 33);
            this.btnCreateUndergrad.TabIndex = 2;
            this.btnCreateUndergrad.Text = "New Undergraduate Student";
            this.btnCreateUndergrad.UseVisualStyleBackColor = true;
            this.btnCreateUndergrad.Click += new System.EventHandler(this.btnCreateUndergrad_Click);
            // 
            // btnCreateGraduate
            // 
            this.btnCreateGraduate.Location = new System.Drawing.Point(232, 86);
            this.btnCreateGraduate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateGraduate.Name = "btnCreateGraduate";
            this.btnCreateGraduate.Size = new System.Drawing.Size(205, 33);
            this.btnCreateGraduate.TabIndex = 3;
            this.btnCreateGraduate.Text = "New Graduate Student";
            this.btnCreateGraduate.UseVisualStyleBackColor = true;
            // 
            // gbOwlMember
            // 
            this.gbOwlMember.Controls.Add(this.dtBD);
            this.gbOwlMember.Controls.Add(this.gbStudent);
            this.gbOwlMember.Controls.Add(this.lblMemberBD);
            this.gbOwlMember.Controls.Add(this.lblMemberName);
            this.gbOwlMember.Controls.Add(this.txtMemberName);
            this.gbOwlMember.Controls.Add(this.lblMemberID);
            this.gbOwlMember.Controls.Add(this.txtMemberID);
            this.gbOwlMember.Controls.Add(this.gbFaculty);
            this.gbOwlMember.Location = new System.Drawing.Point(21, 149);
            this.gbOwlMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOwlMember.Name = "gbOwlMember";
            this.gbOwlMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOwlMember.Size = new System.Drawing.Size(727, 439);
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
            this.gbStudent.Location = new System.Drawing.Point(9, 238);
            this.gbStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudent.Size = new System.Drawing.Size(709, 202);
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
            this.gbGraduate.Location = new System.Drawing.Point(349, 65);
            this.gbGraduate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGraduate.Name = "gbGraduate";
            this.gbGraduate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGraduate.Size = new System.Drawing.Size(360, 137);
            this.gbGraduate.TabIndex = 13;
            this.gbGraduate.TabStop = false;
            this.gbGraduate.Text = "Graduate Student";
            // 
            // lblGradProgram
            // 
            this.lblGradProgram.AutoSize = true;
            this.lblGradProgram.Location = new System.Drawing.Point(31, 59);
            this.lblGradProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradProgram.Name = "lblGradProgram";
            this.lblGradProgram.Size = new System.Drawing.Size(113, 17);
            this.lblGradProgram.TabIndex = 17;
            this.lblGradProgram.Text = "Degree Program";
            // 
            // txtGradProgram
            // 
            this.txtGradProgram.Location = new System.Drawing.Point(151, 55);
            this.txtGradProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradProgram.Name = "txtGradProgram";
            this.txtGradProgram.Size = new System.Drawing.Size(136, 22);
            this.txtGradProgram.TabIndex = 16;
            this.txtGradProgram.Tag = "";
            // 
            // txtGradStipend
            // 
            this.txtGradStipend.Location = new System.Drawing.Point(151, 23);
            this.txtGradStipend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradStipend.Name = "txtGradStipend";
            this.txtGradStipend.Size = new System.Drawing.Size(136, 22);
            this.txtGradStipend.TabIndex = 14;
            this.txtGradStipend.Tag = "";
            // 
            // lblGradStipend
            // 
            this.lblGradStipend.AutoSize = true;
            this.lblGradStipend.Location = new System.Drawing.Point(29, 27);
            this.lblGradStipend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradStipend.Name = "lblGradStipend";
            this.lblGradStipend.Size = new System.Drawing.Size(56, 17);
            this.lblGradStipend.TabIndex = 15;
            this.lblGradStipend.Text = "Stipend";
            // 
            // gbUndergrad
            // 
            this.gbUndergrad.Controls.Add(this.cbYear);
            this.gbUndergrad.Controls.Add(this.lblStudentYear);
            this.gbUndergrad.Controls.Add(this.txtStudentYear);
            this.gbUndergrad.Controls.Add(this.lblStudentCredits);
            this.gbUndergrad.Controls.Add(this.txtStudentCredits);
            this.gbUndergrad.Controls.Add(this.lblTuition);
            this.gbUndergrad.Controls.Add(this.txtStudentTuition);
            this.gbUndergrad.Location = new System.Drawing.Point(0, 65);
            this.gbUndergrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUndergrad.Name = "gbUndergrad";
            this.gbUndergrad.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUndergrad.Size = new System.Drawing.Size(351, 137);
            this.gbUndergrad.TabIndex = 12;
            this.gbUndergrad.TabStop = false;
            this.gbUndergrad.Text = "Undergraduate Student";
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(32, 90);
            this.lblStudentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(38, 17);
            this.lblStudentYear.TabIndex = 13;
            this.lblStudentYear.Text = "Year";
            // 
            // txtStudentYear
            // 
            this.txtStudentYear.Location = new System.Drawing.Point(96, 87);
            this.txtStudentYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentYear.Name = "txtStudentYear";
            this.txtStudentYear.Size = new System.Drawing.Size(73, 22);
            this.txtStudentYear.TabIndex = 12;
            this.txtStudentYear.Tag = "";
            // 
            // lblStudentCredits
            // 
            this.lblStudentCredits.AutoSize = true;
            this.lblStudentCredits.Location = new System.Drawing.Point(32, 59);
            this.lblStudentCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCredits.Name = "lblStudentCredits";
            this.lblStudentCredits.Size = new System.Drawing.Size(52, 17);
            this.lblStudentCredits.TabIndex = 11;
            this.lblStudentCredits.Text = "Credits";
            // 
            // txtStudentCredits
            // 
            this.txtStudentCredits.Location = new System.Drawing.Point(96, 55);
            this.txtStudentCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentCredits.Name = "txtStudentCredits";
            this.txtStudentCredits.Size = new System.Drawing.Size(73, 22);
            this.txtStudentCredits.TabIndex = 10;
            this.txtStudentCredits.Tag = "";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(31, 27);
            this.lblTuition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(51, 17);
            this.lblTuition.TabIndex = 9;
            this.lblTuition.Text = "Tuition";
            // 
            // txtStudentTuition
            // 
            this.txtStudentTuition.Location = new System.Drawing.Point(96, 23);
            this.txtStudentTuition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentTuition.Name = "txtStudentTuition";
            this.txtStudentTuition.Size = new System.Drawing.Size(132, 22);
            this.txtStudentTuition.TabIndex = 8;
            this.txtStudentTuition.Tag = "";
            // 
            // lblStudentGPA
            // 
            this.lblStudentGPA.AutoSize = true;
            this.lblStudentGPA.Location = new System.Drawing.Point(365, 27);
            this.lblStudentGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentGPA.Name = "lblStudentGPA";
            this.lblStudentGPA.Size = new System.Drawing.Size(37, 17);
            this.lblStudentGPA.TabIndex = 11;
            this.lblStudentGPA.Text = "GPA";
            // 
            // txtStudentGPA
            // 
            this.txtStudentGPA.Location = new System.Drawing.Point(417, 23);
            this.txtStudentGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentGPA.Name = "txtStudentGPA";
            this.txtStudentGPA.Size = new System.Drawing.Size(100, 22);
            this.txtStudentGPA.TabIndex = 10;
            this.txtStudentGPA.Tag = "";
            // 
            // lblStudentMajor
            // 
            this.lblStudentMajor.AutoSize = true;
            this.lblStudentMajor.Location = new System.Drawing.Point(31, 27);
            this.lblStudentMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentMajor.Name = "lblStudentMajor";
            this.lblStudentMajor.Size = new System.Drawing.Size(43, 17);
            this.lblStudentMajor.TabIndex = 9;
            this.lblStudentMajor.Text = "Major";
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(83, 23);
            this.txtStudentMajor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(227, 22);
            this.txtStudentMajor.TabIndex = 8;
            this.txtStudentMajor.Tag = "";
            // 
            // lblMemberBD
            // 
            this.lblMemberBD.AutoSize = true;
            this.lblMemberBD.Location = new System.Drawing.Point(463, 27);
            this.lblMemberBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberBD.Name = "lblMemberBD";
            this.lblMemberBD.Size = new System.Drawing.Size(65, 17);
            this.lblMemberBD.TabIndex = 6;
            this.lblMemberBD.Text = "Birthdate";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(205, 27);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(45, 17);
            this.lblMemberName.TabIndex = 4;
            this.lblMemberName.Text = "Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(255, 23);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(181, 22);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.Tag = "";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(15, 27);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(21, 17);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Text = "ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(47, 23);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(132, 22);
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
            this.gbFaculty.Location = new System.Drawing.Point(9, 82);
            this.gbFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFaculty.Size = new System.Drawing.Size(709, 146);
            this.gbFaculty.TabIndex = 0;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Faculty";
            // 
            // lblFacultyRank
            // 
            this.lblFacultyRank.AutoSize = true;
            this.lblFacultyRank.Location = new System.Drawing.Point(307, 27);
            this.lblFacultyRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacultyRank.Name = "lblFacultyRank";
            this.lblFacultyRank.Size = new System.Drawing.Size(41, 17);
            this.lblFacultyRank.TabIndex = 10;
            this.lblFacultyRank.Text = "Rank";
            // 
            // txtFacultyRank
            // 
            this.txtFacultyRank.Location = new System.Drawing.Point(359, 23);
            this.txtFacultyRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFacultyRank.Name = "txtFacultyRank";
            this.txtFacultyRank.Size = new System.Drawing.Size(132, 22);
            this.txtFacultyRank.TabIndex = 9;
            this.txtFacultyRank.Tag = "";
            // 
            // lblFacultyDept
            // 
            this.lblFacultyDept.AutoSize = true;
            this.lblFacultyDept.Location = new System.Drawing.Point(31, 27);
            this.lblFacultyDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacultyDept.Name = "lblFacultyDept";
            this.lblFacultyDept.Size = new System.Drawing.Size(82, 17);
            this.lblFacultyDept.TabIndex = 8;
            this.lblFacultyDept.Text = "Department";
            // 
            // gbChair
            // 
            this.gbChair.Controls.Add(this.lblChairStipend);
            this.gbChair.Controls.Add(this.txtChairStipend);
            this.gbChair.Location = new System.Drawing.Point(0, 68);
            this.gbChair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Name = "gbChair";
            this.gbChair.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Size = new System.Drawing.Size(709, 79);
            this.gbChair.TabIndex = 0;
            this.gbChair.TabStop = false;
            this.gbChair.Text = "Chairperson";
            // 
            // lblChairStipend
            // 
            this.lblChairStipend.AutoSize = true;
            this.lblChairStipend.Location = new System.Drawing.Point(31, 36);
            this.lblChairStipend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChairStipend.Name = "lblChairStipend";
            this.lblChairStipend.Size = new System.Drawing.Size(137, 17);
            this.lblChairStipend.TabIndex = 12;
            this.lblChairStipend.Text = "Chairperson Stipend";
            // 
            // txtChairStipend
            // 
            this.txtChairStipend.Location = new System.Drawing.Point(177, 32);
            this.txtChairStipend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChairStipend.Name = "txtChairStipend";
            this.txtChairStipend.Size = new System.Drawing.Size(132, 22);
            this.txtChairStipend.TabIndex = 11;
            this.txtChairStipend.Tag = "";
            // 
            // txtFacultyDept
            // 
            this.txtFacultyDept.Location = new System.Drawing.Point(121, 23);
            this.txtFacultyDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFacultyDept.Name = "txtFacultyDept";
            this.txtFacultyDept.Size = new System.Drawing.Size(132, 22);
            this.txtFacultyDept.TabIndex = 7;
            this.txtFacultyDept.Tag = "";
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(445, 86);
            this.btnCreateFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(205, 33);
            this.btnCreateFaculty.TabIndex = 5;
            this.btnCreateFaculty.Text = "New Faculty Member";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            // 
            // btnCreateChair
            // 
            this.btnCreateChair.Location = new System.Drawing.Point(659, 86);
            this.btnCreateChair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateChair.Name = "btnCreateChair";
            this.btnCreateChair.Size = new System.Drawing.Size(205, 33);
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
            this.gbFormControls.Location = new System.Drawing.Point(21, 609);
            this.gbFormControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFormControls.Name = "gbFormControls";
            this.gbFormControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFormControls.Size = new System.Drawing.Size(727, 123);
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
            this.btnDelete.Location = new System.Drawing.Point(580, 78);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(467, 78);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(159, 78);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(41, 78);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 28);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(40, 38);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(171, 17);
            this.lblEnterID.TabIndex = 15;
            this.lblEnterID.Text = "Please Enter Target TUID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Tag = "";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(779, 158);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(85, 62);
            this.btnClearForm.TabIndex = 8;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(779, 697);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dtBD
            // 
            this.dtBD.CustomFormat = "dd-MM-yyyy";
            this.dtBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBD.Location = new System.Drawing.Point(535, 23);
            this.dtBD.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dtBD.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(183, 22);
            this.dtBD.TabIndex = 8;
            this.dtBD.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "Fr",
            "So",
            "Jr",
            "Sr"});
            this.cbYear.Location = new System.Drawing.Point(177, 86);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 24);
            this.cbYear.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 775);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        public System.Windows.Forms.DateTimePicker dtBD;
        private System.Windows.Forms.ComboBox cbYear;
    }
}