using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.mylibrary_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RecentPanel = new System.Windows.Forms.GroupBox();
            this.RecentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchPanel = new System.Windows.Forms.GroupBox();
            this.No_Record_Found_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search_flowlayut_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchbook_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.MyLibraryPanel = new System.Windows.Forms.GroupBox();
            this.AddBookInLibrary = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenFilePanel = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adobePDF = new AxAcroPDFLib.AxAcroPDF();
            this.GeneralNotesListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddGeneralSticker_btn = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.about_icon = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.RecentPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.MyLibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBookInLibrary)).BeginInit();
            this.OpenFilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adobePDF)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddGeneralSticker_btn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.about_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.Namelbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 49);
            this.panel1.TabIndex = 0;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.Color.Black;
            this.Namelbl.Location = new System.Drawing.Point(315, 3);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(306, 40);
            this.Namelbl.TabIndex = 2;
            this.Namelbl.Text = "E-Books Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "..\\..\\..\\resources\\close button.png";
            this.pictureBox1.Location = new System.Drawing.Point(971, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(3, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "RECENT FILES";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mylibrary_btn
            // 
            this.mylibrary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.mylibrary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mylibrary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mylibrary_btn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylibrary_btn.ForeColor = System.Drawing.Color.Black;
            this.mylibrary_btn.Location = new System.Drawing.Point(3, 140);
            this.mylibrary_btn.Name = "mylibrary_btn";
            this.mylibrary_btn.Size = new System.Drawing.Size(170, 40);
            this.mylibrary_btn.TabIndex = 6;
            this.mylibrary_btn.Text = "MY LIBRARY";
            this.mylibrary_btn.UseVisualStyleBackColor = false;
            this.mylibrary_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(3, 79);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(170, 40);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(3, 20);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(170, 40);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "OPEN FILE";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_open);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.search_btn);
            this.panel2.Controls.Add(this.mylibrary_btn);
            this.panel2.Location = new System.Drawing.Point(11, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 621);
            this.panel2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "ABOUT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "NOTES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "READ RANDOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecentPanel
            // 
            this.RecentPanel.BackColor = System.Drawing.Color.White;
            this.RecentPanel.Controls.Add(this.RecentFlowLayoutPanel);
            this.RecentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentPanel.Location = new System.Drawing.Point(194, 67);
            this.RecentPanel.Name = "RecentPanel";
            this.RecentPanel.Size = new System.Drawing.Size(831, 621);
            this.RecentPanel.TabIndex = 10;
            this.RecentPanel.TabStop = false;
            this.RecentPanel.Text = "Recent Books";
            // 
            // RecentFlowLayoutPanel
            // 
            this.RecentFlowLayoutPanel.AutoScroll = true;
            this.RecentFlowLayoutPanel.Location = new System.Drawing.Point(6, 28);
            this.RecentFlowLayoutPanel.Name = "RecentFlowLayoutPanel";
            this.RecentFlowLayoutPanel.Size = new System.Drawing.Size(815, 587);
            this.RecentFlowLayoutPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.No_Record_Found_lbl);
            this.SearchPanel.Controls.Add(this.comboBox1);
            this.SearchPanel.Controls.Add(this.search_flowlayut_panel);
            this.SearchPanel.Controls.Add(this.searchbook_btn);
            this.SearchPanel.Controls.Add(this.search_textbox);
            this.SearchPanel.Controls.Add(this.reset_btn);
            this.SearchPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanel.ForeColor = System.Drawing.Color.White;
            this.SearchPanel.Location = new System.Drawing.Point(194, 67);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(831, 621);
            this.SearchPanel.TabIndex = 10;
            this.SearchPanel.TabStop = false;
            this.SearchPanel.Text = "Search";
            // 
            // No_Record_Found_lbl
            // 
            this.No_Record_Found_lbl.AutoSize = true;
            this.No_Record_Found_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.No_Record_Found_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Record_Found_lbl.Location = new System.Drawing.Point(278, 319);
            this.No_Record_Found_lbl.Name = "No_Record_Found_lbl";
            this.No_Record_Found_lbl.Size = new System.Drawing.Size(222, 31);
            this.No_Record_Found_lbl.TabIndex = 5;
            this.No_Record_Found_lbl.Text = "No Record Found";
            this.No_Record_Found_lbl.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(715, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // search_flowlayut_panel
            // 
            this.search_flowlayut_panel.BackColor = System.Drawing.Color.White;
            this.search_flowlayut_panel.Location = new System.Drawing.Point(6, 53);
            this.search_flowlayut_panel.Name = "search_flowlayut_panel";
            this.search_flowlayut_panel.Size = new System.Drawing.Size(819, 562);
            this.search_flowlayut_panel.TabIndex = 3;
            this.search_flowlayut_panel.Visible = false;
            // 
            // searchbook_btn
            // 
            this.searchbook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbook_btn.ForeColor = System.Drawing.Color.Black;
            this.searchbook_btn.Location = new System.Drawing.Point(567, 139);
            this.searchbook_btn.Name = "searchbook_btn";
            this.searchbook_btn.Size = new System.Drawing.Size(155, 30);
            this.searchbook_btn.TabIndex = 2;
            this.searchbook_btn.Text = "Search";
            this.searchbook_btn.UseVisualStyleBackColor = true;
            this.searchbook_btn.Click += new System.EventHandler(this.searchbook_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_textbox.Location = new System.Drawing.Point(140, 138);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(395, 29);
            this.search_textbox.TabIndex = 1;
            // 
            // reset_btn
            // 
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(733, 15);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(88, 32);
            this.reset_btn.TabIndex = 0;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Visible = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // MyLibraryPanel
            // 
            this.MyLibraryPanel.BackColor = System.Drawing.Color.White;
            this.MyLibraryPanel.Controls.Add(this.AddBookInLibrary);
            this.MyLibraryPanel.Controls.Add(this.flowLayoutPanel1);
            this.MyLibraryPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyLibraryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLibraryPanel.Location = new System.Drawing.Point(194, 67);
            this.MyLibraryPanel.Name = "MyLibraryPanel";
            this.MyLibraryPanel.Size = new System.Drawing.Size(831, 621);
            this.MyLibraryPanel.TabIndex = 10;
            this.MyLibraryPanel.TabStop = false;
            this.MyLibraryPanel.Text = "My Library";
            // 
            // AddBookInLibrary
            // 
            this.AddBookInLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBookInLibrary.ImageLocation = "..\\..\\..\\resources\\Add.png";
            this.AddBookInLibrary.Location = new System.Drawing.Point(754, 7);
            this.AddBookInLibrary.Name = "AddBookInLibrary";
            this.AddBookInLibrary.Size = new System.Drawing.Size(67, 40);
            this.AddBookInLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBookInLibrary.TabIndex = 0;
            this.AddBookInLibrary.TabStop = false;
            this.AddBookInLibrary.Click += new System.EventHandler(this.MyLibraryAdd_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(815, 570);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OpenFilePanel
            // 
            this.OpenFilePanel.BackColor = System.Drawing.Color.White;
            this.OpenFilePanel.Controls.Add(this.pictureBox2);
            this.OpenFilePanel.Controls.Add(this.adobePDF);
            this.OpenFilePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFilePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilePanel.Location = new System.Drawing.Point(194, 67);
            this.OpenFilePanel.Name = "OpenFilePanel";
            this.OpenFilePanel.Size = new System.Drawing.Size(831, 621);
            this.OpenFilePanel.TabIndex = 10;
            this.OpenFilePanel.TabStop = false;
            this.OpenFilePanel.Text = "Reading Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ImageLocation = "..\\..\\..\\resources\\maximise button.png";
            this.pictureBox2.Location = new System.Drawing.Point(793, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // adobePDF
            // 
            this.adobePDF.Enabled = true;
            this.adobePDF.Location = new System.Drawing.Point(6, 28);
            this.adobePDF.Name = "adobePDF";
            this.adobePDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adobePDF.OcxState")));
            this.adobePDF.Size = new System.Drawing.Size(819, 587);
            this.adobePDF.TabIndex = 0;
            // 
            // GeneralNotesListPanel
            // 
            this.GeneralNotesListPanel.AutoScroll = true;
            this.GeneralNotesListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.GeneralNotesListPanel.Location = new System.Drawing.Point(6, 83);
            this.GeneralNotesListPanel.Name = "GeneralNotesListPanel";
            this.GeneralNotesListPanel.Size = new System.Drawing.Size(819, 532);
            this.GeneralNotesListPanel.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddGeneralSticker_btn);
            this.panel3.Location = new System.Drawing.Point(5, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 54);
            this.panel3.TabIndex = 2;
            // 
            // AddGeneralSticker_btn
            // 
            this.AddGeneralSticker_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGeneralSticker_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGeneralSticker_btn.ImageLocation = "..\\..\\..\\resources\\Add.png";
            this.AddGeneralSticker_btn.Location = new System.Drawing.Point(735, 0);
            this.AddGeneralSticker_btn.Name = "AddGeneralSticker_btn";
            this.AddGeneralSticker_btn.Size = new System.Drawing.Size(71, 51);
            this.AddGeneralSticker_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddGeneralSticker_btn.TabIndex = 1;
            this.AddGeneralSticker_btn.TabStop = false;
            this.AddGeneralSticker_btn.Click += new System.EventHandler(this.AddGeneralSticker_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.GeneralNotesListPanel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(194, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 621);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Notes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.about_icon);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(194, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 621);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // about_icon
            // 
            this.about_icon.ImageLocation = "..\\..\\..\\resources\\Icon.png";
            this.about_icon.Location = new System.Drawing.Point(36, 72);
            this.about_icon.Name = "about_icon";
            this.about_icon.Size = new System.Drawing.Size(183, 187);
            this.about_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.about_icon.TabIndex = 2;
            this.about_icon.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(242, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(530, 420);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Book Library";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1037, 700);
            this.Controls.Add(this.RecentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePageForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.RecentPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.MyLibraryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddBookInLibrary)).EndInit();
            this.OpenFilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adobePDF)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddGeneralSticker_btn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.about_icon)).EndInit();
            this.ResumeLayout(false);

        }
        private void HomePageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void GettingDataBack()
        {
            MyLibraryBooksList = (List<Book>)FilingClass.GetObjectIntoFile("Diary_PanelData.xml");
            RecentBooksList = (List<Book>)FilingClass.GetObjectIntoFile("Recent_PanelData.xml");
            GeneralNotesList = (List<NoteData>)FilingClass.GetObjectIntoFile("GeneralNotesList.xml");

            if (MyLibraryBooksList != null)
            {
                foreach (Book book in MyLibraryBooksList)
                {
                    this.flowLayoutPanel1.Controls.Add(new BookPanel(book, this, (155 * (this.flowLayoutPanel1.Controls.Count - 1))));
                }
            }
            else
            {
                MyLibraryBooksList = new List<Book>();
            }

            if (RecentBooksList != null)
            {
                foreach (Book book in RecentBooksList)
                {
                    this.RecentFlowLayoutPanel.Controls.Add(new RecentBook(book, this));
                }
            }
            else
            {
                RecentBooksList = new List<Book>();
            }
            if (GeneralNotesList != null)
            {
                foreach (NoteData note in GeneralNotesList)
                {
                    this.GeneralNotesListPanel.Controls.Add(new GeneralSticker(GeneralNotesListPanel, GeneralNotesList, note));
                }
            }
            else
            {
                GeneralNotesList = new List<NoteData>();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilingClass.WriteObjectIntoFile(MyLibraryBooksList, "Diary_PanelData.xml");
            FilingClass.WriteObjectIntoFile(RecentBooksList, "Recent_PanelData.xml");
            FilingClass.WriteObjectIntoFile(GeneralNotesList, "GeneralNotesList.xml");
            Application.Exit();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label Namelbl;
        private Button btn_open;
        private Button button5;
        private Button mylibrary_btn;
        private Button search_btn;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private GroupBox RecentPanel;
        private GroupBox SearchPanel;
        private GroupBox MyLibraryPanel;
        private GroupBox OpenFilePanel;
        private AxAcroPDFLib.AxAcroPDF adobePDF;
        private PictureBox pictureBox2;
        private PictureBox AddBookInLibrary;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button reset_btn;
        private Button searchbook_btn;
        private TextBox search_textbox;
        public FlowLayoutPanel search_flowlayut_panel;
        public FlowLayoutPanel RecentFlowLayoutPanel;
        private FlowLayoutPanel GeneralNotesListPanel;
        private PictureBox AddGeneralSticker_btn;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button button3;
        private GroupBox groupBox2;
        private Label label1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label No_Record_Found_lbl;
        private PictureBox about_icon;
    }
}