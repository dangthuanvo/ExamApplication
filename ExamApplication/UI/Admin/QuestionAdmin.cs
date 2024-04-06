using ExamApplication.DTO;
using ExamApplication.Sẹrvice;
using System;
using System.Net;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class QuestionAdmin : Form
    {
        QuestionService questionservice = new QuestionService();
        private int currentid;
        public QuestionAdmin()
        {
            InitializeComponent();
            DelButton.Visible = false;
            flowLoad();
        }
        private void flowLoad()
        {
            flowQuestion.Controls.Clear();
            if (questionservice.GetAll().Count > 0)
            {
                foreach (var question in questionservice.GetAll())
                {
                    var button = new Guna.UI2.WinForms.Guna2Button();
                    button.Width = 120;
                    button.Height = 30;
                    button.Text = question.question;
                    button.Click += Button_Click;
                    flowQuestion.Controls.Add(button);
                }
            }
            question.Text = null;
            A.Text = null;
            B.Text = null;
            C.Text = null;
            D.Text = null;
            correctanswer.Text = null;
            isimportantcheck.Checked = false;
            DelButton.Visible = false;
            imageurl.Text = null;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var a = sender as Guna.UI2.WinForms.Guna2Button;
            var selectedquestion = questionservice.GetByName(a.Text);
            //var lecture = db.Lectures.FirstOrDefault(l => l.name == a.Text);
            question.Text = selectedquestion.question;
            A.Text = selectedquestion.A;
            B.Text = selectedquestion.B;
            C.Text = selectedquestion.C;
            D.Text = selectedquestion.D;
            correctanswer.Text = selectedquestion.correct_answer;
            isimportantcheck.Checked = selectedquestion.isimportant;
            DelButton.Visible = true;
            currentid = selectedquestion.id;
            imageurl.Text = selectedquestion.imageurl;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (question.Text == null || A.Text == null || B.Text == null || C.Text == null || D.Text == null || correctanswer.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin câu hỏi");
            }
            else
            {
                if (DelButton.Visible == false)
                {
                    if (!string.IsNullOrEmpty(imageurl.Text))
                    {
                        if (IsUrlDownloadable(imageurl.Text))
                        {
                            QuestionDTO entity = new QuestionDTO()
                            {
                                A = A.Text,
                                B = B.Text,
                                C = C.Text,
                                D = D.Text,
                                question = question.Text,
                                correct_answer = correctanswer.Text,
                                isimportant = isimportantcheck.Checked,
                                imageurl = imageurl.Text,
                            };
                            questionservice.Insert(entity);
                            MessageBox.Show("Lưu thành công");
                            flowLoad();
                        }
                        else
                        {
                            MessageBox.Show("Đường link hình ảnh không hợp lệ");
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(imageurl.Text))
                    {
                        if (IsUrlDownloadable(imageurl.Text))
                        {
                            QuestionDTO entity = new QuestionDTO()
                            {
                                A = A.Text,
                                B = B.Text,
                                C = C.Text,
                                D = D.Text,
                                question = question.Text,
                                correct_answer = correctanswer.Text,
                                isimportant = isimportantcheck.Checked,
                                imageurl = imageurl.Text,
                            };
                            questionservice.Update(currentid, entity);
                            MessageBox.Show("Lưu thành công");
                            flowLoad();
                        }
                        else
                        {
                            MessageBox.Show("Đường link hình ảnh không hợp lệ");
                        }
                    }
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            questionservice.DeleteByName(question.Text);
            MessageBox.Show("Xoá thành công");
            flowLoad();
        }
        private bool IsUrlDownloadable(string url)
        {
            WebClient webClient = new WebClient();

            try
            {
                byte[] imageBytes = webClient.DownloadData(url);
                // Image downloaded successfully, so return true
                return true;
            }
            catch (WebException ex)
            {
                if (ex.Response != null && ex.Response is HttpWebResponse response)
                {
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        // Image not found (404)
                        return false;
                    }
                    // Handle other HTTP status codes here if needed
                }
                // Handle other exceptions
            }
            catch (Exception)
            {
                // Handle general exceptions
            }

            // If the function reaches here, it means the download failed
            return false;
        }
    }
}
