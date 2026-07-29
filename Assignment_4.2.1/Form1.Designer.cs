namespace Assignment_4._2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPopupBtn = new Button();
            listBoxStudents = new ListBox();
            lblFN = new Label();
            lblId = new Label();
            lblLn = new Label();
            gpa = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblStudentId = new Label();
            lblGPA = new Label();
            addStdBtn = new Button();
            delStudentBtn = new Button();
            listHeader = new Label();
            studentDataHeader = new Label();
            starPupilBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // LoginPopupBtn
            // 
            LoginPopupBtn.BackColor = Color.Thistle;
            LoginPopupBtn.Location = new Point(664, 12);
            LoginPopupBtn.Name = "LoginPopupBtn";
            LoginPopupBtn.Size = new Size(124, 30);
            LoginPopupBtn.TabIndex = 1;
            LoginPopupBtn.Text = "Login";
            LoginPopupBtn.UseVisualStyleBackColor = false;
            LoginPopupBtn.Click += LoginPopUpBtn_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(93, 119);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(251, 199);
            listBoxStudents.TabIndex = 2;
            listBoxStudents.Visible = false;
            listBoxStudents.SelectedIndexChanged += listBoxStudents_SelectedIndexChanged;
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFN.Location = new Point(478, 162);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(70, 15);
            lblFN.TabIndex = 3;
            lblFN.Text = "First Name:";
            lblFN.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(480, 230);
            lblId.Name = "lblId";
            lblId.Size = new Size(71, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Student ID:";
            lblId.Visible = false;
            // 
            // lblLn
            // 
            lblLn.AutoSize = true;
            lblLn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLn.Location = new Point(478, 196);
            lblLn.Name = "lblLn";
            lblLn.Size = new Size(68, 15);
            lblLn.TabIndex = 5;
            lblLn.Text = "Last Name:";
            lblLn.Visible = false;
            // 
            // gpa
            // 
            gpa.AutoSize = true;
            gpa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gpa.Location = new Point(512, 264);
            gpa.Name = "gpa";
            gpa.Size = new Size(33, 15);
            gpa.TabIndex = 6;
            gpa.Text = "GPA:";
            gpa.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(568, 162);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(60, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(568, 196);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 8;
            lblLastName.Visible = false;
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new Point(568, 230);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(60, 15);
            lblStudentId.TabIndex = 9;
            lblStudentId.Visible = false;
            // 
            // lblGPA
            // 
            lblGPA.Location = new Point(568, 264);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(60, 15);
            lblGPA.TabIndex = 10;
            lblGPA.Visible = false;
            // 
            // addStdBtn
            // 
            addStdBtn.BackColor = Color.Turquoise;
            addStdBtn.Location = new Point(230, 352);
            addStdBtn.Name = "addStdBtn";
            addStdBtn.Size = new Size(114, 24);
            addStdBtn.TabIndex = 11;
            addStdBtn.Text = "Add Student";
            addStdBtn.UseVisualStyleBackColor = false;
            addStdBtn.Visible = false;
            addStdBtn.Click += addStdBtn_Click;
            // 
            // delStudentBtn
            // 
            delStudentBtn.BackColor = Color.LightCoral;
            delStudentBtn.Location = new Point(93, 352);
            delStudentBtn.Name = "delStudentBtn";
            delStudentBtn.Size = new Size(114, 24);
            delStudentBtn.TabIndex = 12;
            delStudentBtn.Text = "Delete Student";
            delStudentBtn.UseVisualStyleBackColor = false;
            delStudentBtn.Visible = false;
            delStudentBtn.Click += delStudentBtn_Click;
            // 
            // listHeader
            // 
            listHeader.AutoSize = true;
            listHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            listHeader.Location = new Point(172, 73);
            listHeader.Name = "listHeader";
            listHeader.Size = new Size(95, 28);
            listHeader.TabIndex = 13;
            listHeader.Text = "Students";
            listHeader.Visible = false;
            // 
            // studentDataHeader
            // 
            studentDataHeader.AutoSize = true;
            studentDataHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            studentDataHeader.Location = new Point(458, 73);
            studentDataHeader.Name = "studentDataHeader";
            studentDataHeader.Size = new Size(205, 28);
            studentDataHeader.TabIndex = 14;
            studentDataHeader.Text = "Student Information";
            studentDataHeader.Visible = false;
            // 
            // starPupilBtn
            // 
            starPupilBtn.BackColor = Color.Gold;
            starPupilBtn.Location = new Point(512, 352);
            starPupilBtn.Name = "starPupilBtn";
            starPupilBtn.Size = new Size(114, 24);
            starPupilBtn.TabIndex = 15;
            starPupilBtn.Text = "Star Pupil";
            starPupilBtn.UseVisualStyleBackColor = false;
            starPupilBtn.Visible = false;
            starPupilBtn.Click += starPupilBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Gray;
            exitBtn.Location = new Point(12, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(124, 30);
            exitBtn.TabIndex = 16;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Visible = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(starPupilBtn);
            Controls.Add(studentDataHeader);
            Controls.Add(listHeader);
            Controls.Add(delStudentBtn);
            Controls.Add(addStdBtn);
            Controls.Add(lblGPA);
            Controls.Add(lblStudentId);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(gpa);
            Controls.Add(lblLn);
            Controls.Add(lblId);
            Controls.Add(lblFN);
            Controls.Add(listBoxStudents);
            Controls.Add(LoginPopupBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginPopupBtn;
        private ListBox listBoxStudents;
        private Label lblFN;
        private Label lblId;
        private Label lblLn;
        private Label gpa;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblStudentId;
        private Label lblGPA;
        private Button addStdBtn;
        private Button delStudentBtn;
        private Label listHeader;
        private Label studentDataHeader;
        private Button starPupilBtn;
        private Button exitBtn;
    }
}
