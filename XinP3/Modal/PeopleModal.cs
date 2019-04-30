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
    public partial class PeopleModal : Form
    {
        public PeopleModal(string name, List<string> info)
        {
            InitializeComponent();

            // Set name of individual
            lbl_name.Text = name;
            this.Text = name;

            // Set info
            lbl_title.Text = info[0];
            pb_image.Load(info[1]);
            lbl_office.Text = info[2];
            lbl_website.Text = info[3];
            lbl_phone.Text = info[4];
            lbl_email.Text = info[5];
        }
    }
}
