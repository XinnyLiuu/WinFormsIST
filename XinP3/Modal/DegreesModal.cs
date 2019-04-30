using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XinP3
{
    public partial class DegreesModal : Form
    {
        public DegreesModal(string title, List<string> extra)
        {
            InitializeComponent();

            // Set title
            lbl_degree_title.Text = title;
            this.Text = title;

            // Set extra label
            if (!title.Contains("certificates"))
            {
                lbl_degrees_extra.Text = "Concentrations";
            }
            else
            {
                lbl_degrees_extra.Text = "Certificates";
            }

            // Iterate through list
            foreach (string s in extra)
            {
                Label l = new Label();
                l.AutoSize = true;
                l.Text = s;
                flowLayoutPanel1.Controls.Add(l);
            }
        }
    }
}
