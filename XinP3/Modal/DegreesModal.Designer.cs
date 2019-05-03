namespace XinP3
{
    partial class DegreesModal
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
            this.lbl_degree_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_degrees_extra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_degree_title
            // 
            this.lbl_degree_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_degree_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_degree_title.Location = new System.Drawing.Point(84, 25);
            this.lbl_degree_title.Name = "lbl_degree_title";
            this.lbl_degree_title.Size = new System.Drawing.Size(417, 92);
            this.lbl_degree_title.TabIndex = 0;
            this.lbl_degree_title.Text = "title";
            this.lbl_degree_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 146);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 118);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbl_degrees_extra
            // 
            this.lbl_degrees_extra.AutoSize = true;
            this.lbl_degrees_extra.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_degrees_extra.Location = new System.Drawing.Point(9, 126);
            this.lbl_degrees_extra.Name = "lbl_degrees_extra";
            this.lbl_degrees_extra.Size = new System.Drawing.Size(46, 17);
            this.lbl_degrees_extra.TabIndex = 0;
            this.lbl_degrees_extra.Text = "label1";
            // 
            // DegreesModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 288);
            this.Controls.Add(this.lbl_degrees_extra);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_degree_title);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DegreesModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DegreesModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_degree_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_degrees_extra;
    }
}