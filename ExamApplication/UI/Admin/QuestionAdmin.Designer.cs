namespace ExamApplication.UI.Admin
{
    partial class QuestionAdmin
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
            this.flowQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.question = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.correctanswer = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.isimportantcheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.imageurl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowQuestion
            // 
            this.flowQuestion.AutoScroll = true;
            this.flowQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowQuestion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowQuestion.Location = new System.Drawing.Point(0, 0);
            this.flowQuestion.Name = "flowQuestion";
            this.flowQuestion.Size = new System.Drawing.Size(125, 400);
            this.flowQuestion.TabIndex = 0;
            this.flowQuestion.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu hỏi";
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.question.DefaultText = "";
            this.question.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.question.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.question.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.question.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.question.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.question.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question.Location = new System.Drawing.Point(184, 2);
            this.question.Name = "question";
            this.question.PasswordChar = '\0';
            this.question.PlaceholderText = "";
            this.question.SelectedText = "";
            this.question.Size = new System.Drawing.Size(463, 36);
            this.question.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đáp án A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đáp án B";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đáp án C";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đáp án D";
            // 
            // A
            // 
            this.A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.A.Location = new System.Drawing.Point(184, 65);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(463, 20);
            this.A.TabIndex = 7;
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.B.Location = new System.Drawing.Point(184, 110);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(463, 20);
            this.B.TabIndex = 8;
            // 
            // C
            // 
            this.C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.C.Location = new System.Drawing.Point(184, 155);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(463, 20);
            this.C.TabIndex = 9;
            // 
            // D
            // 
            this.D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.D.Location = new System.Drawing.Point(184, 200);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(463, 20);
            this.D.TabIndex = 10;
            // 
            // correctanswer
            // 
            this.correctanswer.Location = new System.Drawing.Point(628, 281);
            this.correctanswer.Name = "correctanswer";
            this.correctanswer.Size = new System.Drawing.Size(19, 20);
            this.correctanswer.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(129, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(518, 42);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelButton.Location = new System.Drawing.Point(129, 352);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(518, 42);
            this.DelButton.TabIndex = 14;
            this.DelButton.Text = "Xoá";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đáp án đúng";
            // 
            // isimportantcheck
            // 
            this.isimportantcheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.isimportantcheck.AutoSize = true;
            this.isimportantcheck.Location = new System.Drawing.Point(129, 281);
            this.isimportantcheck.Name = "isimportantcheck";
            this.isimportantcheck.Size = new System.Drawing.Size(116, 17);
            this.isimportantcheck.TabIndex = 16;
            this.isimportantcheck.Text = "Câu hỏi quan trọng";
            this.isimportantcheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 400);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imageurl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.isimportantcheck);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.DelButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.question);
            this.panel2.Controls.Add(this.correctanswer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.D);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.C);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.B);
            this.panel2.Controls.Add(this.A);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 400);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hình ảnh";
            // 
            // imageurl
            // 
            this.imageurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageurl.Location = new System.Drawing.Point(184, 245);
            this.imageurl.Name = "imageurl";
            this.imageurl.Size = new System.Drawing.Size(463, 20);
            this.imageurl.TabIndex = 18;
            // 
            // QuestionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionAdmin";
            this.Text = "QuestionAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowQuestion;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox correctanswer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isimportantcheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox imageurl;
        private System.Windows.Forms.Label label7;
    }
}