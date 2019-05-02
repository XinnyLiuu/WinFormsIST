namespace XinP3
{
    partial class MinorsModal
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
            this.lbl_minor_title = new System.Windows.Forms.Label();
            this.lbl_minor_desc = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_minors_courses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_minor_title
            // 
            this.lbl_minor_title.BackColor = System.Drawing.Color.White;
            this.lbl_minor_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minor_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_minor_title.Location = new System.Drawing.Point(274, 9);
            this.lbl_minor_title.Name = "lbl_minor_title";
            this.lbl_minor_title.Size = new System.Drawing.Size(365, 112);
            this.lbl_minor_title.TabIndex = 0;
            this.lbl_minor_title.Text = "title";
            this.lbl_minor_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_minor_desc
            // 
            this.lbl_minor_desc.Location = new System.Drawing.Point(12, 121);
            this.lbl_minor_desc.Name = "lbl_minor_desc";
            this.lbl_minor_desc.Size = new System.Drawing.Size(882, 184);
            this.lbl_minor_desc.TabIndex = 1;
            this.lbl_minor_desc.Text = "desc";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 325);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(879, 75);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lbl_minors_courses
            // 
            this.lbl_minors_courses.AutoSize = true;
            this.lbl_minors_courses.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_minors_courses.Location = new System.Drawing.Point(9, 305);
            this.lbl_minors_courses.Name = "lbl_minors_courses";
            this.lbl_minors_courses.Size = new System.Drawing.Size(60, 17);
            this.lbl_minors_courses.TabIndex = 3;
            this.lbl_minors_courses.Text = "Courses";
            // 
            // MinorsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 412);
            this.Controls.Add(this.lbl_minors_courses);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_minor_desc);
            this.Controls.Add(this.lbl_minor_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MinorsModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinorsModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_minor_title;
        private System.Windows.Forms.Label lbl_minor_desc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_minors_courses;
    }
}