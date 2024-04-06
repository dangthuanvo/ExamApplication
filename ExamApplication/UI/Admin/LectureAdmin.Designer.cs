namespace ExamApplication.UI.Admin
{
    partial class LectureAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lecturedata = new RichTextBoxEx.RichTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturename = new System.Windows.Forms.TextBox();
            this.saveLectureButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.flowLecture = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLecture.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lecturename);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lecturedata);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 279);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveLectureButton);
            this.panel3.Controls.Add(this.delButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 28);
            this.panel3.TabIndex = 5;
            // 
            // lecturedata
            // 
            this.lecturedata.AllowBullets = true;
            this.lecturedata.AllowDefaultInsertText = true;
            this.lecturedata.AllowDefaultSmartText = true;
            this.lecturedata.AllowHyphenation = true;
            this.lecturedata.AllowPictures = true;
            this.lecturedata.AllowSpellCheck = true;
            this.lecturedata.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.lecturedata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturedata.FilePath = "";
            this.lecturedata.Location = new System.Drawing.Point(0, 28);
            this.lecturedata.Name = "lecturedata";
            this.lecturedata.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.lecturedata.SetColorWithFont = true;
            this.lecturedata.ShowToolStrip = true;
            this.lecturedata.Size = new System.Drawing.Size(650, 251);
            this.lecturedata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bài giảng";
            // 
            // lecturename
            // 
            this.lecturename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturename.Location = new System.Drawing.Point(81, 4);
            this.lecturename.Name = "lecturename";
            this.lecturename.Size = new System.Drawing.Size(413, 20);
            this.lecturename.TabIndex = 2;
            this.lecturename.TextChanged += new System.EventHandler(this.lecturename_TextChanged);
            // 
            // saveLectureButton
            // 
            this.saveLectureButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveLectureButton.Location = new System.Drawing.Point(500, 0);
            this.saveLectureButton.Name = "saveLectureButton";
            this.saveLectureButton.Size = new System.Drawing.Size(75, 28);
            this.saveLectureButton.TabIndex = 3;
            this.saveLectureButton.Text = "Lưu";
            this.saveLectureButton.UseVisualStyleBackColor = true;
            this.saveLectureButton.Click += new System.EventHandler(this.saveLectureButton_Click);
            // 
            // delButton
            // 
            this.delButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.delButton.Location = new System.Drawing.Point(575, 0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 28);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Xoá";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // flowLecture
            // 
            this.flowLecture.AutoScroll = true;
            this.flowLecture.Controls.Add(this.panel4);
            this.flowLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLecture.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLecture.Location = new System.Drawing.Point(0, 0);
            this.flowLecture.Name = "flowLecture";
            this.flowLecture.Size = new System.Drawing.Size(650, 121);
            this.flowLecture.TabIndex = 1;
            this.flowLecture.WrapContents = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLecture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 121);
            this.panel1.TabIndex = 2;
            // 
            // LectureAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureAdmin";
            this.Text = "LectureAdmin";
            this.Load += new System.EventHandler(this.LectureAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLecture.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button saveLectureButton;
        private System.Windows.Forms.TextBox lecturename;
        private System.Windows.Forms.Label label1;
        private RichTextBoxEx.RichTextBoxEx lecturedata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLecture;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}