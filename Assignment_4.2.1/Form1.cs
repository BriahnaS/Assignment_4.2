using Assignment_4._2._1.Services;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_4._2._1
{
    public partial class Form1 : Form
    {
        // Declared Binding list and one instance of teacher class 
        BindingList<Student> students = new BindingList<Student>();
        private Teacher teacher1 = new Teacher() {FirstName = "Patsy", LastName = "Stores", Password = "admin", UserName = "teacher"};

        public Form1()
        {
            InitializeComponent();

            listBoxStudents.DataSource = students;
            listBoxStudents.DisplayMember = "FullName";
        }


        private void LoginPopUpBtn_Click(object sender, EventArgs e)
        {
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    string username = login.Username;
                    string password = login.Password;

                    if (teacher1.VerifyPassword(password))
                    {
                        ShowData();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password.");
                    }
                }
            }
        }
        private void addStdBtn_Click(object sender, EventArgs e)
        {
            using (var addStudent = new AddStudent())
            {
                if (addStudent.ShowDialog() == DialogResult.OK)
                {
                    students.Add(addStudent.NewStudent);

                    // Resorting and rebinding the student list
                    var sorted = students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
                    students = new BindingList<Student>(sorted);
                    listBoxStudents.DataSource = students;
                }
            }
        }
        private void delStudentBtn_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
                return;

            Student selected = (Student)listBoxStudents.SelectedItem;

            students.Remove(selected);

            // Resorting and rebinding the student list
            var sorted = students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
            students = new BindingList<Student>(sorted);
            listBoxStudents.DataSource = students;
        }
        private void starPupilBtn_Click(object sender, EventArgs e)
        {
            Student top = StarPupil();
            if (top != null)
            {
                ShowStudent(top);
                MessageBox.Show("Star pupil saved to file.");
            }
        }

        // Method for selecting star pupil
        public Student StarPupil()
        {
            Student highestGPA = null;

            foreach (Student student in students)
            {
                if (highestGPA == null || student.GPA > highestGPA.GPA)
                {
                    highestGPA = student;
                }
            }

            if (highestGPA == null)
                return null;

            try
            {
                using (StreamWriter writeStarPupil = new StreamWriter("C:\\StarPupilData.txt"))
                {
                    writeStarPupil.WriteLine($"First Name: {highestGPA.FirstName}");
                    writeStarPupil.WriteLine($"Last Name: {highestGPA.LastName}");
                    writeStarPupil.WriteLine($"Student ID: {highestGPA.StudentId}");
                    writeStarPupil.WriteLine($"GPA: {highestGPA.GPA}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing file: {ex.Message}");
            }

            return highestGPA;

        }
        // Methods to show hidden data -------
        public void ShowData()
        {
            // dataGridView1.Visible = true;
            listBoxStudents.Visible = true;
            lblFN.Visible = true;
            lblId.Visible = true;
            lblLn.Visible = true;
            gpa.Visible = true;
            lblFirstName.Visible = true;
            lblGPA.Visible = true;
            lblLastName.Visible = true;
            lblStudentId.Visible = true;
            addStdBtn.Visible = true;
            delStudentBtn.Visible = true;
            studentDataHeader.Visible = true;
            listHeader.Visible = true;
            starPupilBtn.Visible = true;
            exitBtn.Visible = true;
            welcomeBtn.Visible = true;
            welcomeBtn.Text = $"Welcome {teacher1.FirstName} {teacher1.LastName}";
        }
        public void ShowStudent(Student s)
        {
            lblFirstName.Text = s.FirstName;
            lblLastName.Text = s.LastName;
            lblStudentId.Text = s.StudentId;
            lblGPA.Text = s.GPA.ToString();
        }

        // Select a student from the listbox and show their information on the side
        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selected = (Student)listBoxStudents.SelectedItem;
            ShowStudent(selected);
        }

        // Exit button code
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public enum Role { None, Teacher, Student };

    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        protected string _password = Guid.NewGuid().ToString();
        public string Password
        {
            set
            {
                _password = value;
            }
        }
        public bool VerifyPassword(string pass)
        {
            return (String.Compare(pass, _password) == 0);
        }
    }

    public class Teacher : User
    {
        // Constructor
        public Teacher (string userName, string password, string firstName, string lastName)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        // Default constructor
        public Teacher()
        {
            UserName = String.Empty;
            Password = Guid.NewGuid().ToString();
            FirstName = String.Empty;
            LastName= String.Empty;
        }
    }

    public class Student : User
    {
        private double _gpa;
        public string StudentId { get; set; }
        public double GPA
        {
            get => _gpa;
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    MessageBox.Show("Please enter a valid GPA between 0.0 and 4.0.");
                }
                _gpa = Math.Clamp(value, 0.0, 4.0);
            }
        }
        public string FullName => $"{LastName}, {FirstName}";

    }

}
