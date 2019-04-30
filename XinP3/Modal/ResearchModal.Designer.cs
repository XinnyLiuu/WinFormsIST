namespace XinP3.Modal
{
    partial class ResearchModal
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_research = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_research)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_name.Location = new System.Drawing.Point(467, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(465, 23);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_research
            // 
            this.dgv_research.AllowUserToAddRows = false;
            this.dgv_research.AllowUserToDeleteRows = false;
            this.dgv_research.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_research.Location = new System.Drawing.Point(0, 65);
            this.dgv_research.Name = "dgv_research";
            this.dgv_research.ReadOnly = true;
            this.dgv_research.RowTemplate.Height = 24;
            this.dgv_research.Size = new System.Drawing.Size(1426, 520);
            this.dgv_research.TabIndex = 1;
            // 
            // ResearchModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 583);
            this.Controls.Add(this.dgv_research);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResearchModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResearchModal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_research)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_research;
    }
}