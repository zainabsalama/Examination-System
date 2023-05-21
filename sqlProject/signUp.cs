using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlProject
{
    public partial class signUp : Form
    {
        project_online_examinationEntities1 onlineExam = new project_online_examinationEntities1();
        public signUp()
        {
            InitializeComponent();
            var departments = from d in onlineExam.Department
                              orderby d.dept_name
                              select d;
            signUp_dept.DropDownStyle = ComboBoxStyle.DropDownList;
            signUp_dept.DataSource = departments.ToList();
            signUp_dept.DisplayMember = "dept_name";
            signUp_dept.ValueMember = "dept_id";
            signUp_dept.Refresh();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int GetNextStudentId()
        {
            // Retrieve the highest existing student ID value from the database
            int highestId = onlineExam.student.Max(s => s.stud_id);

            // Add 1 to the highest ID value to generate the next ID
            return highestId + 1;
        }
        private void signUp_btn_Click(object sender, EventArgs e)
        {

            var phoneNum = int.Parse(signUp_phone.Text);
            var student = new student
            {
            stud_id=int.Parse(signUp_id.Text),
            first_name = signUp_fname.Text,
            last_name = signUp_lname.Text,
            password= signUp_password.Text,
            phone=phoneNum,
            };
            onlineExam.student.Add(student);
            try
            {
                onlineExam.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                // Log or display the inner exception here
            }
            
            if (signUp_fname.Text!="" && signUp_lname.Text!="" &&signUp_password.Text!=""&& signUp_phone.Text!="" && signUp_id.Text.ToString() != "")
            {
                MessageBox.Show("You are Signed up successfuly");
            }
            else
            {
                MessageBox.Show("there is filed is incorrect or empty");
            }
            this.Close();
        }

        private void signUp_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
