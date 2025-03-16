namespace Classroom_Management_System
{
    partial class CreateSubject
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
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            fileButton = new Custom.FinalCustomButton();
            panel1 = new Panel();
            listBox1 = new ListBox();
            label6 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(75, 18);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(81, 156);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 27);
            textBox2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(75, 81);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 19;
            label4.Text = "Professor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(76, 146);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 20;
            label5.Text = "Icon:";
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
            fileButton.Location = new Point(91, 172);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(204, 37);
            fileButton.TabIndex = 21;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(91, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 178);
            panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(322, 177);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 24);
            listBox1.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(79, 416);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 24;
            label6.Text = "Preview:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(89, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 57);
            panel2.TabIndex = 25;
            // 
            // CreateSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(fileButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Name = "CreateSubject";
            Size = new Size(590, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Custom.FinalCustomButton fileButton;
        private Panel panel1;
        private ListBox listBox1;
        private Label label6;
        private Panel panel2;
    }
}
