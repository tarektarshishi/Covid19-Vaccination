
namespace Final_Project_Khouloud_Nasrallah_Tarek_Tarshishi
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter All The Information Needed :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your sex :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter your location :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose a vaccin :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(462, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enroll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametxt
            // 
            this.nametxt.AccessibleName = "nametxt";
            this.nametxt.Location = new System.Drawing.Point(224, 95);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(225, 27);
            this.nametxt.TabIndex = 7;
            // 
            // locationtxt
            // 
            this.locationtxt.AccessibleName = "locationtxt";
            this.locationtxt.Location = new System.Drawing.Point(224, 275);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(219, 27);
            this.locationtxt.TabIndex = 10;
            // 
            // combo
            // 
            this.combo.AccessibleName = "combo";
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(223, 335);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(180, 28);
            this.combo.TabIndex = 11;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(228, 207);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(63, 24);
            this.male.TabIndex = 12;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(325, 207);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(78, 24);
            this.female.TabIndex = 13;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(223, 147);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(225, 27);
            this.age.TabIndex = 14;
            this.age.ValueChanged += new System.EventHandler(this.age_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(502, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 86);
            this.button2.TabIndex = 15;
            this.button2.Text = "ALREADY ENROLLED ?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.age);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Button button2;
    }
}