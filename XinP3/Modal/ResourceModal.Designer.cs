namespace XinP3.Modal
{
    partial class ResourceModal
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
            this.fp_resources = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fp_resources
            // 
            this.fp_resources.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp_resources.Location = new System.Drawing.Point(25, 199);
            this.fp_resources.Name = "fp_resources";
            this.fp_resources.Size = new System.Drawing.Size(914, 844);
            this.fp_resources.TabIndex = 1;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Location = new System.Drawing.Point(25, 57);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(914, 122);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "desc";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_name.Location = new System.Drawing.Point(271, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(401, 48);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResourceModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 1055);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.fp_resources);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResourceModal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fp_resources;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_name;
    }
}