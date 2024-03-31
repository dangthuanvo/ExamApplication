namespace ExamApplication.UI.Admin
{
    partial class Admin
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lectureButton = new Guna.UI2.WinForms.Guna2Button();
            this.examButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.title = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lectureButton);
            this.flowLayoutPanel1.Controls.Add(this.examButton);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lectureButton
            // 
            this.lectureButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lectureButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lectureButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lectureButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lectureButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lectureButton.ForeColor = System.Drawing.Color.White;
            this.lectureButton.Location = new System.Drawing.Point(3, 3);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(146, 59);
            this.lectureButton.TabIndex = 0;
            this.lectureButton.Text = "SOẠN CÂU HỎI THI THỬ";
            // 
            // examButton
            // 
            this.examButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.examButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.examButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.examButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.examButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.examButton.ForeColor = System.Drawing.Color.White;
            this.examButton.Location = new System.Drawing.Point(3, 68);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(146, 59);
            this.examButton.TabIndex = 1;
            this.examButton.Text = "SOẠN CÂU HỎI THI THẬT";
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 133);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(146, 59);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "SOẠN BÀI GIẢNG";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 50);
            this.panel1.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(547, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(100, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "TRỞ LẠI";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(6, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 36);
            this.title.TabIndex = 0;
            this.title.Text = "BÀI GIẢNG";
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(150, 50);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(650, 400);
            this.mainpanel.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button lectureButton;
        private Guna.UI2.WinForms.Guna2Button examButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel mainpanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}