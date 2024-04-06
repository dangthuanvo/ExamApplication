using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class AdminAvatar : Form
    {
        public AdminAvatar()
        {
            InitializeComponent();
        }

        private void AdminAvatar_Load(object sender, EventArgs e)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData("https://cdn.pixabay.com/animation/2023/06/13/15/13/15-13-46-857_512.gif");
                    Stream imageSteam = new MemoryStream(imageBytes);
                    background.Image = Image.FromStream(imageSteam);
                    background.SizeMode = PictureBoxSizeMode.CenterImage;
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
