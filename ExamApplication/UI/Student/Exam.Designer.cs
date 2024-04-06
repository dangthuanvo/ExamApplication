namespace ExamApplication.UI.Student
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new Guna.UI2.WinForms.Guna2Button();
            this.D = new Guna.UI2.WinForms.Guna2Button();
            this.nextButton = new Guna.UI2.WinForms.Guna2Button();
            this.infoStudent = new System.Windows.Forms.Label();
            this.A = new Guna.UI2.WinForms.Guna2Button();
            this.C = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 100);
            this.panel1.TabIndex = 0;
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(3, 36);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(644, 64);
            this.question.TabIndex = 3;
            this.question.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Câu hỏi:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(590, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(60, 24);
            this.time.TabIndex = 1;
            this.time.Text = "30:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian còn lại:";
            // 
            // B
            // 
            this.B.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.B.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.B.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(352, 132);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(286, 88);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // D
            // 
            this.D.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.D.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.D.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.D.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.White;
            this.D.Location = new System.Drawing.Point(352, 241);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(286, 88);
            this.D.TabIndex = 4;
            this.D.Text = "D";
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // nextButton
            // 
            this.nextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(458, 343);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(180, 45);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Câu hỏi tiếp theo";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // infoStudent
            // 
            this.infoStudent.AutoSize = true;
            this.infoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoStudent.Location = new System.Drawing.Point(11, 355);
            this.infoStudent.Name = "infoStudent";
            this.infoStudent.Size = new System.Drawing.Size(352, 24);
            this.infoStudent.TabIndex = 6;
            this.infoStudent.Text = "Sinh viên đang làm bài thi: 20520314";
            // 
            // A
            // 
            this.A.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.A.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.A.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.A.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(13, 132);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(286, 88);
            this.A.TabIndex = 7;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // C
            // 
            this.C.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.C.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.C.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(13, 241);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(286, 88);
            this.C.TabIndex = 8;
            this.C.Text = "C";
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A);
            this.Controls.Add(this.infoStudent);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.D);
            this.Controls.Add(this.B);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam";
            this.Text = "Exam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        //private Guna.UI2.WinForms.Guna2Button C;
        private Guna.UI2.WinForms.Guna2Button B;
        //private Guna.UI2.WinForms.Guna2Button C;
        private Guna.UI2.WinForms.Guna2Button D;
        private Guna.UI2.WinForms.Guna2Button nextButton;
        private System.Windows.Forms.Label infoStudent;
        private Guna.UI2.WinForms.Guna2Button A;
        private Guna.UI2.WinForms.Guna2Button C;
    }
}