using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Main_ : Form
    {
        public Main_()
        {
            InitializeComponent();
            this.pictureBox1.ImageLocation = "..\\..\\..\\resources\\library.jpg";
        }
        private void Main__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Width < 450)
            {
                Random random = new Random();
                label1.Text = ("working on " + files[random.Next(0, files.Length)]); 
            }
            else
            {
                label1.Text = "Please Wait application loading .";
            }
            if(pictureBox1.Width > 600 && pictureBox1.Height > 320)
            {
                timer_Stop();
            }
            else
            {
                this.pictureBox1.Size = new System.Drawing.Size(this.pictureBox1.Size.Width + 11, this.pictureBox1.Size.Height + 6);
            }
        }
        private void timer_Stop()
        {
            timer1.Stop();
            this.Hide();
            (new HomePageForm()).Show();
        }
        String[] files = {"login.cs","resources/image1.png", "resources/image2.png" , "resources/image3.png",
                          "bin/res","config.xml","log.xml","src/loader"};
    }
}
