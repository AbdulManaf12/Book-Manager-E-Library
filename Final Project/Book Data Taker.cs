using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        private Book book;
        private bool isCorrectData = false;

        public Form1(Book book, bool isEditData)
        {
            InitializeComponent();
            if (!isEditData)
            {
                this.book = book;
            }
            else
            {
                this.book = book;
                this.pictureBox1.ImageLocation = book.imagelocation;
                this.textBox1.Text = book.Name;
                this.textBox2.Text = book.Author;
                this.textBox3.Text = book.Edition;
                this.textBox4.Text = book.year + "";
                this.textBox5.Text = book.Description;
                this.button3.Text = book.url;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*.png)|*.png; |JPG (*.jpg)|*.jpg;";
            ofd.Title = "Select Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.book.imagelocation = ofd.FileName;
                this.pictureBox1.ImageLocation = ofd.FileName;
                this.label1.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(this.book.imagelocation == null)
            {
                this.book.imagelocation = @"..\..\..\resources\defaultbook.jpg";
            }
            if(this.textBox1.Text == null && Validate(textBox1.Text))
            {
                MessageBox.Show("Enter Book Name","Book Name");
                return;
            }
            if (this.textBox2.Text == null && Validate(textBox2.Text))
            {
                MessageBox.Show("Enter Book Author", "Book Author");
                return;
            }
            if (this.textBox3.Text == null && Validate(textBox3.Text))
            {
                MessageBox.Show("Enter Book Edition", "Book Editon");
                return;
            }
            if (this.textBox4.Text == null && Validate(textBox4.Text))
            {
                MessageBox.Show("Enter Book Year", "Book Year");
                return;
            }
            if (this.book.url == null && Validate(textBox5.Text))
            {
                MessageBox.Show("Select Book path", "Book Location");
                return;
            }
            this.book.Name = this.textBox1.Text;
            this.book.Author = this.textBox2.Text;
            this.book.Edition = this.textBox3.Text;
            try { this.book.year = int.Parse(this.textBox4.Text); }
            catch(Exception ex) { 
                ex.ToString();
                this.book.year = 0;
            }
            this.book.Description = this.textBox5.Text;
            isCorrectData = true;
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF (*.pdf)|*.pdf;";
            ofd.Title = "Select Document";
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                book.url = ofd.FileName;
                this.button3.Text = ofd.FileName;
            }
        }
        private bool Validate(String str)
        {
            return !((str.Replace('\0', ' ').Length == 0));
        }
        public bool BackInfo()
        {
            this.ShowDialog();
            return isCorrectData;
        }
    }
}