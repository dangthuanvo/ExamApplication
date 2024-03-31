namespace ExamApplication.UI.Student
{
    partial class Lecture
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
            this.flowLecture = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLecture
            // 
            this.flowLecture.AutoScroll = true;
            this.flowLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLecture.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLecture.Location = new System.Drawing.Point(0, 0);
            this.flowLecture.Name = "flowLecture";
            this.flowLecture.Size = new System.Drawing.Size(650, 400);
            this.flowLecture.TabIndex = 0;
            this.flowLecture.WrapContents = false;
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.flowLecture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecture";
            this.Text = "Lecture";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLecture;
    }
}