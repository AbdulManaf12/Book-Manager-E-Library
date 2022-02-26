using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class StickerForm : Form
    {
        Book book;
        public StickerForm()
        {
            InitializeComponent();
        }
        public StickerForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            if(book.Notes.Count > 0)
            {
                foreach (NoteData note in book.Notes)
                {
                    this.notes_flowlayout_panel.Controls.Add(new Sticker(book,note));
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void AddStick(object sender, EventArgs e)
        {
            this.notes_flowlayout_panel.Controls.Add(new Sticker(this.book,null));
        }
    }
    public class Sticker : Panel
    {
        public Sticker(Book book, NoteData noteData)
        {
            this.noteData = noteData;
            this.book = book;

            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();

            // 
            // Sticker_Panel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.title_textbox);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "Sticker_Panel";
            this.Size = new System.Drawing.Size(285, 147);
            this.TabIndex = 0;
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(106, 124);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(58, 20);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Visible = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(183, 124);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(63, 20);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.Location = new System.Drawing.Point(3, 58);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textbox.Size = new System.Drawing.Size(283, 64);
            this.description_textbox.TabIndex = 1;
            // 
            // title_textbox
            // 
            this.title_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textbox.Location = new System.Drawing.Point(3, 18);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(284, 22);
            this.title_textbox.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(26, 124);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(63, 20);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);

            if(noteData != null)
            {
                title_textbox.Text = noteData.Title;
                description_textbox.Text = noteData.Description;
                label3.Text = noteData.Time;
                title_textbox.ReadOnly = true;
                description_textbox.ReadOnly = true;
                edit_btn.Visible = true;
                save_btn.Visible = false;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            this.book.Notes.Remove(noteData);
            this.Parent.Controls.Remove(this);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!Validate(title_textbox.Text))
            {
                MessageBox.Show("Invalid title! Please enter correct", "Title");
                return;
            }
            if (!Validate(description_textbox.Text))
            {
                MessageBox.Show("Invalid title! Please enter correct", "Title");
                return;
            }
            noteData = new NoteData(title_textbox.Text, description_textbox.Text, System.DateTime.Now + "");
            this.book.Notes.Add(noteData);
            this.save_btn.Visible = false;
            this.edit_btn.Visible = true;
            this.title_textbox.ReadOnly = true;
            this.description_textbox.ReadOnly = true;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.title_textbox.ReadOnly = false;
            this.description_textbox.ReadOnly = false;
            this.save_btn.Visible = true;
            this.edit_btn.Visible = false;
        }
        private bool Validate(String str)
        {
            return !((str.Replace('\0', ' ').Length == 0));
        }
        // Declare Components
        private NoteData noteData;
        private Book book;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox description_textbox;
        private TextBox title_textbox;
        private Button remove_btn;
        private Button edit_btn;
        private Button save_btn;
    }

    public class GeneralSticker : Panel
    {
        public GeneralSticker(FlowLayoutPanel flowLayoutPanel, List<NoteData> list)
        {
            this.flowLayout = flowLayoutPanel;
            this.noteDatas = list;
            IntilizeComponents();
        }
        public GeneralSticker(FlowLayoutPanel flowLayoutPanel, List<NoteData> list, NoteData noteData)
        {
            this.flowLayout = flowLayoutPanel;
            this.noteDatas = list;
            this.noteData1 = noteData;
            IntilizeComponents();
            this.title_textbox.Text = noteData.Title;
            this.description_textbox.Text = noteData.Description;
            this.label3.Text = noteData.Time;
            edit_btn.Visible = true;
            save_btn.Visible = false;
        }
        public void IntilizeComponents()
        {
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            // 
            // Sticker_Panel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.title_textbox);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "General_Sticker_Panel";
            this.Size = new System.Drawing.Size(260, 177);
            this.TabIndex = 0;
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(106, 155);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_btn.Size = new System.Drawing.Size(58, 20);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Visible = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(183, 155);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.ForeColor = System.Drawing.Color.Black;
            this.remove_btn.Size = new System.Drawing.Size(63, 20);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 1);
            this.label3.Name = "label3";
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.Location = new System.Drawing.Point(3, 58);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textbox.Size = new System.Drawing.Size(260, 88);
            this.description_textbox.TabIndex = 1;
            // 
            // title_textbox
            // 
            this.title_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textbox.Location = new System.Drawing.Point(3, 18);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(260, 22);
            this.title_textbox.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(26, 155);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(63, 20);
            this.save_btn.TabIndex = 5;
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
        }
        private void remove_Click(object sender, EventArgs e)
        {
            this.noteDatas.Remove(noteData1);
            this.flowLayout.Controls.Remove(this);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!Validate(title_textbox.Text))
            {
                MessageBox.Show("Invalid title! Please enter correct", "Title");
                return;
            }
            if (!Validate(description_textbox.Text))
            {
                MessageBox.Show("Invalid title! Please enter correct", "Title");
                return;
            }
            if (noteData1 == null)
            {
                noteData1 = new NoteData(title_textbox.Text, description_textbox.Text, System.DateTime.Now + "");
                this.noteDatas.Add(noteData1);
            }
            else
            {
                noteData1.Title = title_textbox.Text;
                noteData1.Description = description_textbox.Text;
                noteData1.Time = System.DateTime.Now + "";
            }
            this.save_btn.Visible = false;
            this.edit_btn.Visible = true;
            this.title_textbox.ReadOnly = true;
            this.description_textbox.ReadOnly = true;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.title_textbox.ReadOnly = false;
            this.description_textbox.ReadOnly = false;
            this.save_btn.Visible = true;
            this.edit_btn.Visible = false;
        }
        private bool Validate(String str)
        {
            return !((str.Replace('\0', ' ').Length == 0));
        }
        // Declare Components
        private NoteData noteData1;
        private List<NoteData> noteDatas;
        private FlowLayoutPanel flowLayout;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox description_textbox;
        private TextBox title_textbox;
        private Button remove_btn;
        private Button edit_btn;
        private Button save_btn;
    }
}
