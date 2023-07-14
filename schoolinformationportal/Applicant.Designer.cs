namespace schoolinformationportal
{
    partial class Applicant
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
            dgvApplication = new DataGridView();
            label1 = new Label();
            txtSearchValue = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtReason = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApplication).BeginInit();
            SuspendLayout();
            // 
            // dgvApplication
            // 
            dgvApplication.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplication.Location = new Point(2, 65);
            dgvApplication.Name = "dgvApplication";
            dgvApplication.RowHeadersWidth = 51;
            dgvApplication.RowTemplate.Height = 29;
            dgvApplication.Size = new Size(1178, 131);
            dgvApplication.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 1;
            label1.Text = "Search Application By Students'ID";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(260, 23);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(372, 27);
            txtSearchValue.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(668, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 253);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 350);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Reason";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(167, 250);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(165, 27);
            txtStudentID.TabIndex = 6;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(167, 347);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(260, 27);
            txtReason.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(470, 249);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSend_Click;
            // 
            // button3
            // 
            button3.Location = new Point(470, 312);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(470, 377);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnUpdate_Click;
            // 
            // button5
            // 
            button5.Location = new Point(793, 10);
            button5.Name = "button5";
            button5.Size = new Size(195, 49);
            button5.TabIndex = 11;
            button5.Text = "Back To Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnHome_Click;
            // 
            // Applicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 481);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtReason);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtSearchValue);
            Controls.Add(label1);
            Controls.Add(dgvApplication);
            Name = "Applicant";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApplication;
        private Label label1;
        private TextBox txtSearchValue;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtReason;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}