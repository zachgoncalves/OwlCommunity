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
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.gbGraduate = new System.Windows.Forms.GroupBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.lblGradProgram = new System.Windows.Forms.Label();
            this.txtGradStipend = new System.Windows.Forms.TextBox();
            this.lblGradStipend = new System.Windows.Forms.Label();
            this.gbUndergrad = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblStudentYear = new System.Windows.Forms.Label();
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
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.lblFacultyRank = new System.Windows.Forms.Label();
            this.lblFacultyDept = new System.Windows.Forms.Label();
            this.gbChair = new System.Windows.Forms.GroupBox();
            this.lblChairStipend = new System.Windows.Forms.Label();
            this.txtChairStipend = new System.Windows.Forms.TextBox();
            this.txtFacultyDept = new System.Windows.Forms.TextBox();
            this.btnCreateFaculty = new System.Windows.Forms.Button();
            this.btnCreateChair = new System.Windows.Forms.Button();
            this.gbFormControls = new System.Windows.Forms.GroupBox();
            this.btnEnterName = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.txtTUIDEnter = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Location = new System.Drawing.Point(18, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Owl Community Data Entry";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(18, 62);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(413, 25);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Please select the action you wish to complete. ";
            // 
            // btnCreateUndergrad
            // 
            this.btnCreateUndergrad.Location = new System.Drawing.Point(21, 108);
            this.btnCreateUndergrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateUndergrad.Name = "btnCreateUndergrad";
            this.btnCreateUndergrad.Size = new System.Drawing.Size(231, 42);
            this.btnCreateUndergrad.TabIndex = 2;
            this.btnCreateUndergrad.Text = "New Undergraduate Student";
            this.btnCreateUndergrad.UseVisualStyleBackColor = true;
            this.btnCreateUndergrad.Click += new System.EventHandler(this.btnCreateUndergrad_Click);
            // 
            // btnCreateGraduate
            // 
            this.btnCreateGraduate.Location = new System.Drawing.Point(261, 108);
            this.btnCreateGraduate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateGraduate.Name = "btnCreateGraduate";
            this.btnCreateGraduate.Size = new System.Drawing.Size(231, 42);
            this.btnCreateGraduate.TabIndex = 3;
            this.btnCreateGraduate.Text = "New Graduate Student";
            this.btnCreateGraduate.UseVisualStyleBackColor = true;
            this.btnCreateGraduate.Click += new System.EventHandler(this.btnCreateGraduate_Click);
            // 
            // gbOwlMember
            // 
            this.gbOwlMember.Controls.Add(this.dtBD);
            this.gbOwlMember.Controls.Add(this.gbStudent);
            this.gbOwlMember.Controls.Add(this.lblMemberBD);
            this.gbOwlMember.Controls.Add(this.gbChair);
            this.gbOwlMember.Controls.Add(this.lblMemberName);
            this.gbOwlMember.Controls.Add(this.txtMemberName);
            this.gbOwlMember.Controls.Add(this.lblMemberID);
            this.gbOwlMember.Controls.Add(this.txtMemberID);
            this.gbOwlMember.Controls.Add(this.gbFaculty);
            this.gbOwlMember.Enabled = false;
            this.gbOwlMember.Location = new System.Drawing.Point(24, 186);
            this.gbOwlMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOwlMember.Name = "gbOwlMember";
            this.gbOwlMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOwlMember.Size = new System.Drawing.Size(818, 549);
            this.gbOwlMember.TabIndex = 4;
            this.gbOwlMember.TabStop = false;
            this.gbOwlMember.Text = "Create Owl Member";
            // 
            // dtBD
            // 
            this.dtBD.CustomFormat = "dd-MM-yyyy";
            this.dtBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBD.Location = new System.Drawing.Point(602, 29);
            this.dtBD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtBD.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dtBD.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(205, 26);
            this.dtBD.TabIndex = 8;
            this.dtBD.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.gbGraduate);
            this.gbStudent.Controls.Add(this.gbUndergrad);
            this.gbStudent.Controls.Add(this.lblStudentGPA);
            this.gbStudent.Controls.Add(this.txtStudentGPA);
            this.gbStudent.Controls.Add(this.lblStudentMajor);
            this.gbStudent.Controls.Add(this.txtStudentMajor);
            this.gbStudent.Enabled = false;
            this.gbStudent.Location = new System.Drawing.Point(10, 298);
            this.gbStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudent.Size = new System.Drawing.Size(798, 252);
            this.gbStudent.TabIndex = 7;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // gbGraduate
            // 
            this.gbGraduate.Controls.Add(this.cbProgram);
            this.gbGraduate.Controls.Add(this.lblGradProgram);
            this.gbGraduate.Controls.Add(this.txtGradStipend);
            this.gbGraduate.Controls.Add(this.lblGradStipend);
            this.gbGraduate.Enabled = false;
            this.gbGraduate.Location = new System.Drawing.Point(393, 82);
            this.gbGraduate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGraduate.Name = "gbGraduate";
            this.gbGraduate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGraduate.Size = new System.Drawing.Size(405, 171);
            this.gbGraduate.TabIndex = 13;
            this.gbGraduate.TabStop = false;
            this.gbGraduate.Text = "Graduate Student";
            // 
            // cbProgram
            // 
            this.cbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "Ph.D",
            "Master"});
            this.cbProgram.Location = new System.Drawing.Point(170, 72);
            this.cbProgram.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(152, 28);
            this.cbProgram.TabIndex = 15;
            // 
            // lblGradProgram
            // 
            this.lblGradProgram.AutoSize = true;
            this.lblGradProgram.Location = new System.Drawing.Point(34, 74);
            this.lblGradProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradProgram.Name = "lblGradProgram";
            this.lblGradProgram.Size = new System.Drawing.Size(126, 20);
            this.lblGradProgram.TabIndex = 17;
            this.lblGradProgram.Text = "Degree Program";
            // 
            // txtGradStipend
            // 
            this.txtGradStipend.Location = new System.Drawing.Point(170, 29);
            this.txtGradStipend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGradStipend.Name = "txtGradStipend";
            this.txtGradStipend.Size = new System.Drawing.Size(152, 26);
            this.txtGradStipend.TabIndex = 14;
            this.txtGradStipend.Tag = "";
            // 
            // lblGradStipend
            // 
            this.lblGradStipend.AutoSize = true;
            this.lblGradStipend.Location = new System.Drawing.Point(33, 34);
            this.lblGradStipend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradStipend.Name = "lblGradStipend";
            this.lblGradStipend.Size = new System.Drawing.Size(64, 20);
            this.lblGradStipend.TabIndex = 15;
            this.lblGradStipend.Text = "Stipend";
            // 
            // gbUndergrad
            // 
            this.gbUndergrad.Controls.Add(this.cbYear);
            this.gbUndergrad.Controls.Add(this.lblStudentYear);
            this.gbUndergrad.Controls.Add(this.lblStudentCredits);
            this.gbUndergrad.Controls.Add(this.txtStudentCredits);
            this.gbUndergrad.Controls.Add(this.lblTuition);
            this.gbUndergrad.Controls.Add(this.txtStudentTuition);
            this.gbUndergrad.Enabled = false;
            this.gbUndergrad.Location = new System.Drawing.Point(0, 82);
            this.gbUndergrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUndergrad.Name = "gbUndergrad";
            this.gbUndergrad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUndergrad.Size = new System.Drawing.Size(394, 171);
            this.gbUndergrad.TabIndex = 12;
            this.gbUndergrad.TabStop = false;
            this.gbUndergrad.Text = "Undergraduate Student";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "Fr",
            "So",
            "Jr",
            "Sr"});
            this.cbYear.Location = new System.Drawing.Point(108, 109);
            this.cbYear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(148, 28);
            this.cbYear.TabIndex = 14;
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(36, 112);
            this.lblStudentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(43, 20);
            this.lblStudentYear.TabIndex = 13;
            this.lblStudentYear.Text = "Year";
            // 
            // lblStudentCredits
            // 
            this.lblStudentCredits.AutoSize = true;
            this.lblStudentCredits.Location = new System.Drawing.Point(36, 74);
            this.lblStudentCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCredits.Name = "lblStudentCredits";
            this.lblStudentCredits.Size = new System.Drawing.Size(59, 20);
            this.lblStudentCredits.TabIndex = 11;
            this.lblStudentCredits.Text = "Credits";
            // 
            // txtStudentCredits
            // 
            this.txtStudentCredits.Location = new System.Drawing.Point(108, 69);
            this.txtStudentCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentCredits.Name = "txtStudentCredits";
            this.txtStudentCredits.Size = new System.Drawing.Size(82, 26);
            this.txtStudentCredits.TabIndex = 10;
            this.txtStudentCredits.Tag = "";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(34, 34);
            this.lblTuition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(56, 20);
            this.lblTuition.TabIndex = 9;
            this.lblTuition.Text = "Tuition";
            // 
            // txtStudentTuition
            // 
            this.txtStudentTuition.Location = new System.Drawing.Point(108, 29);
            this.txtStudentTuition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentTuition.Name = "txtStudentTuition";
            this.txtStudentTuition.Size = new System.Drawing.Size(148, 26);
            this.txtStudentTuition.TabIndex = 8;
            this.txtStudentTuition.Tag = "";
            // 
            // lblStudentGPA
            // 
            this.lblStudentGPA.AutoSize = true;
            this.lblStudentGPA.Location = new System.Drawing.Point(411, 34);
            this.lblStudentGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentGPA.Name = "lblStudentGPA";
            this.lblStudentGPA.Size = new System.Drawing.Size(43, 20);
            this.lblStudentGPA.TabIndex = 11;
            this.lblStudentGPA.Text = "GPA";
            // 
            // txtStudentGPA
            // 
            this.txtStudentGPA.Location = new System.Drawing.Point(470, 29);
            this.txtStudentGPA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentGPA.Name = "txtStudentGPA";
            this.txtStudentGPA.Size = new System.Drawing.Size(112, 26);
            this.txtStudentGPA.TabIndex = 10;
            this.txtStudentGPA.Tag = "";
            // 
            // lblStudentMajor
            // 
            this.lblStudentMajor.AutoSize = true;
            this.lblStudentMajor.Location = new System.Drawing.Point(34, 34);
            this.lblStudentMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentMajor.Name = "lblStudentMajor";
            this.lblStudentMajor.Size = new System.Drawing.Size(48, 20);
            this.lblStudentMajor.TabIndex = 9;
            this.lblStudentMajor.Text = "Major";
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(93, 29);
            this.txtStudentMajor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(254, 26);
            this.txtStudentMajor.TabIndex = 8;
            this.txtStudentMajor.Tag = "";
            // 
            // lblMemberBD
            // 
            this.lblMemberBD.AutoSize = true;
            this.lblMemberBD.Location = new System.Drawing.Point(520, 34);
            this.lblMemberBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberBD.Name = "lblMemberBD";
            this.lblMemberBD.Size = new System.Drawing.Size(74, 20);
            this.lblMemberBD.TabIndex = 6;
            this.lblMemberBD.Text = "Birthdate";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(231, 34);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(51, 20);
            this.lblMemberName.TabIndex = 4;
            this.lblMemberName.Text = "Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(286, 29);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(204, 26);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.Tag = "";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(16, 34);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(26, 20);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Text = "ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(52, 29);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(148, 26);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.Tag = "";
            // 
            // gbFaculty
            // 
            this.gbFaculty.Controls.Add(this.cbRank);
            this.gbFaculty.Controls.Add(this.lblFacultyRank);
            this.gbFaculty.Controls.Add(this.lblFacultyDept);
            this.gbFaculty.Controls.Add(this.txtFacultyDept);
            this.gbFaculty.Enabled = false;
            this.gbFaculty.Location = new System.Drawing.Point(10, 102);
            this.gbFaculty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFaculty.Size = new System.Drawing.Size(798, 76);
            this.gbFaculty.TabIndex = 0;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Faculty";
            // 
            // cbRank
            // 
            this.cbRank.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Assosciate Professor",
            "Adjunt Professor",
            "Instructor "});
            this.cbRank.Location = new System.Drawing.Point(404, 29);
            this.cbRank.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(196, 28);
            this.cbRank.TabIndex = 15;
            // 
            // lblFacultyRank
            // 
            this.lblFacultyRank.AutoSize = true;
            this.lblFacultyRank.Location = new System.Drawing.Point(345, 34);
            this.lblFacultyRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacultyRank.Name = "lblFacultyRank";
            this.lblFacultyRank.Size = new System.Drawing.Size(47, 20);
            this.lblFacultyRank.TabIndex = 10;
            this.lblFacultyRank.Text = "Rank";
            // 
            // lblFacultyDept
            // 
            this.lblFacultyDept.AutoSize = true;
            this.lblFacultyDept.Location = new System.Drawing.Point(34, 34);
            this.lblFacultyDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacultyDept.Name = "lblFacultyDept";
            this.lblFacultyDept.Size = new System.Drawing.Size(94, 20);
            this.lblFacultyDept.TabIndex = 8;
            this.lblFacultyDept.Text = "Department";
            // 
            // gbChair
            // 
            this.gbChair.Controls.Add(this.lblChairStipend);
            this.gbChair.Controls.Add(this.txtChairStipend);
            this.gbChair.Enabled = false;
            this.gbChair.Location = new System.Drawing.Point(10, 169);
            this.gbChair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChair.Name = "gbChair";
            this.gbChair.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChair.Size = new System.Drawing.Size(798, 98);
            this.gbChair.TabIndex = 0;
            this.gbChair.TabStop = false;
            this.gbChair.Text = "Chairperson";
            // 
            // lblChairStipend
            // 
            this.lblChairStipend.AutoSize = true;
            this.lblChairStipend.Location = new System.Drawing.Point(34, 45);
            this.lblChairStipend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChairStipend.Name = "lblChairStipend";
            this.lblChairStipend.Size = new System.Drawing.Size(154, 20);
            this.lblChairStipend.TabIndex = 12;
            this.lblChairStipend.Text = "Chairperson Stipend";
            // 
            // txtChairStipend
            // 
            this.txtChairStipend.Location = new System.Drawing.Point(200, 40);
            this.txtChairStipend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChairStipend.Name = "txtChairStipend";
            this.txtChairStipend.Size = new System.Drawing.Size(148, 26);
            this.txtChairStipend.TabIndex = 11;
            this.txtChairStipend.Tag = "";
            // 
            // txtFacultyDept
            // 
            this.txtFacultyDept.Location = new System.Drawing.Point(136, 29);
            this.txtFacultyDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFacultyDept.Name = "txtFacultyDept";
            this.txtFacultyDept.Size = new System.Drawing.Size(148, 26);
            this.txtFacultyDept.TabIndex = 7;
            this.txtFacultyDept.Tag = "";
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(501, 108);
            this.btnCreateFaculty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(231, 42);
            this.btnCreateFaculty.TabIndex = 5;
            this.btnCreateFaculty.Text = "New Faculty Member";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            this.btnCreateFaculty.Click += new System.EventHandler(this.btnCreateFaculty_Click);
            // 
            // btnCreateChair
            // 
            this.btnCreateChair.Location = new System.Drawing.Point(741, 108);
            this.btnCreateChair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateChair.Name = "btnCreateChair";
            this.btnCreateChair.Size = new System.Drawing.Size(231, 42);
            this.btnCreateChair.TabIndex = 6;
            this.btnCreateChair.Text = "New Chairperson";
            this.btnCreateChair.UseVisualStyleBackColor = true;
            this.btnCreateChair.Click += new System.EventHandler(this.btnCreateChair_Click);
            // 
            // gbFormControls
            // 
            this.gbFormControls.Controls.Add(this.btnEnterName);
            this.gbFormControls.Controls.Add(this.btnDelete);
            this.gbFormControls.Controls.Add(this.btnSave);
            this.gbFormControls.Controls.Add(this.btnEdit);
            this.gbFormControls.Controls.Add(this.btnDisplay);
            this.gbFormControls.Controls.Add(this.lblEnterID);
            this.gbFormControls.Controls.Add(this.txtTUIDEnter);
            this.gbFormControls.Location = new System.Drawing.Point(24, 762);
            this.gbFormControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFormControls.Name = "gbFormControls";
            this.gbFormControls.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFormControls.Size = new System.Drawing.Size(818, 154);
            this.gbFormControls.TabIndex = 7;
            this.gbFormControls.TabStop = false;
            this.gbFormControls.Text = "Data Processing Controls";
            // 
            // btnEnterName
            // 
            this.btnEnterName.Location = new System.Drawing.Point(414, 40);
            this.btnEnterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnterName.Name = "btnEnterName";
            this.btnEnterName.Size = new System.Drawing.Size(78, 35);
            this.btnEnterName.TabIndex = 20;
            this.btnEnterName.Text = "Enter";
            this.btnEnterName.UseVisualStyleBackColor = true;
            this.btnEnterName.Click += new System.EventHandler(this.btnEnterName_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(652, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(460, 98);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Create / Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 98);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(46, 98);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(112, 35);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(45, 48);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(192, 20);
            this.lblEnterID.TabIndex = 15;
            this.lblEnterID.Text = "Please Enter Target TUID";
            // 
            // txtTUIDEnter
            // 
            this.txtTUIDEnter.Location = new System.Drawing.Point(255, 42);
            this.txtTUIDEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTUIDEnter.Name = "txtTUIDEnter";
            this.txtTUIDEnter.Size = new System.Drawing.Size(148, 26);
            this.txtTUIDEnter.TabIndex = 14;
            this.txtTUIDEnter.Tag = "";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(876, 198);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(96, 78);
            this.btnClearForm.TabIndex = 8;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(876, 871);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 969);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        public System.Windows.Forms.Label lblGradProgram;
        public System.Windows.Forms.TextBox txtGradStipend;
        public System.Windows.Forms.Label lblGradStipend;
        public System.Windows.Forms.GroupBox gbFormControls;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DateTimePicker dtBD;
        public System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnEnterName;
        public System.Windows.Forms.ComboBox cbRank;
        public System.Windows.Forms.ComboBox cbProgram;
        public System.Windows.Forms.Label lblEnterID;
        public System.Windows.Forms.TextBox txtTUIDEnter;
    }
}