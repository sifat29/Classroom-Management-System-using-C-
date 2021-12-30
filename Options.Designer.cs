namespace Classroom_Management_System01
{
    partial class Options
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
            this.Option = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.Insert_Room_Info = new System.Windows.Forms.Button();
            this.Update_Room_Info = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Option);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, -5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 107);
            this.flowLayoutPanel1.TabIndex = 118;
            // 
            // Option
            // 
            this.Option.AutoSize = true;
            this.Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option.Location = new System.Drawing.Point(3, 0);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(123, 33);
            this.Option.TabIndex = 0;
            this.Option.Text = "Options";
            this.Option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 420);
            this.panel1.TabIndex = 117;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(249, 351);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 34);
            this.Back.TabIndex = 121;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Insert_Room_Info
            // 
            this.Insert_Room_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Room_Info.Location = new System.Drawing.Point(160, 160);
            this.Insert_Room_Info.Name = "Insert_Room_Info";
            this.Insert_Room_Info.Size = new System.Drawing.Size(244, 62);
            this.Insert_Room_Info.TabIndex = 122;
            this.Insert_Room_Info.Text = "Insert_Room_Info";
            this.Insert_Room_Info.UseVisualStyleBackColor = true;
            // 
            // Update_Room_Info
            // 
            this.Update_Room_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Room_Info.Location = new System.Drawing.Point(160, 253);
            this.Update_Room_Info.Name = "Update_Room_Info";
            this.Update_Room_Info.Size = new System.Drawing.Size(244, 62);
            this.Update_Room_Info.TabIndex = 123;
            this.Update_Room_Info.Text = "Update_Room_Info";
            this.Update_Room_Info.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 411);
            this.Controls.Add(this.Update_Room_Info);
            this.Controls.Add(this.Insert_Room_Info);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back);
            this.Name = "Options";
            this.Text = "Options";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Option;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Insert_Room_Info;
        private System.Windows.Forms.Button Update_Room_Info;
    }
}