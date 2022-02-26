using System.Windows.Forms;

namespace Final_Project
{
    public class BookPanel : Panel
    {
        public BookPanel(Book b, HomePageForm home, int y)
        {
            this.b = b;
            this.home = home;

            this.book_option = new System.Windows.Forms.ComboBox();
            this.book_description = new System.Windows.Forms.TextBox();
            this.book_year = new System.Windows.Forms.Label();
            this.book_edition = new System.Windows.Forms.Label();
            this.book_author = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.Label();
            this.book_pic = new System.Windows.Forms.PictureBox();
            // 
            // BookPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.book_option);
            this.Controls.Add(this.book_description);
            this.Controls.Add(this.book_year);
            this.Controls.Add(this.book_edition);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.book_pic);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(3, y+25);
            this.Name = "BookPanel";
            this.Size = new System.Drawing.Size(825, 150);
            this.TabIndex = 0;
            // 
            // book_option
            // 
            this.book_option.AllowDrop = true;
            this.book_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.book_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.book_option.DropDownWidth = 60;
            this.book_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_option.ForeColor = System.Drawing.Color.White;
            this.book_option.FormattingEnabled = true;
            this.book_option.Items.AddRange(new object[] {
            "Select","Open",
            "Edit",
            "Delete"});
            this.book_option.SelectedIndex = 0;
            this.book_option.Location = new System.Drawing.Point(690, 100);
            this.book_option.Name = "book_option";
            this.book_option.Size = new System.Drawing.Size(80, 28);
            this.book_option.TabIndex = 6;
            this.book_option.SelectedIndexChanged += new System.EventHandler(this.book_option_SelectedIndexChanged);
            // 
            // book_description
            // 
            this.book_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.book_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_description.Enabled = false;
            this.book_description.Location = new System.Drawing.Point(196, 97);
            this.book_description.Multiline = true;
            this.book_description.Name = "book_description";
            this.book_description.Size = new System.Drawing.Size(425, 40);
            this.book_description.TabIndex = 5;
            this.book_description.Text = b.Description;
            // 
            // book_year
            // 
            this.book_year.AutoSize = true;
            this.book_year.Location = new System.Drawing.Point(661, 52);
            this.book_year.Name = "book_year";
            this.book_year.Size = new System.Drawing.Size(66, 24);
            this.book_year.TabIndex = 4;
            this.book_year.Text = b.year+"";
            // 
            // book_edition
            // 
            this.book_edition.AutoSize = true;
            this.book_edition.Location = new System.Drawing.Point(661, 17);
            this.book_edition.Name = "book_edition";
            this.book_edition.Size = new System.Drawing.Size(66, 24);
            this.book_edition.TabIndex = 3;
            this.book_edition.Text = b.Edition;
            // 
            // book_author
            // 
            this.book_author.AutoSize = true;
            this.book_author.Location = new System.Drawing.Point(192, 52);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(66, 24);
            this.book_author.TabIndex = 2;
            this.book_author.Text = b.Author;
            // 
            // book_name
            // 
            this.book_name.AutoSize = true;
            this.book_name.Location = new System.Drawing.Point(192, 17);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(66, 24);
            this.book_name.TabIndex = 1;
            this.book_name.Text = b.Name;
            // 
            // book_pic
            // 
            this.book_pic.ImageLocation = b.imagelocation;
            this.book_pic.Location = new System.Drawing.Point(36, 17);
            this.book_pic.Name = "book_pic";
            this.book_pic.Size = new System.Drawing.Size(119, 120);
            this.book_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.book_pic.TabIndex = 0;
            this.book_pic.TabStop = false;
        }
        private void book_option_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (book_option.Text)
            {
                case "Delete":
                    this.home.MyLibraryBooksList.Remove(this.b);
                    this.Parent.Controls.Remove(this);
                    break;
                case "Edit":
                    (new Form1(b, true)).ShowDialog();
                    this.book_pic.ImageLocation = b.imagelocation;
                    this.book_name.Text = b.Name;
                    this.book_author.Text = b.Author;
                    this.book_edition.Text = b.Edition;
                    this.book_year.Text = b.year+"";
                    this.book_description.Text = b.Description;
                    break;
                case "Open":
                    this.home.OpenBook(this.b);
                    break;
            }
            book_option.SelectedItem = "Select";
        }
        private HomePageForm home;
        private Book b;
        private ComboBox book_option;
        private TextBox book_description;
        private Label book_year;
        private Label book_edition;
        private Label book_author;
        private Label book_name;
        private PictureBox book_pic;
    }
}
