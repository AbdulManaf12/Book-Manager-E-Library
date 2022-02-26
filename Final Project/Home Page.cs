using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class HomePageForm : Form
    {
        public List<Book> MyLibraryBooksList;
        public List<Book> RecentBooksList;
        public List<NoteData> GeneralNotesList;

        public Book currentBook = null;
        public HomePageForm()
        {
            InitializeComponent();
            MyLibraryBooksList = new List<Book>();
            RecentBooksList = new List<Book>();
            GeneralNotesList = new List<NoteData>();
            this.richTextBox1.WordWrap = true;
            GettingDataBack();
        }
        //
        // Open File
        //
        private void btn_open_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Only PDF Files  (*.pdf)|*.pdf; |" +
                                    "All Files (*.*)|*.*;";
            openFileDialog.Title = "Open Document";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains(".pdf"))
                {
                    currentBook = new Book();
                    currentBook.Name = openFileDialog.SafeFileName;
                    currentBook.Author = "Unkown";
                    currentBook.year = 0;
                    currentBook.Description = "";
                    currentBook.Edition = "Unkown";
                    currentBook.imagelocation = "..\\..\\..\\resources\\defaultbook.jpg";
                    currentBook.url = openFileDialog.FileName;
                    currentBook.LastAccessTime = System.DateTime.Now + "";
                    OpenBook(currentBook);
                }
                else
                {
                    MessageBox.Show("Please select only pdf file", "Invalid");
                }
            }
        }
        //
        // Read Random Panel
        //
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                RemovePanels();
                this.Controls.Add(new ReadRandomPanel());
            }
            else
            {
                MessageBox.Show("Please connect your Pc with internet.", "Network Issue");
            }
        }
        //
        // Seacrh Button
        //
        private void button2_Click(object sender, System.EventArgs e)
        {
            RemovePanels();
            this.Controls.Add(this.SearchPanel);
            this.comboBox1.SelectedIndex = 0;
            this.search_textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.search_textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            foreach(Book b in MyLibraryBooksList)
            {
                if(!list.Contains(b.Name))
                    list.Add(b.Name);
                if(!list.Contains(b.Author))
                    list.Add(b.Author);
            }
            foreach (Book b in RecentBooksList)
            {
                if (!list.Contains(b.Name))
                    list.Add(b.Name);
                if (!list.Contains(b.Author))
                    list.Add(b.Author);
            }
            this.search_textbox.AutoCompleteCustomSource = list;
        }
        //
        // My Library Panel
        //
        private void button3_Click(object sender, System.EventArgs e)
        {
            RemovePanels();
            this.Controls.Add(this.MyLibraryPanel);
        }
        //
        // Recent Panel
        //
        private void button5_Click(object sender, System.EventArgs e)
        {
            RemovePanels();
            this.Controls.Add(this.RecentPanel);
        }
        //
        // Notes Panel
        //
        private void button6_Click(object sender, System.EventArgs e)
        {
            if(Controls.Contains(this.OpenFilePanel))
            {
                (new StickerForm(this.currentBook)).ShowDialog();
            }
            else
            {
                RemovePanels();
                this.Controls.Add(this.groupBox1);
            }
        }
        //
        // About Panel
        //
        private void button3_Click_1(object sender, System.EventArgs e)
        {
            RemovePanels();
            this.Controls.Add(this.groupBox2);
        }
        //
        // Remove All Panels(means Group Box)
        //
        public void RemovePanels()
        {
            foreach (Control c in Controls)
            {
                if (c is GroupBox)
                {
                    Controls.Remove(c);
                }
                if(c is ReadRandomPanel)
                {
                    this.Controls.Remove(c);
                }
            }
        }
        //
        //  Maximise the current open book
        //
        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            (new Reading(this.adobePDF.src)).ShowDialog();
        }
        // 
        //  Open Book on Panel 
        //
        public void OpenBook(Book book)
        {
            RemovePanels();
            adobePDF.src = book.url;
            this.currentBook = book;
            book.LastAccessTime = System.DateTime.Now+"";
            this.Controls.Add(this.OpenFilePanel);
            this.AddMyBookInRecent(book);
        }
        //
        // Adding new Book in My Library
        //
        private void MyLibraryAdd_btn_Click(object sender, System.EventArgs e)
        {
            Book b = new Book();
            if((new Form1(b,false)).BackInfo())
            {
                bool isBookAlreadyExists = false;
                foreach(Book bs in MyLibraryBooksList)
                {
                    if(b.url == bs.url)
                    {
                        isBookAlreadyExists = true;
                        return;
                    }
                }
                if (!isBookAlreadyExists)
                {
                    AddInMyLibraryBook(b);
                    MessageBox.Show("Successfully Added...!", "Info");
                }
            }
        }
        //
        //  Add a Book in Panel & My Library Data
        //
        public void AddInMyLibraryBook(Book book)
        {
            this.MyLibraryBooksList.Add(book);
            this.flowLayoutPanel1.Controls.Add(new BookPanel(book, this, (155 * (this.flowLayoutPanel1.Controls.Count))));
        }
        //
        //  Add a Book in Recent which is Open now
        //
        public void AddMyBookInRecent(Book book)
        {
            foreach(Book b in RecentBooksList)
            {
                if(b.url == book.url)
                {
                    RecentBooksList.Remove(b);
                    break;
                }
            }
            if (RecentBooksList.Count > 15)
            {
                RecentBooksList.RemoveAt(RecentBooksList.Count);
            }
            this.RecentBooksList.Insert(0,book);
            this.RecentFlowLayoutPanel.Controls.Clear();
            foreach (Book b in RecentBooksList)
            {
                this.RecentFlowLayoutPanel.Controls.Add(new RecentBook(b, this));
            }
        }
        //
        // Search Button Click Event
        //
        private void searchbook_btn_Click(object sender, System.EventArgs e)
        {
            No_Record_Found_lbl.Visible = false;
            new SearchBooks(this, search_textbox.Text, (string)comboBox1.SelectedItem);
            if (this.search_flowlayut_panel.Controls.Count != 0
                && this.search_textbox.Text.Length != 0)
            {
                this.searchbook_btn.Visible = false;
                this.search_textbox.Visible = false;
                this.comboBox1.Visible = false;
                this.comboBox1.SelectedIndex = 0;
                this.reset_btn.Visible = true;
                this.search_flowlayut_panel.Visible = true;
                this.search_textbox.Text = "";
            }
            else
            {
                No_Record_Found_lbl.Visible = true;
            }
        }
        //
        //  Reset Button after Searching Book
        //
        private void reset_btn_Click(object sender, System.EventArgs e)
        {
            this.searchbook_btn.Visible = true;
            this.search_textbox.Visible = true;
            this.comboBox1.Visible = true;
            this.reset_btn.Visible = false;
            this.search_flowlayut_panel.Visible = false;
        }
        private void AddGeneralSticker_btn_Click(object sender, System.EventArgs e)
        {
            this.GeneralNotesListPanel.Controls.Add(new GeneralSticker(GeneralNotesListPanel, GeneralNotesList));
        }
    }
}