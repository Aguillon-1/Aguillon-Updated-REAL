namespace Classroom_Management_System
{
    partial class AdminFinalCreateClass
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
            components = new System.ComponentModel.Container();
            formExpand = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            fileButton = new Custom.FinalCustomButton();
            listBox1 = new ListBox();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            addSubjectButton = new Custom.FinalCustomButton();
            cancelButton = new ClassroomManagementSystem.Custom.CustomButton();
            createClassButton = new ClassroomManagementSystem.Custom.CustomButton();
            moreSubjectButton = new Custom.FinalCustomButton();
            addSubjectPanel = new Custom.PanelDesign();
            createSubject1 = new CreateSubject();
            label2 = new Label();
            singleFramePanel = new Custom.PanelDesign();
            doubleFramePanel = new Custom.PanelDesign();
            addSubjectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formExpand
            // 
            formExpand.Tick += formExpand_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Create Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(66, 73);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 27);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(66, 147);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 7;
            label4.Text = "Icon:";
            // 
            // fileButton
            // 
            fileButton.BackColor = Color.White;
            fileButton.BackgroundColor = Color.White;
            fileButton.BorderColor = Color.FromArgb(93, 49, 156);
            fileButton.BorderRadius = 20;
            fileButton.BorderSize = 2;
            fileButton.FlatAppearance.BorderSize = 0;
            fileButton.FlatStyle = FlatStyle.Flat;
            fileButton.ForeColor = Color.Black;
            fileButton.Location = new Point(100, 170);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(204, 37);
            fileButton.TabIndex = 10;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(332, 176);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 24);
            listBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Location = new Point(100, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 178);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(66, 425);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Preview:";
            // 
            // panel2
            // 
            panel2.Location = new Point(100, 466);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 57);
            panel2.TabIndex = 16;
            // 
            // addSubjectButton
            // 
            addSubjectButton.BackColor = Color.Ivory;
            addSubjectButton.BackgroundColor = Color.Ivory;
            addSubjectButton.BorderColor = Color.FromArgb(93, 49, 156);
            addSubjectButton.BorderRadius = 20;
            addSubjectButton.BorderSize = 2;
            addSubjectButton.FlatAppearance.BorderSize = 0;
            addSubjectButton.FlatStyle = FlatStyle.Flat;
            addSubjectButton.ForeColor = Color.Black;
            addSubjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            addSubjectButton.Location = new Point(180, 548);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(234, 41);
            addSubjectButton.TabIndex = 17;
            addSubjectButton.Text = "+  Add Subject";
            addSubjectButton.TextColor = Color.Black;
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += addSubjectButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(30, 38, 51);
            cancelButton.BorderRadius = 25;
            cancelButton.BorderSize = 0;
            cancelButton.FlatAppearance.BorderColor = Color.White;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelButton.Location = new Point(100, 620);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += customButton1_Click;
            // 
            // createClassButton
            // 
            createClassButton.BackColor = Color.FromArgb(198, 68, 70);
            createClassButton.BorderRadius = 25;
            createClassButton.BorderSize = 0;
            createClassButton.FlatAppearance.BorderColor = Color.White;
            createClassButton.FlatAppearance.BorderSize = 0;
            createClassButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 68, 70);
            createClassButton.FlatStyle = FlatStyle.Flat;
            createClassButton.ForeColor = Color.White;
            createClassButton.ImageAlign = ContentAlignment.MiddleLeft;
            createClassButton.Location = new Point(375, 620);
            createClassButton.Name = "createClassButton";
            createClassButton.Size = new Size(146, 37);
            createClassButton.TabIndex = 19;
            createClassButton.Text = "CREATE CLASS";
            createClassButton.UseVisualStyleBackColor = false;
            createClassButton.Click += createClassButton_Click;
            // 
            // moreSubjectButton
            // 
            moreSubjectButton.BackColor = Color.Ivory;
            moreSubjectButton.BackgroundColor = Color.Ivory;
            moreSubjectButton.BorderColor = Color.FromArgb(93, 49, 156);
            moreSubjectButton.BorderRadius = 20;
            moreSubjectButton.BorderSize = 2;
            moreSubjectButton.FlatAppearance.BorderSize = 0;
            moreSubjectButton.FlatStyle = FlatStyle.Flat;
            moreSubjectButton.ForeColor = Color.Black;
            moreSubjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            moreSubjectButton.Location = new Point(755, 616);
            moreSubjectButton.Name = "moreSubjectButton";
            moreSubjectButton.Size = new Size(234, 41);
            moreSubjectButton.TabIndex = 21;
            moreSubjectButton.Text = "+  Add Subject";
            moreSubjectButton.TextColor = Color.Black;
            moreSubjectButton.UseVisualStyleBackColor = false;
            // 
            // addSubjectPanel
            // 
            addSubjectPanel.AutoScroll = true;
            addSubjectPanel.BackColor = Color.White;
            addSubjectPanel.BorderColor = Color.FromArgb(93, 49, 156);
            addSubjectPanel.BorderRadius = 3;
            addSubjectPanel.BorderSize = 3;
            addSubjectPanel.BottomGradient = Color.White;
            addSubjectPanel.Controls.Add(createSubject1);
            addSubjectPanel.ForeColor = Color.Black;
            addSubjectPanel.GradientAngle = 90F;
            addSubjectPanel.Location = new Point(574, 59);
            addSubjectPanel.Name = "addSubjectPanel";
            addSubjectPanel.Size = new Size(594, 539);
            addSubjectPanel.TabIndex = 0;
            addSubjectPanel.TopGradient = Color.White;
            // 
            // createSubject1
            // 
            createSubject1.BackColor = Color.FromArgb(141, 142, 196);
            createSubject1.Location = new Point(3, 3);
            createSubject1.Name = "createSubject1";
            createSubject1.Size = new Size(588, 533);
            createSubject1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(817, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 22;
            label2.Text = "Create Subject";
            // 
            // singleFramePanel
            // 
            singleFramePanel.BackColor = Color.White;
            singleFramePanel.BorderColor = Color.MidnightBlue;
            singleFramePanel.BorderRadius = 3;
            singleFramePanel.BorderSize = 3;
            singleFramePanel.BottomGradient = Color.FromArgb(141, 142, 196);
            singleFramePanel.ForeColor = Color.White;
            singleFramePanel.GradientAngle = 90F;
            singleFramePanel.Location = new Point(0, 1);
            singleFramePanel.MaximumSize = new Size(1177, 690);
            singleFramePanel.MinimumSize = new Size(569, 690);
            singleFramePanel.Name = "singleFramePanel";
            singleFramePanel.Size = new Size(569, 690);
            singleFramePanel.TabIndex = 24;
            singleFramePanel.TopGradient = Color.FromArgb(141, 142, 196);
            // 
            // doubleFramePanel
            // 
            doubleFramePanel.BackColor = Color.White;
            doubleFramePanel.BorderColor = Color.MidnightBlue;
            doubleFramePanel.BorderRadius = 3;
            doubleFramePanel.BorderSize = 3;
            doubleFramePanel.BottomGradient = Color.FromArgb(141, 142, 196);
            doubleFramePanel.ForeColor = Color.White;
            doubleFramePanel.GradientAngle = 90F;
            doubleFramePanel.Location = new Point(2, 1);
            doubleFramePanel.MaximumSize = new Size(1177, 690);
            doubleFramePanel.MinimumSize = new Size(569, 690);
            doubleFramePanel.Name = "doubleFramePanel";
            doubleFramePanel.Size = new Size(1177, 690);
            doubleFramePanel.TabIndex = 25;
            doubleFramePanel.TopGradient = Color.FromArgb(141, 142, 196);
            // 
            // AdminFinalCreateClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            ClientSize = new Size(570, 692);
            Controls.Add(label2);
            Controls.Add(addSubjectPanel);
            Controls.Add(moreSubjectButton);
            Controls.Add(createClassButton);
            Controls.Add(cancelButton);
            Controls.Add(addSubjectButton);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(fileButton);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(singleFramePanel);
            Controls.Add(doubleFramePanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1180, 692);
            MinimizeBox = false;
            MinimumSize = new Size(570, 692);
            Name = "AdminFinalCreateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFinalCreateClass";
            addSubjectPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer formExpand;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Custom.FinalCustomButton fileButton;
        private ListBox listBox1;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Custom.FinalCustomButton addSubjectButton;
        private ClassroomManagementSystem.Custom.CustomButton cancelButton;
        private ClassroomManagementSystem.Custom.CustomButton createClassButton;
        private Custom.FinalCustomButton moreSubjectButton;
        private Custom.PanelDesign addSubjectPanel;
        private CreateSubject createSubject1;
        private Label label2;
        private Custom.PanelDesign singleFramePanel;
        private Custom.PanelDesign doubleFramePanel;
    }
}