namespace wee5
{
    public partial class lblSemester : Form
    {
        public lblSemester()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { }
            private void btnCalculate
            (object sender, EventArgs e)
        {
            string name = txtName.Text;
            double mark;

            if (name == "" || txtName.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!double.TryParse(txtStudentId.Text, out mark))
            {
                MessageBox.Show("Please enter a valid mark!");
                return;
            }

            if (mark < 0 || mark > 100)
            {
                MessageBox.Show("Mark must be between 0 and 100!");
                return;
            }

            string grade;

            if (mark >= 90)
                grade = "A";
            else if (mark >= 80)
                grade = "B";
            else if (mark >= 70)
                grade = "C";
            else if (mark >= 60)
                grade = "D";
            else
                grade = "F";

            lblName.Text = "Student: " + name +
                             "\nGrade: " + grade;
        }
    }
    }


