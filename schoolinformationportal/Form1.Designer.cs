namespace schoolinformationportal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbBackground = new PictureBox();
            lbHeader = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            SuspendLayout();
            // 
            // pbBackground
            // 
            pbBackground.BackgroundImage = (Image)resources.GetObject("pbBackground.BackgroundImage");
            pbBackground.Location = new Point(-8, -4);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(1200, 500);
            pbBackground.TabIndex = 1;
            pbBackground.TabStop = false;
            pbBackground.Click += pictureBox1_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.BackColor = Color.Transparent;
            lbHeader.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.ForeColor = Color.FromArgb(104, 0, 0);
            lbHeader.Location = new Point(68, 183);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(138, 72);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "aaaa";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(196, -4);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 3;
            button1.Text = "Student Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(402, -4);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 4;
            button2.Text = "Class Information";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(608, -4);
            button3.Name = "button3";
            button3.Size = new Size(200, 80);
            button3.TabIndex = 5;
            button3.Text = "Application Information";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(814, -4);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 6;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 455);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbHeader);
            Controls.Add(pbBackground);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBackground;
        private Label lbHeader;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}