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
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            SuspendLayout();
            // 
            // pbBackground
            // 
            pbBackground.BackgroundImage = (Image)resources.GetObject("pbBackground.BackgroundImage");
            pbBackground.Location = new Point(-2, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(1188, 632);
            pbBackground.TabIndex = 1;
            pbBackground.TabStop = false;
            pbBackground.Click += pictureBox1_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.BackColor = Color.Transparent;
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.ForeColor = Color.FromArgb(104, 0, 0);
            lbHeader.Location = new Point(36, 35);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(783, 54);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "Welcome to the student information portal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 600);
            Controls.Add(lbHeader);
            Controls.Add(pbBackground);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBackground;
        private Label lbHeader;
    }
}