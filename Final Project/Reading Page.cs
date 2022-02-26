using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Reading : Form
    {
        public Reading(String url)
        {
            InitializeComponent();
            axAcroPDF1.src = url;
            this.pictureBox1.Location = new Point(this.Width - 75, 10);
            this.axAcroPDF1.Size = new System.Drawing.Size(this.Width-15, this.Height);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
