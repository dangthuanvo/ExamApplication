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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delButton = new System.Windows.Forms.Button();
            this.saveLectureButton = new System.Windows.Forms.Button();
            this.lecturename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturedata = new RichTextBoxEx.RichTextBoxEx();
            this.flowLecture = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delButton);
            this.panel2.Controls.Add(this.saveLectureButton);
            this.panel2.Controls.Add(this.lecturename);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lecturedata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 400);
            this.panel2.TabIndex = 1;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(491, 5);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Xoá";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // saveLectureButton
            // 
            this.saveLectureButton.Location = new System.Drawing.Point(572, 5);
            this.saveLectureButton.Name = "saveLectureButton";
            this.saveLectureButton.Size = new System.Drawing.Size(75, 23);
            this.saveLectureButton.TabIndex = 3;
            this.saveLectureButton.Text = "Lưu";
            this.saveLectureButton.UseVisualStyleBackColor = true;
            this.saveLectureButton.Click += new System.EventHandler(this.saveLectureButton_Click);
            // 
            // lecturename
            // 
            this.lecturename.Location = new System.Drawing.Point(81, 7);
            this.lecturename.Name = "lecturename";
            this.lecturename.Size = new System.Drawing.Size(388, 20);
            this.lecturename.TabIndex = 2;
            this.lecturename.TextChanged += new System.EventHandler(this.lecturename_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bài giảng";
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
            this.lecturedata.FilePath = "";
            this.lecturedata.Location = new System.Drawing.Point(0, 33);
            this.lecturedata.Name = "lecturedata";
            this.lecturedata.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.lecturedata.SetColorWithFont = true;
            this.lecturedata.ShowToolStrip = true;
            this.lecturedata.Size = new System.Drawing.Size(650, 231);
            this.lecturedata.TabIndex = 0;
            // 
            // flowLecture
            // 
            this.flowLecture.AutoScroll = true;
            this.flowLecture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLecture.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLecture.Location = new System.Drawing.Point(0, 270);
            this.flowLecture.Name = "flowLecture";
            this.flowLecture.Size = new System.Drawing.Size(650, 130);
            this.flowLecture.TabIndex = 1;
            this.flowLecture.WrapContents = false;
            // 
            // LectureAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.flowLecture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureAdmin";
            this.Text = "LectureAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveLectureButton;
        private System.Windows.Forms.TextBox lecturename;
        private System.Windows.Forms.Label label1;
        private RichTextBoxEx.RichTextBoxEx lecturedata;
        private System.Windows.Forms.FlowLayoutPanel flowLecture;
        private System.Windows.Forms.Button delButton;
    }
}