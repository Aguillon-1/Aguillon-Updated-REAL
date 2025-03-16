namespace Classroom_Management_System
{
    partial class FinalAnnouncement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            announcementPanel1 = new Custom.PanelDesign();
            pictureBox1 = new PictureBox();
            announcementLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            announcementPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // announcementPanel1
            // 
            announcementPanel1.BackColor = Color.White;
            announcementPanel1.BorderColor = Color.FromArgb(93, 49, 156);
            announcementPanel1.BorderRadius = 30;
            announcementPanel1.BorderSize = 2;
            announcementPanel1.BottomGradient = SystemColors.ButtonFace;
            announcementPanel1.Controls.Add(label3);
            announcementPanel1.Controls.Add(label2);
            announcementPanel1.Controls.Add(label1);
            announcementPanel1.Controls.Add(pictureBox1);
            announcementPanel1.ForeColor = Color.White;
            announcementPanel1.GradientAngle = 0F;
            announcementPanel1.Location = new Point(56, 61);
            announcementPanel1.Name = "announcementPanel1";
            announcementPanel1.Size = new Size(1152, 144);
            announcementPanel1.TabIndex = 0;
            announcementPanel1.TopGradient = Color.AliceBlue;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.UserCircle;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 69);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // announcementLabel
            // 
            announcementLabel.AutoSize = true;
            announcementLabel.Location = new Point(25, 20);
            announcementLabel.Name = "announcementLabel";
            announcementLabel.Size = new Size(130, 20);
            announcementLabel.TabIndex = 1;
            announcementLabel.Text = "ANNOUNCEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(114, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(113, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(145, 96);
            label3.Name = "label3";
            label3.Size = new Size(309, 20);
            label3.TabIndex = 3;
            label3.Text = "Welcome to Classroom Management System!";
            // 
            // FinalAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 215, 223);
            Controls.Add(announcementLabel);
            Controls.Add(announcementPanel1);
            Name = "FinalAnnouncement";
            Size = new Size(1270, 750);
            announcementPanel1.ResumeLayout(false);
            announcementPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom.PanelDesign announcementPanel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label announcementLabel;
    }
}
