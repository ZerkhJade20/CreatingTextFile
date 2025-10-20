namespace CreatingTextFile
{
    partial class FrmRegistration
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
            this.cmbProgramm = new System.Windows.Forms.ComboBox();
            this.txtStudentNu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNamee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstNamee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMIi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGenderr = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthdayy = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContactt = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentNo.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Program";
            // 
            // cmbProgramm
            // 
            this.cmbProgramm.FormattingEnabled = true;
            this.cmbProgramm.Items.AddRange(new object[] {
            "BS Information Technology",
            "",
            "BS Computer Science",
            "",
            "BS Information Systems",
            "",
            "BS Computer Engineering",
            "",
            "BS Data Science",
            "",
            "BS Software Engineering",
            "",
            "BS Game Development",
            "",
            "BS Cybersecurity",
            "",
            "BS Animation",
            "",
            "BS Multimedia Arts",
            "",
            "BS Web Development",
            "",
            "BS Network and Security Administration",
            "BS Business Administration",
            "",
            "BS Accountancy",
            "",
            "BS Accounting Information System",
            "",
            "BS Entrepreneurship",
            "",
            "BS Marketing Management",
            "",
            "BS Financial Management",
            "",
            "BS Human Resource Management",
            "",
            "BS Operations Management",
            "",
            "BS Office Administration",
            "",
            "BS Hospitality Management",
            "",
            "BS Tourism Management",
            "",
            "BS Customs Administration",
            "",
            "BS Real Estate Management",
            "",
            "BS Agribusiness",
            "",
            "BS Agribusiness Management",
            "",
            "BS Logistics and Supply Chain Management",
            "",
            "BS International Business",
            "BS Psychology",
            "",
            "BS Social Work",
            "",
            "BS Criminology",
            "",
            "BS Public Administration",
            "",
            "BS Political Science",
            "",
            "BS Communication",
            "",
            "BS Development Communication",
            "",
            "BS Journalism",
            "",
            "BS Mass Communication",
            "",
            "BS Broadcasting",
            "",
            "BS Secondary Education",
            "",
            "BS Elementary Education",
            "",
            "BS Education Major in English",
            "",
            "BS Education Major in Math",
            "",
            "BS Education Major in Science",
            "",
            "BS Education Major in Social Studies",
            "",
            "BS Physical Education",
            "BS Civil Engineering",
            "",
            "BS Electrical Engineering",
            "",
            "BS Electronics Engineering",
            "",
            "BS Computer Engineering",
            "",
            "BS Industrial Engineering",
            "",
            "BS Mechanical Engineering",
            "",
            "BS Chemical Engineering",
            "",
            "BS Aerospace Engineering",
            "",
            "BS Geodetic Engineering",
            "",
            "BS Agricultural Engineering",
            "",
            "BS Mining Engineering",
            "",
            "BS Sanitary Engineering",
            "",
            "BS Petroleum Engineering",
            "",
            "BS Architecture",
            "",
            "BS Marine Engineering",
            "",
            "BS Naval Architecture and Marine Engineering",
            "",
            "BS Mechatronics Engineering",
            "",
            "BS Robotics Engineering",
            "",
            "BS Renewable Energy Engineering"});
            this.cmbProgramm.Location = new System.Drawing.Point(482, 79);
            this.cmbProgramm.Name = "cmbProgramm";
            this.cmbProgramm.Size = new System.Drawing.Size(315, 21);
            this.cmbProgramm.TabIndex = 4;
            // 
            // txtStudentNu
            // 
            this.txtStudentNu.Location = new System.Drawing.Point(114, 80);
            this.txtStudentNu.Name = "txtStudentNu";
            this.txtStudentNu.Size = new System.Drawing.Size(270, 20);
            this.txtStudentNu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // txtLastNamee
            // 
            this.txtLastNamee.Location = new System.Drawing.Point(114, 117);
            this.txtLastNamee.Name = "txtLastNamee";
            this.txtLastNamee.Size = new System.Drawing.Size(270, 20);
            this.txtLastNamee.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name";
            // 
            // txtFirstNamee
            // 
            this.txtFirstNamee.Location = new System.Drawing.Point(482, 119);
            this.txtFirstNamee.Name = "txtFirstNamee";
            this.txtFirstNamee.Size = new System.Drawing.Size(169, 20);
            this.txtFirstNamee.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(657, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Middle Name";
            // 
            // txtMIi
            // 
            this.txtMIi.Location = new System.Drawing.Point(755, 117);
            this.txtMIi.Name = "txtMIi";
            this.txtMIi.Size = new System.Drawing.Size(42, 20);
            this.txtMIi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Age";
            // 
            // txtAgee
            // 
            this.txtAgee.Location = new System.Drawing.Point(114, 157);
            this.txtAgee.Name = "txtAgee";
            this.txtAgee.Size = new System.Drawing.Size(47, 20);
            this.txtAgee.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gender";
            // 
            // cmbGenderr
            // 
            this.cmbGenderr.FormattingEnabled = true;
            this.cmbGenderr.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGenderr.Location = new System.Drawing.Point(260, 156);
            this.cmbGenderr.Name = "cmbGenderr";
            this.cmbGenderr.Size = new System.Drawing.Size(94, 21);
            this.cmbGenderr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Birthday";
            // 
            // dtpBirthdayy
            // 
            this.dtpBirthdayy.Location = new System.Drawing.Point(114, 194);
            this.dtpBirthdayy.Name = "dtpBirthdayy";
            this.dtpBirthdayy.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdayy.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contact No.";
            // 
            // txtContactt
            // 
            this.txtContactt.Location = new System.Drawing.Point(482, 194);
            this.txtContactt.Name = "txtContactt";
            this.txtContactt.Size = new System.Drawing.Size(169, 20);
            this.txtContactt.TabIndex = 19;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Cyan;
            this.btnRegister.Location = new System.Drawing.Point(325, 254);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(213, 41);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Registration";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(739, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtContactt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBirthdayy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGenderr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAgee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMIi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFirstNamee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastNamee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentNu);
            this.Controls.Add(this.cmbProgramm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProgramm;
        private System.Windows.Forms.TextBox txtStudentNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNamee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstNamee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMIi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGenderr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthdayy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContactt;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
    }
}