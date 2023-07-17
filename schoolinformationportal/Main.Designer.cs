namespace schoolinformationportal
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pbBackground = new PictureBox();
            lbHeader = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            // 
            // lbHeader
            // 
            lbHeader.BackColor = Color.Transparent;
            lbHeader.Dock = DockStyle.Fill;
            lbHeader.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbHeader.ForeColor = Color.SkyBlue;
            lbHeader.Location = new Point(0, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(1184, 455);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "aaa";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            lbHeader.Click += lbHeader_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(69, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 3;
            button1.Tag = "Student";
            button1.Text = "Student Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(269, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 4;
            button2.Tag = "Class";
            button2.Text = "Class Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(869, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(200, 80);
            button3.TabIndex = 5;
            button3.Tag = "Application";
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(469, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 6;
            button4.Tag = "Logout";
            button4.Text = "Application Information";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(669, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(200, 80);
            button5.TabIndex = 7;
            button5.Tag = "Class";
            button5.Text = "About FPT Edu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 455);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbHeader);
            Controls.Add(pbBackground);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Main Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBackground;
        private Label lbHeader;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}