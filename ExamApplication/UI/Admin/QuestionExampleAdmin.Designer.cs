﻿namespace ExamApplication.UI.Admin
{
    partial class QuestionExampleAdmin
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
            this.imageurl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowQuestion
            // 
            this.flowQuestion.AutoScroll = true;
            this.flowQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowQuestion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowQuestion.Location = new System.Drawing.Point(0, 0);
            this.flowQuestion.Name = "flowQuestion";
            this.flowQuestion.Size = new System.Drawing.Size(126, 400);
            this.flowQuestion.TabIndex = 0;
            this.flowQuestion.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu hỏi";
            // 
            // question
            // 
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đáp án A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đáp án B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đáp án C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đáp án D";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(184, 65);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(463, 20);
            this.A.TabIndex = 7;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(184, 110);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(463, 20);
            this.B.TabIndex = 8;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(184, 155);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(463, 20);
            this.C.TabIndex = 9;
            // 
            // D
            // 
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
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đáp án đúng";
            // 
            // isimportantcheck
            // 
            this.isimportantcheck.AutoSize = true;
            this.isimportantcheck.Location = new System.Drawing.Point(129, 281);
            this.isimportantcheck.Name = "isimportantcheck";
            this.isimportantcheck.Size = new System.Drawing.Size(116, 17);
            this.isimportantcheck.TabIndex = 16;
            this.isimportantcheck.Text = "Câu hỏi quan trọng";
            this.isimportantcheck.UseVisualStyleBackColor = true;
            // 
            // imageurl
            // 
            this.imageurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageurl.Location = new System.Drawing.Point(184, 245);
            this.imageurl.Name = "imageurl";
            this.imageurl.Size = new System.Drawing.Size(463, 20);
            this.imageurl.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hình ảnh";
            // 
            // QuestionExampleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.imageurl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isimportantcheck);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.correctanswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionExampleAdmin";
            this.Text = "QuestionAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox imageurl;
        private System.Windows.Forms.Label label7;
    }
}