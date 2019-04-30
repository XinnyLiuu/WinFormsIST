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
    public partial class EmploymentModal : Form
    {
        public EmploymentModal(List<CoopInformation> info)
        {
            InitializeComponent();

            // Set title
            lbl_employment_title.Text = "Co-op Table";
            this.Text = "Co-op Table";

            // Reset datagridview
            dgv_info.Columns.Clear();
            dgv_info.Rows.Clear();

            // Autosize
            dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add columns to datagridview
            dgv_info.Columns.Add("employer", "Employer");
            dgv_info.Columns.Add("degree", "Degree");
            dgv_info.Columns.Add("city", "City");
            dgv_info.Columns.Add("term", "Term");

            // Prepare datagridview
            for(int i=0; i<info.Count; i++)
            {
                // Add a row
                dgv_info.Rows.Add();

                // Add things to the row
                dgv_info.Rows[i].Cells[0].Value = info[i].employer;
                dgv_info.Rows[i].Cells[1].Value = info[i].degree;
                dgv_info.Rows[i].Cells[2].Value = info[i].city;
                dgv_info.Rows[i].Cells[3].Value = info[i].term;
            }
        }

        public EmploymentModal(List<ProfessionalEmploymentInformation> info)
        {
            InitializeComponent();

            // Set title
            lbl_employment_title.Text = "Professional Employment Table";
            this.Text = "Professional Employment Table";

            // Reset datagridview
            dgv_info.Columns.Clear();
            dgv_info.Rows.Clear();

            // Autosize
            dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add columns to datagridview
            dgv_info.Columns.Add("employer", "Employer");
            dgv_info.Columns.Add("degree", "Degree");
            dgv_info.Columns.Add("city", "City");
            dgv_info.Columns.Add("title", "Title");
            dgv_info.Columns.Add("startDate", "Start Date");

            // Prepare datagridview
            for (int i = 0; i < info.Count; i++)
            {
                // Add a row
                dgv_info.Rows.Add();

                // Add things to the row
                dgv_info.Rows[i].Cells[0].Value = info[i].employer;
                dgv_info.Rows[i].Cells[1].Value = info[i].degree;
                dgv_info.Rows[i].Cells[2].Value = info[i].city;
                dgv_info.Rows[i].Cells[3].Value = info[i].title;
                dgv_info.Rows[i].Cells[4].Value = info[i].startDate;
            }
        }
    }
}
