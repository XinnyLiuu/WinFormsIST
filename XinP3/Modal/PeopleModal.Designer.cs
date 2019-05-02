namespace XinP3
{
    partial class PeopleModal
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
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_office = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.ll_website = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(131, 87);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(214, 209);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_name.Location = new System.Drawing.Point(144, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(201, 24);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.Location = new System.Drawing.Point(143, 60);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 24);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_office
            // 
            this.lbl_office.Location = new System.Drawing.Point(134, 299);
            this.lbl_office.Name = "lbl_office";
            this.lbl_office.Size = new System.Drawing.Size(211, 23);
            this.lbl_office.TabIndex = 4;
            this.lbl_office.Text = "Office";
            this.lbl_office.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_phone
            // 
            this.lbl_phone.Location = new System.Drawing.Point(134, 322);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(211, 23);
            this.lbl_phone.TabIndex = 5;
            this.lbl_phone.Text = "Phone";
            this.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.Location = new System.Drawing.Point(131, 345);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(214, 23);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll_website
            // 
            this.ll_website.Location = new System.Drawing.Point(131, 368);
            this.ll_website.Name = "ll_website";
            this.ll_website.Size = new System.Drawing.Size(214, 23);
            this.ll_website.TabIndex = 7;
            this.ll_website.TabStop = true;
            this.ll_website.Text = "website";
            this.ll_website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeopleModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.ll_website);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_office);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pb_image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeopleModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleModal";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_office;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.LinkLabel ll_website;
    }
}