using ExamApplication.DTO;
using ExamApplication.Sẹrvice;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class Exam : Form
    {
        int timeRemaining = 30 * 60;
        int currentquestion = 0;
        int totalquestion = 0;
        decimal score = 0;
        string selected_answer = null;
        Image questionimage;
        List<QuestionDTO> questions = new List<QuestionDTO>();
        List<QuestionExampleDTO> questionexamples = new List<QuestionExampleDTO>();
        QuestionService questionservice = new QuestionService();
        QuestionExampleService questionexampleservice = new QuestionExampleService();
        HistoryService historyService = new HistoryService();
        public Exam()
        {
            InitializeComponent();
            timer1.Start();
            if (all.isExample)
            {
                infoStudent.Text = "Sinh viên đang làm bài thi: " + "thi thử";
                questionexamples = questionexampleservice.GetAll();
                LoadQuestionExample();
            }
            else
            {
                infoStudent.Text = "Sinh viên đang làm bài thi: " + all.currentStudentId;
                questions = questionservice.GetAll();
                LoadQuestion();
                historyService.Insert(new HistoryDTO()
                {
                    studentname = all.currentStudentName,
                    studentid = all.currentStudentId,
                    time = DateTime.Now,
                    timetake = 0,
                    score = 0,
                });
            }
        }
        private void UpdateResult(int time, decimal score)
        {
            historyService.Update(all.currentStudentId, score, time);
        }
        private void CallImage(string imageurl)
        {
            questionimage = new Image(imageurl);
            questionimage.Show();
            questionimage.WindowState = FormWindowState.Normal;
            questionimage.BringToFront();
            questionimage.TopMost = true;
            questionimage.Focus();
            questionimage.Location = new Point(questionimage.Location.X, questionimage.Location.Y - 400);
        }
        private void LoadQuestion()
        {
            question.Text = questions[currentquestion].question;
            A.Text = questions[currentquestion].A;
            B.Text = questions[currentquestion].B;
            C.Text = questions[currentquestion].C;
            D.Text = questions[currentquestion].D;
            selected_answer = null;
            totalquestion = questions.Count;
            ResetAnswer();
            ShowHiddenAnswer();
            if (A.Text == null)
            {
                A.Visible = false;
            }
            if (B.Text == null)
            {
                B.Visible = false;
            }
            if (C.Text == null)
            {
                C.Visible = false;
            }
            if (D.Text == null)
            {
                D.Visible = false;
            }
            if (!string.IsNullOrEmpty(questions[currentquestion].imageurl))
            {
                CallImage(questions[currentquestion].imageurl);
            }
        }
        private void LoadQuestionExample()
        {
            question.Text = questionexamples[currentquestion].question;
            A.Text = questionexamples[currentquestion].A;
            B.Text = questionexamples[currentquestion].B;
            C.Text = questionexamples[currentquestion].C;
            D.Text = questionexamples[currentquestion].D;
            selected_answer = null;
            totalquestion = questionexamples.Count;
            ResetAnswer();
            ShowHiddenAnswer();
            if (A.Text == null)
            {
                A.Visible = false;
            }
            if (B.Text == null)
            {
                B.Visible = false;
            }
            if (string.IsNullOrEmpty(C.Text))
            {
                C.Visible = false;
            }
            if (string.IsNullOrEmpty(C.Text))
            {
                D.Visible = false;
            }
            if (!string.IsNullOrEmpty(questionexamples[currentquestion].imageurl))
            {
                CallImage(questionexamples[currentquestion].imageurl);
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                int minutes = timeRemaining / 60;
                int seconds = timeRemaining % 60;
                string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
                time.Text = timeString;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian làm bài điểm của bạn là " + score);
                if (!all.isExample)
                {
                    historyService.Insert(new HistoryDTO()
                    {
                        studentname = all.currentStudentName,
                        studentid = all.currentStudentId,
                        score = score,
                        time = all.currenttime,
                        timetake = 1800 - timeRemaining,
                    });
                }
            }
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            if (selected_answer == null)
            {
                MessageBox.Show("Vui lòng chọn 1 đáp án");
            }
            else
            {
                if (all.isExample)
                {
                    if (selected_answer == questionexamples[currentquestion].correct_answer)
                    {
                        score += (decimal)(10.0 / questionexamples.Count);
                    }
                }
                else
                {
                    if (selected_answer == questions[currentquestion].correct_answer)
                    {
                        score += (decimal)0.2;
                        UpdateResult(1800 - timeRemaining, score);
                    }
                }
                currentquestion++;
                if (currentquestion == totalquestion)
                {
                    timer1.Stop();
                    MessageBox.Show("Điểm bài thi của bạn là " + Math.Round(score, 2).ToString());
                    if (!all.isExample)
                    {
                        UpdateResult(1800 - timeRemaining, score);
                    }
                    (this.ParentForm as Student).loadform(new StudentAvatar(), "SINH VIÊN");
                }
                else
                {
                    questionimage.Hide();
                    questionimage.Close();
                    if (all.isExample)
                    {
                        LoadQuestionExample();
                    }
                    else
                    {
                        LoadQuestion();
                    }
                }

            }
        }
        private void ResetAnswer()
        {
            A.FillColor = Color.FromArgb(94, 148, 255);
            B.FillColor = Color.FromArgb(94, 148, 255);
            C.FillColor = Color.FromArgb(94, 148, 255);
            D.FillColor = Color.FromArgb(94, 148, 255);
        }
        private void ShowHiddenAnswer()
        {
            A.Visible = true;
            B.Visible = true;
            C.Visible = true;
            D.Visible = true;
        }
        private void A_Click(object sender, System.EventArgs e)
        {
            selected_answer = "A";
            ResetAnswer();
            A.FillColor = Color.Blue;
        }

        private void B_Click(object sender, System.EventArgs e)
        {
            selected_answer = "B";
            ResetAnswer();
            B.FillColor = Color.Blue;
        }

        private void C_Click(object sender, System.EventArgs e)
        {
            selected_answer = "C";
            ResetAnswer();
            C.FillColor = Color.Blue;

        }

        private void D_Click(object sender, System.EventArgs e)
        {
            selected_answer = "D";
            ResetAnswer();
            D.FillColor = Color.Blue;
        }
    }
}
