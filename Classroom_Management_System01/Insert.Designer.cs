namespace Classroom_Management_System01
{
    partial class Insert
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Searchh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Room_no = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Room_notext = new System.Windows.Forms.TextBox();
            this.Campus_Buildingtext = new System.Windows.Forms.TextBox();
            this.Start_Timetext = new System.Windows.Forms.TextBox();
            this.Finish_Timetext = new System.Windows.Forms.TextBox();
            this.Bookedbytext = new System.Windows.Forms.TextBox();
            this.Booked_by = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Time = new System.Windows.Forms.Label();
            this.Finish_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Controls.Add(this.Searchh);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 123);
            this.flowLayoutPanel1.TabIndex = 118;
            // 
            // Searchh
            // 
            this.Searchh.AutoSize = true;
            this.Searchh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchh.Location = new System.Drawing.Point(3, 0);
            this.Searchh.Name = "Searchh";
            this.Searchh.Size = new System.Drawing.Size(113, 33);
            this.Searchh.TabIndex = 0;
            this.Searchh.Text = "Search";
            this.Searchh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 503);
            this.panel1.TabIndex = 117;
            // 
            // Room_no
            // 
            this.Room_no.AutoSize = true;
            this.Room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_no.Location = new System.Drawing.Point(113, 139);
            this.Room_no.Name = "Room_no";
            this.Room_no.Size = new System.Drawing.Size(86, 20);
            this.Room_no.TabIndex = 124;
            this.Room_no.Text = "Room_no";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(115, 348);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(62, 20);
            this.Status.TabIndex = 123;
            this.Status.Text = "Status";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Available",
            "Booked"});
            this.StatusBox.Location = new System.Drawing.Point(221, 345);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(307, 21);
            this.StatusBox.TabIndex = 122;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Location = new System.Drawing.Point(376, 456);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 34);
            this.Back.TabIndex = 121;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.Location = new System.Drawing.Point(248, 456);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(76, 34);
            this.OK.TabIndex = 120;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Room_notext
            // 
            this.Room_notext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_notext.Location = new System.Drawing.Point(221, 139);
            this.Room_notext.Name = "Room_notext";
            this.Room_notext.Size = new System.Drawing.Size(307, 22);
            this.Room_notext.TabIndex = 119;
            // 
            // Campus_Buildingtext
            // 
            this.Campus_Buildingtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_Buildingtext.Location = new System.Drawing.Point(261, 196);
            this.Campus_Buildingtext.Name = "Campus_Buildingtext";
            this.Campus_Buildingtext.Size = new System.Drawing.Size(267, 22);
            this.Campus_Buildingtext.TabIndex = 125;
            // 
            // Start_Timetext
            // 
            this.Start_Timetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Timetext.Location = new System.Drawing.Point(221, 263);
            this.Start_Timetext.Name = "Start_Timetext";
            this.Start_Timetext.Size = new System.Drawing.Size(307, 22);
            this.Start_Timetext.TabIndex = 126;
            // 
            // Finish_Timetext
            // 
            this.Finish_Timetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_Timetext.Location = new System.Drawing.Point(221, 294);
            this.Finish_Timetext.Name = "Finish_Timetext";
            this.Finish_Timetext.Size = new System.Drawing.Size(307, 22);
            this.Finish_Timetext.TabIndex = 127;
            // 
            // Bookedbytext
            // 
            this.Bookedbytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookedbytext.Location = new System.Drawing.Point(221, 401);
            this.Bookedbytext.Name = "Bookedbytext";
            this.Bookedbytext.Size = new System.Drawing.Size(307, 22);
            this.Bookedbytext.TabIndex = 128;
            // 
            // Booked_by
            // 
            this.Booked_by.AutoSize = true;
            this.Booked_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked_by.Location = new System.Drawing.Point(115, 399);
            this.Booked_by.Name = "Booked_by";
            this.Booked_by.Size = new System.Drawing.Size(100, 20);
            this.Booked_by.TabIndex = 129;
            this.Booked_by.Text = "Booked_By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 130;
            this.label2.Text = "Campus & Building";
            // 
            // Start_Time
            // 
            this.Start_Time.AutoSize = true;
            this.Start_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Time.Location = new System.Drawing.Point(118, 264);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(97, 20);
            this.Start_Time.TabIndex = 131;
            this.Start_Time.Text = "Start_Time";
            // 
            // Finish_Time
            // 
            this.Finish_Time.AutoSize = true;
            this.Finish_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_Time.Location = new System.Drawing.Point(115, 294);
            this.Finish_Time.Name = "Finish_Time";
            this.Finish_Time.Size = new System.Drawing.Size(105, 20);
            this.Finish_Time.TabIndex = 132;
            this.Finish_Time.Text = "Finish_Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 133;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(540, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Finish_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Booked_by);
            this.Controls.Add(this.Bookedbytext);
            this.Controls.Add(this.Finish_Timetext);
            this.Controls.Add(this.Start_Timetext);
            this.Controls.Add(this.Campus_Buildingtext);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Room_no);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Room_notext);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Insert";
            this.Text = "Insert";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Searchh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Room_no;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Room_notext;
        private System.Windows.Forms.TextBox Campus_Buildingtext;
        private System.Windows.Forms.TextBox Start_Timetext;
        private System.Windows.Forms.TextBox Finish_Timetext;
        private System.Windows.Forms.TextBox Bookedbytext;
        private System.Windows.Forms.Label Booked_by;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Start_Time;
        private System.Windows.Forms.Label Finish_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}