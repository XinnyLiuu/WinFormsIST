namespace XinP3
{
    partial class EmploymentModal
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
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.lbl_employment_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(0, 72);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.Size = new System.Drawing.Size(689, 673);
            this.dgv_info.TabIndex = 0;
            // 
            // lbl_employment_title
            // 
            this.lbl_employment_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employment_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_employment_title.Location = new System.Drawing.Point(12, 27);
            this.lbl_employment_title.Name = "lbl_employment_title";
            this.lbl_employment_title.Size = new System.Drawing.Size(665, 42);
            this.lbl_employment_title.TabIndex = 1;
            this.lbl_employment_title.Text = "title";
            this.lbl_employment_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmploymentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 744);
            this.Controls.Add(this.lbl_employment_title);
            this.Controls.Add(this.dgv_info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmploymentModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploymentModal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label lbl_employment_title;
    }
}