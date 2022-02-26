using System.Windows.Forms;

namespace Final_Project
{
    public class ReadRandomPanel : Panel
    {
        public ReadRandomPanel()
        {
            this.readrandomtxt4 = new System.Windows.Forms.TextBox();
            this.readrandomtxt3 = new System.Windows.Forms.TextBox();
            this.readrandomtxt2 = new System.Windows.Forms.TextBox();
            this.readrandomtxt1 = new System.Windows.Forms.TextBox();
            this.readrandomlbl4 = new System.Windows.Forms.Label();
            this.readrandomlbl3 = new System.Windows.Forms.Label();
            this.readrandomlbl2 = new System.Windows.Forms.Label();
            this.readrandomlbl1 = new System.Windows.Forms.Label();
            this.readrandom_date = new System.Windows.Forms.Label();
            this.readrandom_next = new System.Windows.Forms.Button();

            // 
            // ReadRandomPanel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.readrandomtxt4);
            this.Controls.Add(this.readrandomtxt3);
            this.Controls.Add(this.readrandomtxt2);
            this.Controls.Add(this.readrandomtxt1);
            this.Controls.Add(this.readrandomlbl4);
            this.Controls.Add(this.readrandomlbl3);
            this.Controls.Add(this.readrandomlbl2);
            this.Controls.Add(this.readrandomlbl1);
            this.Controls.Add(this.readrandom_date);
            this.Controls.Add(this.readrandom_next);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(194, 67);
            this.Name = "ReadRandomPanel";
            this.Size = new System.Drawing.Size(831, 621);
            this.TabIndex = 10;
            this.TabStop = false;
            this.Text = "Read Random";
            // 
            // readrandomtxt4
            // 
            this.readrandomtxt4.BackColor = System.Drawing.Color.White;
            this.readrandomtxt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readrandomtxt4.Cursor = System.Windows.Forms.Cursors.No;
            this.readrandomtxt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomtxt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.readrandomtxt4.Location = new System.Drawing.Point(44, 486);
            this.readrandomtxt4.Multiline = true;
            this.readrandomtxt4.Name = "readrandomtxt4";
            this.readrandomtxt4.ReadOnly = true;
            this.readrandomtxt4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readrandomtxt4.Size = new System.Drawing.Size(744, 82);
            this.readrandomtxt4.TabIndex = 14;
            // 
            // readrandomtxt3
            // 
            this.readrandomtxt3.BackColor = System.Drawing.Color.White;
            this.readrandomtxt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readrandomtxt3.Cursor = System.Windows.Forms.Cursors.No;
            this.readrandomtxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomtxt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.readrandomtxt3.Location = new System.Drawing.Point(43, 339);
            this.readrandomtxt3.Multiline = true;
            this.readrandomtxt3.Name = "readrandomtxt3";
            this.readrandomtxt3.ReadOnly = true;
            this.readrandomtxt3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readrandomtxt3.Size = new System.Drawing.Size(744, 82);
            this.readrandomtxt3.TabIndex = 13;
            // 
            // readrandomtxt2
            // 
            this.readrandomtxt2.BackColor = System.Drawing.Color.White;
            this.readrandomtxt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readrandomtxt2.Cursor = System.Windows.Forms.Cursors.No;
            this.readrandomtxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomtxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.readrandomtxt2.Location = new System.Drawing.Point(44, 206);
            this.readrandomtxt2.Multiline = true;
            this.readrandomtxt2.Name = "readrandomtxt2";
            this.readrandomtxt2.ReadOnly = true;
            this.readrandomtxt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readrandomtxt2.Size = new System.Drawing.Size(744, 82);
            this.readrandomtxt2.TabIndex = 12;
            // 
            // readrandomtxt1
            // 
            this.readrandomtxt1.BackColor = System.Drawing.Color.White;
            this.readrandomtxt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readrandomtxt1.Cursor = System.Windows.Forms.Cursors.No;
            this.readrandomtxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomtxt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.readrandomtxt1.Location = new System.Drawing.Point(41, 87);
            this.readrandomtxt1.Multiline = true;
            this.readrandomtxt1.Name = "readrandomtxt1";
            this.readrandomtxt1.ReadOnly = true;
            this.readrandomtxt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readrandomtxt1.Size = new System.Drawing.Size(744, 82);
            this.readrandomtxt1.TabIndex = 11;
            // 
            // readrandomlbl4
            // 
            this.readrandomlbl4.AutoSize = true;
            this.readrandomlbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomlbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(119)))), ((int)(((byte)(50)))));
            this.readrandomlbl4.Location = new System.Drawing.Point(34, 441);
            this.readrandomlbl4.Name = "readrandomlbl4";
            this.readrandomlbl4.Size = new System.Drawing.Size(279, 31);
            this.readrandomlbl4.TabIndex = 10;
            this.readrandomlbl4.Text = "• Journal Entry Idea:";
            // 
            // readrandomlbl3
            // 
            this.readrandomlbl3.AutoSize = true;
            this.readrandomlbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomlbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(119)))), ((int)(((byte)(50)))));
            this.readrandomlbl3.Location = new System.Drawing.Point(26, 304);
            this.readrandomlbl3.Name = "readrandomlbl3";
            this.readrandomlbl3.Size = new System.Drawing.Size(357, 31);
            this.readrandomlbl3.TabIndex = 9;
            this.readrandomlbl3.Text = "• Random Fact of the Day:";
            // 
            // readrandomlbl2
            // 
            this.readrandomlbl2.AutoSize = true;
            this.readrandomlbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomlbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(119)))), ((int)(((byte)(50)))));
            this.readrandomlbl2.Location = new System.Drawing.Point(34, 171);
            this.readrandomlbl2.Name = "readrandomlbl2";
            this.readrandomlbl2.Size = new System.Drawing.Size(245, 31);
            this.readrandomlbl2.TabIndex = 8;
            this.readrandomlbl2.Text = "• Joke of the Day:";
            // 
            // readrandomlbl1
            // 
            this.readrandomlbl1.AutoSize = true;
            this.readrandomlbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandomlbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(119)))), ((int)(((byte)(50)))));
            this.readrandomlbl1.Location = new System.Drawing.Point(26, 48);
            this.readrandomlbl1.Name = "readrandomlbl1";
            this.readrandomlbl1.Size = new System.Drawing.Size(290, 31);
            this.readrandomlbl1.TabIndex = 7;
            this.readrandomlbl1.Text = "• Thought of the Day:";
            // 
            // readrandom_date
            // 
            this.readrandom_date.AutoSize = true;
            this.readrandom_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandom_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(47)))), ((int)(((byte)(3)))));
            this.readrandom_date.Location = new System.Drawing.Point(630, 23);
            this.readrandom_date.Name = "readrandom_date";
            this.readrandom_date.Size = new System.Drawing.Size(0, 29);
            this.readrandom_date.TabIndex = 6;
            // 
            // readrandom_next
            // 
            this.readrandom_next.BackColor = System.Drawing.Color.White;
            this.readrandom_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readrandom_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readrandom_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(47)))), ((int)(((byte)(3)))));
            this.readrandom_next.Location = new System.Drawing.Point(766, 585);
            this.readrandom_next.Name = "readrandom_next";
            this.readrandom_next.Size = new System.Drawing.Size(55, 30);
            this.readrandom_next.TabIndex = 5;
            this.readrandom_next.Tag = "1";
            this.readrandom_next.Text = "Next";
            this.readrandom_next.UseVisualStyleBackColor = false;
            this.readrandom_next.Click += new System.EventHandler(this.readrandom_next_Click);

            ReadRandomUpdate(1);
        }

        public void ReadRandomUpdate(int i)
        {
            readrandom_date.Text = "Date: " + (System.DateTime.Today.Date + "").Substring(0, 10);
            string[] texts = SearchBooks.getRandomFun(i);
            if (texts != null)
            {
                readrandomtxt1.Text = texts[0];
                readrandomtxt2.Text = texts[1];
                readrandomtxt3.Text = texts[2];
                readrandomtxt4.Text = texts[3];
                readrandom_next.Tag = (i + 1) + "";
            }
            else
            {
                MessageBox.Show("Please connect your Pc with internet.", "Network Issue");
            }
        }

        private void readrandom_next_Click(object sender, System.EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                ReadRandomUpdate(int.Parse(readrandom_next.Tag + ""));
            }
            else
            {
                MessageBox.Show("Please connect your Pc with internet.", "Network Issue");
            }
        }

        private Button readrandom_next;
        private Label readrandom_date;
        private Label readrandomlbl4;
        private Label readrandomlbl3;
        private Label readrandomlbl2;
        private Label readrandomlbl1;
        private TextBox readrandomtxt2;
        private TextBox readrandomtxt1;
        private TextBox readrandomtxt4;
        private TextBox readrandomtxt3;
    }
}