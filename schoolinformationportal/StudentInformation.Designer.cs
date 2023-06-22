namespace schoolinformationportal
{
    partial class StudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformation));
            txtStudentID = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtStudentName = new TextBox();
            label3 = new Label();
            txtStudentAge = new TextBox();
            label4 = new Label();
            txtStudentEmail = new TextBox();
            label5 = new Label();
            txtStudentClass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentID.Location = new Point(603, 57);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(307, 34);
            txtStudentID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(565, 451);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(603, 26);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "StudentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(603, 115);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 3;
            label2.Text = "StudentName";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentName.Location = new Point(603, 146);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(307, 34);
            txtStudentName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(603, 203);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 5;
            label3.Text = "StudentAge";
            // 
            // txtStudentAge
            // 
            txtStudentAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentAge.Location = new Point(603, 234);
            txtStudentAge.Name = "txtStudentAge";
            txtStudentAge.Size = new Size(307, 34);
            txtStudentAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(603, 287);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 7;
            label4.Text = "StudentEmail";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentEmail.Location = new Point(603, 318);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(307, 34);
            txtStudentEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(603, 374);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 9;
            label5.Text = "StudentClass";
            // 
            // txtStudentClass
            // 
            txtStudentClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentClass.Location = new Point(603, 405);
            txtStudentClass.Name = "txtStudentClass";
            txtStudentClass.Size = new Size(307, 34);
            txtStudentClass.TabIndex = 10;
            // 
            // StudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 453);
            Controls.Add(txtStudentClass);
            Controls.Add(label5);
            Controls.Add(txtStudentEmail);
            Controls.Add(label4);
            Controls.Add(txtStudentAge);
            Controls.Add(label3);
            Controls.Add(txtStudentName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtStudentID);
            Name = "StudentInformation";
            Text = "StudentInformation";
            Load += StudentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtStudentName;
        private Label label3;
        private TextBox txtStudentAge;
        private Label label4;
        private TextBox txtStudentEmail;
        private Label label5;
        private TextBox txtStudentClass;
    }
}