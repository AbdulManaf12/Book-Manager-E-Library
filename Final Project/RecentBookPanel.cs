using System;
using System.Windows.Forms;

namespace Final_Project
{ 
    public class RecentBook : Panel
    {
        Book book;
        HomePageForm f;
        public RecentBook(Book book, HomePageForm f)
        {
            this.book = book;
            this.f = f;
            this.recentname_lbl = new System.Windows.Forms.Label();
            this.recentpath_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.recentaccess_lbl = new System.Windows.Forms.Label();
            this.button5 = new PictureBox();
            //
            // Self
            //
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.recentname_lbl);
            this.Controls.Add(this.recentpath_lbl);
            this.Controls.Add(this.recentaccess_lbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Location = new System.Drawing.Point(5, 25);
            this.Name = "MyLibraryPanel";
            this.Size = new System.Drawing.Size(787, 120);
            this.Dock = DockStyle.Top;
            this.TabIndex = 10;
            this.TabStop = false;
            this.Text = "Recent Book";
            // 
            // recentname_lbl
            // 
            this.recentname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentname_lbl.ForeColor = System.Drawing.Color.White;
            this.recentname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.recentname_lbl.Location = new System.Drawing.Point(22, 27);
            this.recentname_lbl.Name = "recentname_lbl";
            this.recentname_lbl.Size = new System.Drawing.Size(615, 25);
            this.recentname_lbl.TabIndex = 0;
            this.recentname_lbl.Text = book.Name;
            // 
            // recentpath_lbl
            // 
            this.recentpath_lbl.AutoSize = true;
            this.recentpath_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentpath_lbl.ForeColor = System.Drawing.Color.White;
            this.recentpath_lbl.Location = new System.Drawing.Point(36, 60);
            this.recentpath_lbl.Name = "recentpath_lbl";
            this.recentpath_lbl.Size = new System.Drawing.Size(0, 24);
            this.recentpath_lbl.TabIndex = 1;
            this.recentpath_lbl.Text = book.url;
            if(recentpath_lbl.Text.Length > 70)
                this.recentpath_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(637, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.OpenFile);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(637, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add in Library";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.AddInLibraryPanel);
            // 
            // recentaccess_lbl
            // 
            this.recentaccess_lbl.AutoSize = true;
            this.recentaccess_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentaccess_lbl.ForeColor = System.Drawing.Color.White;
            this.recentaccess_lbl.Location = new System.Drawing.Point(377, 82);
            this.recentaccess_lbl.Name = "recentaccess_lbl";
            this.recentaccess_lbl.Size = new System.Drawing.Size(0, 25);
            this.recentaccess_lbl.TabIndex = 4;
            this.recentaccess_lbl.Text = book.LastAccessTime;
            //
            //  Delete Button
            //
            this.button5.ImageLocation = "..\\..\\..\\resources\\close button.png";
            this.button5.Location = new System.Drawing.Point(755, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.Cursor = Cursors.Hand;
            this.button5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.button5.TabIndex = 6;
            this.button5.Click += new EventHandler(this.DeleteFromRecent);
        }
        public void OpenFile(object sender, EventArgs e)
        {
            this.f.OpenBook(this.book);
        }
        public void AddInLibraryPanel(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Book b in this.f.MyLibraryBooksList)
            {
                if (book.url == b.url)
                    flag = true;
            }
            if (!flag)
            {
                this.f.AddInMyLibraryBook(book);
                MessageBox.Show("Added in My Library.                  ", "Info");
            }
            else
            {
                MessageBox.Show("Already Exists.                       ", "Info");
            }
        }
        public void DeleteFromRecent(object sender, EventArgs e)
        {
            this.f.RecentBooksList.Remove(this.book);
            this.f.RecentFlowLayoutPanel.Controls.Remove(this);
        }
        public Label recentname_lbl;
        public Label recentpath_lbl;
        public Button button4;
        public Button button3;
        public PictureBox button5;
        public Label recentaccess_lbl;
    }
}