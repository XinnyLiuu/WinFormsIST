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
    public partial class MinorsModal : Form
    {
        public MinorsModal(string title, string desc, List<string> courses)
        {
            InitializeComponent();

            // Set title
            lbl_minor_title.Text = title;
            this.Text = title;

            // Set desc
            lbl_minor_desc.Text = desc;

            // Set courses
            foreach(string c in courses)
            {
                Label l = new Label();
                l.Text = c;
                flowLayoutPanel1.Controls.Add(l);
            }
        }
    }
}
