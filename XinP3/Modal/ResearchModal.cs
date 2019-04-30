using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XinP3.Modal
{
    public partial class ResearchModal : Form
    {
        public ResearchModal(string name, List<string> data)
        {
            InitializeComponent();

            // Clear datagridview
            dgv_research.Columns.Clear();
            dgv_research.Rows.Clear();

            // Autosize
            dgv_research.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add columns
            dgv_research.Columns.Add("citations", "Citations");

            // Set title
            lbl_name.Text = name;
            this.Text = name;

            // Iterate through each data into datagridview
            for(int i=0; i<data.Count; i++)
            {
                // Add a row
                dgv_research.Rows.Add();

                // Add things to the row
                dgv_research.Rows[i].Cells[0].Value = data[i];
            }
        }
    }
}
