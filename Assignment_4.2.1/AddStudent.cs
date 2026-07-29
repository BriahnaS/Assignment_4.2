using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4._2._1
{
    public partial class AddStudent : Form
    {
        public Student NewStudent { get; private set; }

        public AddStudent()
        {
            InitializeComponent();
            this.AcceptButton = cnfmAddStudent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnfmAddStudent_Click(object sender, EventArgs e)
        {
            NewStudent = new Student()
            {
                FirstName = addFirstName.Text,
                LastName = addLastName.Text,
                StudentId = addId.Text,
                GPA = Convert.ToDouble(addGPA.Text),
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
