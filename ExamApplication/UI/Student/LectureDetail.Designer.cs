namespace ExamApplication.UI.Student
{
    partial class LectureDetail
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
            this.lecturedetaildata = new RichTextBoxEx.RichTextBoxEx();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lecturedetaildata
            // 
            this.lecturedetaildata.AllowBullets = true;
            this.lecturedetaildata.AllowDefaultInsertText = true;
            this.lecturedetaildata.AllowDefaultSmartText = true;
            this.lecturedetaildata.AllowHyphenation = true;
            this.lecturedetaildata.AllowPictures = true;
            this.lecturedetaildata.AllowSpellCheck = true;
            this.lecturedetaildata.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.lecturedetaildata.FilePath = "";
            this.lecturedetaildata.Location = new System.Drawing.Point(0, 0);
            this.lecturedetaildata.Name = "lecturedetaildata";
            this.lecturedetaildata.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.lecturedetaildata.SetColorWithFont = true;
            this.lecturedetaildata.ShowToolStrip = true;
            this.lecturedetaildata.Size = new System.Drawing.Size(651, 359);
            this.lecturedetaildata.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 355);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(651, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "TRỞ LẠI TRANG ÔN TẬP";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LectureDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lecturedetaildata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureDetail";
            this.Text = "LectureDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx lecturedetaildata;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}