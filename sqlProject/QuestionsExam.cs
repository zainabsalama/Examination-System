using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace sqlProject
{
    public partial class QuestionsExam : Form
    {
        project_online_examinationEntities1 onlineExam = new project_online_examinationEntities1();
        int studentId;
        int courseId;
        int ExamID;
        public QuestionsExam(int studentId, int courseId)
        {
            InitializeComponent();
            this.studentId = studentId;
         
            this.courseId = courseId;

            // Retrieve a list of random questions from the database
            onlineExam.ExamGeneration(courseId, studentId, 10);
            
            ExamID = (from c in onlineExam.Exam select c.exam_id).Max();
            //MessageBox.Show(ExamID.ToString());
            var question = onlineExam.stud_exam.Where(d => d.exam_id == ExamID).Select(d => d.question_id);
            List<Questions> questionList = new List<Questions>();
            foreach (int d1 in question)
            {
                Questions question1 = onlineExam.Questions.FirstOrDefault(d => d.question_id == d1);
                questionList.Add(question1);
            }
            System.Windows.Forms.GroupBox[] groupBoxes = new System.Windows.Forms.GroupBox[]
            {
            groupBox1,groupBox2,groupBox3,groupBox4,groupBox5,groupBox6,groupBox7,groupBox8,groupBox9,
            groupBox10
            };
            var questions = questionList.ToArray();
            //MessageBox.Show(questionList.Count.ToString());
            for (int i = 0; i < 10; i++)
            {

                groupBoxes[i].Text = questions[i].question;
                choices[] choices = questions[i].choices.ToArray();
            
                    groupBoxes[i].Controls[3].Visible = false;
                    groupBoxes[i].Controls[2].Visible = false;
                    groupBoxes[i].Controls[1].Visible = false;
                    groupBoxes[i].Controls[0].Visible = false;
                
                for (int j = 0; j < choices.Length; j++)
                {
                    groupBoxes[i].Controls[j].Visible = true;
                    groupBoxes[i].Controls[j].Text = choices[j].choice_text;

                }

            }
            
        }
        public string ans1
        {
            get
            {
                string ans = string.Empty;
                if (radioButton1.Checked == true)
                {
                    ans = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    ans = radioButton2.Text;

                }
                else if (radioButton3.Checked == true)
                {
                    ans = radioButton3.Text;
                }
                else if (radioButton4.Checked == true)
                {
                    ans = radioButton4.Text;
                }
                return ans;
                
            }

            
        }
        
        public string ans2
        {
            get
            {
                string ans = string.Empty;
                if (radioButton5.Checked == true)
                {
                    ans = radioButton5.Text;
                }
                else if (radioButton6.Checked == true)
                {
                    ans = radioButton6.Text;

                }
                else if (radioButton7.Checked == true)
                {
                    ans = radioButton7.Text;
                }
                else if (radioButton8.Checked == true)
                {
                    ans = radioButton8.Text;
                }
                return ans;
            }

        }
        public string ans3
        {
            get
            {
                string ans = string.Empty;
                if (radioButton9.Checked == true)
                {
                    ans = radioButton9.Text;
                }
                else if (radioButton10.Checked == true)
                {
                    ans = radioButton10.Text;

                }
                else if (radioButton11.Checked == true)
                {
                    ans = radioButton11.Text;
                }
                else if (radioButton12.Checked == true)
                {
                    ans = radioButton12.Text;
                }
                return ans;
            }
        }
        public string ans4
        {
            get
            {
                string ans = string.Empty;
                if (radioButton13.Checked == true)
                {
                    ans = radioButton13.Text;
                }
                else if (radioButton14.Checked == true)
                {
                    ans = radioButton14.Text;

                }
                else if (radioButton15.Checked == true)
                {
                    ans = radioButton15.Text;
                }
                else if (radioButton16.Checked == true)
                {
                    ans = radioButton16.Text;
                }
                return ans;
            }
        }
        public string ans5
        {
            get
            {
                string ans = string.Empty;
                if (radioButton17.Checked == true)
                {
                    ans = radioButton17.Text;
                }
                else if (radioButton18.Checked == true)
                {
                    ans = radioButton18.Text;

                }
                else if (radioButton19.Checked == true)
                {
                    ans = radioButton19.Text;
                }
                else if (radioButton20.Checked == true)
                {
                    ans = radioButton20.Text;
                }
                return ans;
            }

        }
        public string ans6
        {
            get
            {
                string ans = string.Empty;
                if (radioButton21.Checked == true)
                {
                    ans = radioButton21.Text;
                }
                else if (radioButton22.Checked == true)
                {
                    ans = radioButton22.Text;

                }
                else if (radioButton23.Checked == true)
                {
                    ans = radioButton23.Text;
                }
                else if (radioButton24.Checked == true)
                {
                    ans = radioButton24.Text;
                }
                return ans;
            }

        }
        public string ans7
        {
            get
            {
                string ans = string.Empty;
                if (radioButton25.Checked == true)
                {
                    ans = radioButton25.Text;
                }
                else if (radioButton26.Checked == true)
                {
                    ans = radioButton26.Text;

                }
                else if (radioButton27.Checked == true)
                {
                    ans = radioButton27.Text;
                }
                else if (radioButton28.Checked == true)
                {
                    ans = radioButton28.Text;
                }
                return ans;
            }

        }
        public string ans8
        {
            get
            {
                string ans = string.Empty;
                if (radioButton29.Checked == true)
                {
                    ans = radioButton29.Text;
                }
                else if (radioButton30.Checked == true)
                {
                    ans = radioButton30.Text;

                }
                else if (radioButton31.Checked == true)
                {
                    ans = radioButton31.Text;
                }
                else if (radioButton32.Checked == true)
                {
                    ans = radioButton32.Text;
                }
                return ans;
            }

        }
        public string ans9
        {
            get
            {
                string ans = string.Empty;
                if (radioButton33.Checked == true)
                {
                    ans = radioButton33.Text;
                }
                else if (radioButton34.Checked == true)
                {
                    ans = radioButton34.Text;

                }
                else if (radioButton35.Checked == true)
                {
                    ans = radioButton35.Text;
                }
                else if (radioButton36.Checked == true)
                {
                    ans = radioButton36.Text;
                }
                return ans;
            }

        }
        public string ans10
        {
            get
            {
                string ans = string.Empty;
                if (radioButton37.Checked == true)
                {
                    ans = radioButton37.Text;
                }
                else if (radioButton38.Checked == true)
                {
                    ans = radioButton38.Text;

                }
                else if (radioButton39.Checked == true)
                {
                    ans = radioButton39.Text;
                }
                else if (radioButton40.Checked == true)
                {
                    ans = radioButton40.Text;
                }
                return ans;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QuestionsExam_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            string[] Answers = { ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10 };
            stud_course stud_Course;
            
                onlineExam.ExamAnswers(ExamID, studentId, Answers[0], Answers[1], Answers[2], Answers[3], Answers[4], Answers[5], Answers[6], Answers[7], Answers[8], Answers[9]);
                onlineExam.SaveChanges();


            try
            {
                onlineExam.Exam_Correction(ExamID, studentId);
                onlineExam.SaveChanges();
            }
            catch (Exception ex)
            {


                stud_Course = onlineExam.stud_course.FirstOrDefault(d => d.course_id == courseId && d.stud_id == studentId);
                MessageBox.Show("Your Grade is " + stud_Course.student_grade + " %");
            } 
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
