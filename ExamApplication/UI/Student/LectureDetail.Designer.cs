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
            this.lecturedetaildata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturedetaildata.FilePath = "";
            this.lecturedetaildata.Location = new System.Drawing.Point(0, 0);
            this.lecturedetaildata.Name = "lecturedetaildata";
            this.lecturedetaildata.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.lecturedetaildata.SetColorWithFont = true;
            this.lecturedetaildata.ShowToolStrip = true;
            this.lecturedetaildata.Size = new System.Drawing.Size(634, 361);
            this.lecturedetaildata.TabIndex = 0;
            // 
            // LectureDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.lecturedetaildata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureDetail";
            this.Text = "LectureDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx lecturedetaildata;
    }
}