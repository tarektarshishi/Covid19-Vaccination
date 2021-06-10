
namespace Final_Project_Khouloud_Nasrallah_Tarek_Tarshishi
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your password :";
            // 
            // usertxt
            // 
            this.usertxt.AccessibleName = "usertxt";
            this.usertxt.Location = new System.Drawing.Point(452, 60);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(269, 27);
            this.usertxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.AccessibleName = "passtxt";
            this.passtxt.Location = new System.Drawing.Point(454, 166);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(266, 27);
            this.passtxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button button1;
    }
}