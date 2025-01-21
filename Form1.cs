namespace Lab_Activity_Oop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string gender = "N/A", age = "N/A", status = "N/A", income = "N/A", job = "N/A", education = "N/A";

            if (Male.Checked)
            { gender = Male.Text; }
            else if (Female.Checked)
            { gender = Female.Text; }
            else if (NoSayGender.Checked)
            { gender = NoSayGender.Text; }
            else if (NonBinary.Checked)
            { gender = NonBinary.Text; }
            if (Age1.Checked)
            { age = Age1.Text; }
            else if (Age2.Checked)
            { age = Age2.Text; }
            else if (Age3.Checked)
            { age = Age3.Text; }
            else if (Age4.Checked)
            { age = Age4.Text; }
            else if (Age5.Checked)
            { age = Age5.Text; }
            else if (Age6.Checked)
            { age = Age6.Text; }
            else if (Age7.Checked)
            { age = Age7.Text; }
            if (Divorced.Checked)
            { status = Divorced.Text; }
            else if (Married.Checked)
            { status = Married.Text; }
            else if (Single.Checked)
            { status = Single.Text; }
            else if (Widowed.Checked)
            { status = Widowed.Text; }
            else if (NoSayStatus.Checked)
            { status = NoSayStatus.Text; }
            if (Income1.Checked)
            { income = Income1.Text; }
            else if (Income2.Checked)
            { income = Income2.Text; }
            else if (Income3.Checked)
            { income = Income3.Text; }
            else if (Income4.Checked)
            { income = Income4.Text; }
            else if (Income5.Checked)
            { income = Income5.Text; }
            else if (Income6.Checked)
            { income = Income6.Text; }
            else if (Income7.Checked)
            { income = Income7.Text; }
            if (Job1.Checked)
            { job = Job1.Text; }
            else if (Job2.Checked)
            { job = Job2.Text; }
            else if (Job3.Checked)
            { job = Job3.Text; }
            else if (Job4.Checked)
            { job = Job4.Text; }
            else if (Job5.Checked)
            { job = Job5.Text; }
            else if (Job6.Checked)
            { job = Job6.Text; }
            else if (Job7.Checked)
            { job = Job7.Text; }
            else if (Job8.Checked)
            { job = Job8.Text; }
            if (School1.Checked)
            { education = School1.Text; }
            else if (School2.Checked)
            { education = School2.Text; }
            else if (School3.Checked)
            { education = School3.Text; }
            else if (School4.Checked)
            { education = School4.Text; }
            else if (School5.Checked)
            { education = School5.Text; }
            else if (School6.Checked)
            { education = School6.Text; }
            else if (School7.Checked)
            { education = School7.Text; }
            else if (School8.Checked)
            { education = School8.Text; }
            else if (School9.Checked)
            { education = School9.Text; }
            // new comment
            MessageBox.Show($"Gender : {gender} \nAge : {age}\nMarital Status : {status}\nIncome Range : {income}\nEmployment Status : {job}\nLevel of Education : {education}");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
