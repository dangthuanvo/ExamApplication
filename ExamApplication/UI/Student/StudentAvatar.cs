using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class StudentAvatar : Form
    {
        public StudentAvatar()
        {
            InitializeComponent();
        }

        private void StudentAvatar_Load(object sender, EventArgs e)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData("https://cdn.dribbble.com/users/957210/screenshots/2475142/untitled-2.gif");
                    Stream imageSteam = new MemoryStream(imageBytes);
                    background.Image = System.Drawing.Image.FromStream(imageSteam);
                    background.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions like invalid URL or network issues
                MessageBox.Show("Error downloading image: " + ex.Message);
            }
        }
    }
}
