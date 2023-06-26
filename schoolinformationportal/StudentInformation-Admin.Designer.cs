namespace schoolinformationportal
{
    partial class StudentInformation_Admin
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
            this.dgvStudentAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentAdmin
            // 
            this.dgvStudentAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAdmin.Location = new System.Drawing.Point(35, 48);
            this.dgvStudentAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStudentAdmin.Name = "dgvStudentAdmin";
            this.dgvStudentAdmin.RowHeadersWidth = 51;
            this.dgvStudentAdmin.RowTemplate.Height = 25;
            this.dgvStudentAdmin.Size = new System.Drawing.Size(751, 305);
            this.dgvStudentAdmin.TabIndex = 0;
            this.dgvStudentAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentAdmin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "MajorID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(830, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "ClassID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(955, 48);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(186, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(955, 129);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(186, 27);
            this.txtStudentName.TabIndex = 8;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(955, 205);
            this.nudAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAge.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(66, 27);
            this.nudAge.TabIndex = 9;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(955, 284);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(955, 367);
            this.txtMajorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(186, 27);
            this.txtMajorID.TabIndex = 11;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(955, 432);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(186, 27);
            this.txtClassID.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1067, 168);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1067, 208);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search StudentID";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(254, 404);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(186, 27);
            this.txtSearchID.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 404);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(584, 404);
            this.btnSearchReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(86, 31);
            this.btnSearchReset.TabIndex = 18;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1067, 247);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StudentInformation_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1182, 481);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInformation_Admin";
            this.Text = "StudentInformation_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvStudentAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private NumericUpDown nudAge;
        private TextBox txtEmail;
        private TextBox txtMajorID;
        private TextBox txtClassID;
        private Button btnAdd;
        private Button btnReset;
        private Label label7;
        private TextBox txtSearchID;
        private Button btnSearch;
        private Button btnSearchReset;
        private Button btnDelete;
    }
}