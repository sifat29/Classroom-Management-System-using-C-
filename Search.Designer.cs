namespace Classroom_Management_System01
{
    partial class Search
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
            this.Searchh = new System.Windows.Forms.Label();
            this.entertext = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SearchBy = new System.Windows.Forms.ComboBox();
            this.Search_By = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 420);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Searchh);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 107);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // entertext
            // 
            this.entertext.Location = new System.Drawing.Point(208, 304);
            this.entertext.Name = "entertext";
            this.entertext.Size = new System.Drawing.Size(233, 20);
            this.entertext.TabIndex = 4;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(208, 356);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(76, 34);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(330, 356);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 34);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // SearchBy
            // 
            this.SearchBy.FormattingEnabled = true;
            this.SearchBy.Items.AddRange(new object[] {
            "BookName",
            "WriterName",
            "CatagoryName"});
            this.SearchBy.Location = new System.Drawing.Point(208, 249);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(233, 21);
            this.SearchBy.TabIndex = 114;
            // 
            // Search_By
            // 
            this.Search_By.AutoSize = true;
            this.Search_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_By.Location = new System.Drawing.Point(113, 248);
            this.Search_By.Name = "Search_By";
            this.Search_By.Size = new System.Drawing.Size(89, 18);
            this.Search_By.TabIndex = 115;
            this.Search_By.Text = "Search_By";
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(113, 302);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(53, 20);
            this.Enter.TabIndex = 116;
            this.Enter.Text = "Enter";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 418);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Search_By);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.entertext);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Text = "Search";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Searchh;
        private System.Windows.Forms.TextBox entertext;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox SearchBy;
        private System.Windows.Forms.Label Search_By;
        private System.Windows.Forms.Label Enter;
    }
}