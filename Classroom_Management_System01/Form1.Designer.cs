namespace Classroom_Management_System01
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Login_User = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.Faculty = new System.Windows.Forms.Button();
            this.Club_President = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 415);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Controls.Add(this.Login_User);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(111, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 104);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Login_User
            // 
            this.Login_User.AutoSize = true;
            this.Login_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_User.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_User.Location = new System.Drawing.Point(3, 0);
            this.Login_User.Name = "Login_User";
            this.Login_User.Size = new System.Drawing.Size(170, 31);
            this.Login_User.TabIndex = 0;
            this.Login_User.Text = "Login Users";
            this.Login_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(120, 243);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(84, 34);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Faculty
            // 
            this.Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faculty.Location = new System.Drawing.Point(237, 243);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(84, 34);
            this.Faculty.TabIndex = 2;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            this.Faculty.Click += new System.EventHandler(this.Faculty_Click);
            // 
            // Club_President
            // 
            this.Club_President.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Club_President.Location = new System.Drawing.Point(357, 243);
            this.Club_President.Name = "Club_President";
            this.Club_President.Size = new System.Drawing.Size(84, 34);
            this.Club_President.TabIndex = 3;
            this.Club_President.Text = "Club President";
            this.Club_President.UseVisualStyleBackColor = true;
            this.Club_President.Click += new System.EventHandler(this.Club_President_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(453, 413);
            this.Controls.Add(this.Club_President);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Login_User;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Faculty;
        private System.Windows.Forms.Button Club_President;
    }
}

