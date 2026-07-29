namespace Assignment_4._2._1
{
    partial class AddStudent
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addFirstName = new TextBox();
            addLastName = new TextBox();
            addId = new TextBox();
            addGPA = new TextBox();
            cnfmAddStudent = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 181);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 10;
            label4.Text = "GPA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 113);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 147);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 79);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name:";
            // 
            // addFirstName
            // 
            addFirstName.Location = new Point(148, 76);
            addFirstName.Name = "addFirstName";
            addFirstName.Size = new Size(111, 23);
            addFirstName.TabIndex = 11;
            // 
            // addLastName
            // 
            addLastName.Location = new Point(148, 110);
            addLastName.Name = "addLastName";
            addLastName.Size = new Size(111, 23);
            addLastName.TabIndex = 12;
            // 
            // addId
            // 
            addId.Location = new Point(148, 144);
            addId.Name = "addId";
            addId.Size = new Size(111, 23);
            addId.TabIndex = 13;
            // 
            // addGPA
            // 
            addGPA.Location = new Point(148, 178);
            addGPA.Name = "addGPA";
            addGPA.Size = new Size(111, 23);
            addGPA.TabIndex = 14;
            // 
            // cnfmAddStudent
            // 
            cnfmAddStudent.BackColor = Color.LightGreen;
            cnfmAddStudent.Location = new Point(189, 245);
            cnfmAddStudent.Name = "cnfmAddStudent";
            cnfmAddStudent.Size = new Size(82, 28);
            cnfmAddStudent.TabIndex = 15;
            cnfmAddStudent.Text = "Confirm";
            cnfmAddStudent.UseVisualStyleBackColor = false;
            cnfmAddStudent.Click += cnfmAddStudent_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(61, 245);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 16;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(105, 24);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 17;
            label5.Text = "Add Student";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 323);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cnfmAddStudent);
            Controls.Add(addGPA);
            Controls.Add(addId);
            Controls.Add(addLastName);
            Controls.Add(addFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox addFirstName;
        private TextBox addLastName;
        private TextBox addId;
        private TextBox addGPA;
        private Button cnfmAddStudent;
        private Button button1;
        private Label label5;
    }
}