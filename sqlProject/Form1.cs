using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlProject
{
    public partial class Form1 : Form
    {
        project_online_examinationEntities1 onlineExam = new project_online_examinationEntities1();
        courses cs ; 
        public Form1()
        {
            InitializeComponent();
            var courses= from c in onlineExam.courses
                              orderby c.course_name
                              select c;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = courses.ToList();
            comboBox1.DisplayMember = "course_name";
            comboBox1.ValueMember = "course_id";
            comboBox1.Refresh();
            


        }
        private void signUp_btn_Click(object sender, EventArgs e)
        {
            signUp up = new signUp();
            up.Show();
            
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            cs = onlineExam.courses.FirstOrDefault(c => c.course_name == comboBox1.Text);
            foreach (var s in onlineExam.student)
            {
                if (s.first_name == signIn_name.Text && s.stud_id == int.Parse(signIn_id.Text))
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                MessageBox.Show("You are Signed in successfully");
                

                QuestionsExam questions = new QuestionsExam(int.Parse(signIn_id.Text),cs.course_id);

                questions.Show();
                
            }
            else
            {
                MessageBox.Show("Name or password is incorrect or empty");
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
