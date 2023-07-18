namespace schoolinformationportal
{
    partial class ShowClass
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewSubj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(26, 88);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 29;
            this.dgvClass.Size = new System.Drawing.Size(961, 331);
            this.dgvClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search StudentID";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(575, 35);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(177, 27);
            this.txtSearchID.TabIndex = 3;
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(779, 35);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(86, 31);
            this.btnSearchID.TabIndex = 4;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1030, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 81);
            this.label3.TabIndex = 5;
            this.label3.Text = "View Subject";
            // 
            // viewSubj
            // 
            this.viewSubj.Location = new System.Drawing.Point(1030, 252);
            this.viewSubj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewSubj.Name = "viewSubj";
            this.viewSubj.Size = new System.Drawing.Size(86, 31);
            this.viewSubj.TabIndex = 6;
            this.viewSubj.Text = "View";
            this.viewSubj.UseVisualStyleBackColor = true;
            this.viewSubj.Click += new System.EventHandler(this.viewSubj_Click);
            // 
            // ShowClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1182, 481);
            this.Controls.Add(this.viewSubj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowClass";
            this.Text = "ShowClass";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClass;
        private Label label1;
        private Label label2;
        private TextBox txtSearchID;
        private Button btnSearchID;
        private Label label3;
        private Button viewSubj;
    }
}