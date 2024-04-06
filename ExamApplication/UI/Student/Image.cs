using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class Image : Form
    {
        public Image(string imageurl)
        {
            InitializeComponent();
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(imageurl);
                    Stream imageSteam = new MemoryStream(imageBytes);
                    pictureBox1.Image = System.Drawing.Image.FromStream(imageSteam);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions like invalid URL or network issues
                MessageBox.Show("Error downloading image: " + ex.Message);
            }
        }

        private void Image_Load(object sender, System.EventArgs e)
        {
        }
    }
}
