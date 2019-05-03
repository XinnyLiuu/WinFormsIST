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
    public partial class ResourceModal : Form
    {
        public ResourceModal(string type, object resource)
        {
            InitializeComponent();

            // Check each type
            if(type == "abroad")
            {
                // Set title
                StudyAbroad s = resource as StudyAbroad;
                lbl_name.Text = s.title;
                this.Text = s.title;

                // Set desc
                lbl_desc.Text = s.description;

                // Add each place to flowlayoutpanel
                foreach(Place p in s.places)
                {
                    // Create title label
                    Label title = new Label();
                    title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.Color.OrangeRed;
                    title.Size = new Size(250, 20);
                    title.Text = p.nameOfPlace;

                    // Create desc label
                    Label desc = new Label();
                    desc.Size = new Size(650, 100);
                    desc.Text = p.description;

                    // Add to flowlayoutpanel
                    fp_resources.Controls.Add(title);
                    fp_resources.Controls.Add(desc);
                }
            }

            if(type == "services")
            {
                // Get services
                StudentServices s = resource as StudentServices;

                // Get all 'sub' services
                AcademicAdvisors a = s.academicAdvisors;
                ProfessonalAdvisors p = s.professonalAdvisors;
                FacultyAdvisors f = s.facultyAdvisors;
                IstMinorAdvising i = s.istMinorAdvising;

                /**
                 * Academic Advisors
                 */
                // Set the title 
                lbl_name.Text = a.title;
                this.Text = "Advising Services";

                // Set the description
                lbl_desc.Text = a.description;

                // Set faq
                LinkLabel faq = new LinkLabel();
                faq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                faq.Size = new Size(650, 50);
                faq.Text = a.faq.contentHref;
                faq.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(a.faq.contentHref); faq.LinkVisited = true; });
                fp_resources.Controls.Add(faq);

                /**
                 * Professonal Advisors
                 */
                // Create title label
                Label pTitle = new Label();
                pTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pTitle.ForeColor = System.Drawing.Color.OrangeRed;
                pTitle.Size = new Size(250, 20);
                pTitle.Text = p.title;

                // Create a label that stores the names of the advisors
                Label names = new Label();
                names.Size = new Size(650, 50);
                foreach (AdvisorInformation info in p.advisorInformation)
                {
                    names.Text += info.name + ", ";
                }

                // Remove the trailing comma
                string allNames = names.Text;
                allNames = allNames.Remove(allNames.Length - 2, 2);
                names.Text = allNames;

                // Add to flowlayoutpanel
                fp_resources.Controls.Add(pTitle);
                fp_resources.Controls.Add(names);

                /**
                 * IST Minor Advising
                 */
                // Create title label
                Label iTitle = new Label();
                iTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                iTitle.ForeColor = System.Drawing.Color.OrangeRed;
                iTitle.Size = new Size(250, 20);
                iTitle.Text = i.title;

                // Create a label that stores the names of the advisors
                Label names2 = new Label();
                names2.Size = new Size(650, 50);
                foreach (MinorAdvisorInformation info in i.minorAdvisorInformation)
                {
                    names2.Text += info.advisor + ", ";
                }

                // Remove the trailing comma
                string allNames2 = names2.Text;
                allNames2 = allNames2.Remove(allNames2.Length - 2, 2);
                names2.Text = allNames2;

                // Add to flowlayoutpanel
                fp_resources.Controls.Add(iTitle);
                fp_resources.Controls.Add(names2);

                /**
                 * Faculty Advisors
                 */
                // Create title label
                Label fTitle = new Label();
                fTitle.AutoSize = false; 
                fTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                fTitle.ForeColor = System.Drawing.Color.OrangeRed;
                fTitle.Size = new Size(250, 20);
                fTitle.Text = f.title;

                // Create desc label
                Label fDesc = new Label();
                fDesc.Size = new Size(650, 130);
                fDesc.Text = f.description;
                
                // Add to flowlayoutpanel
                fp_resources.Controls.Add(fTitle);
                fp_resources.Controls.Add(fDesc);
            }

            if(type == "tutors")
            {
                // Set title
                TutorsAndLabInformation t = resource as TutorsAndLabInformation;
                lbl_name.Text = t.title;
                this.Text = t.title;

                // Set desc
                lbl_desc.Text = t.description;

                // Create linklabel for tutoring link
                LinkLabel hours = new LinkLabel();
                hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                hours.Size = new Size(650, 50);
                hours.Text = t.tutoringLabHoursLink;
                hours.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(t.tutoringLabHoursLink); hours.LinkVisited = true; });
                fp_resources.Controls.Add(hours);
            }

            if(type == "ambassadors")
            {
                // Set title
                StudentAmbassadors a = resource as StudentAmbassadors;
                lbl_name.Text = a.title;
                this.Text = a.title;

                // Set desc mission statement
                lbl_desc.Text = a.subSectionContent[0].description;

                // For each subsection, create its own labels
                foreach(SubSectionContent s in a.subSectionContent)
                {
                    if (s.title == "Mission Statement")
                    {
                        continue;
                    }

                    // Create title
                    Label title = new Label();
                    title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.Color.OrangeRed;
                    title.Size = new Size(250, 20);
                    title.Text = s.title;

                    // Create for desc
                    Label desc = new Label();
                    desc.Text = s.description;

                    if(s.title == "Expectations")
                    {
                        desc.Size = new Size(650, 70);
                    }

                    if(s.title == "Duties")
                    {
                        desc.Size = new Size(650, 120);
                    }

                    if(s.title == "Overview")
                    {
                        desc.Size = new Size(650, 40);
                    }

                    if(s.title == "Criteria")
                    {
                        desc.Size = new Size(650, 30); 
                    }

                    if(s.title == "Perks")
                    {
                        desc.Size = new Size(650, 40);
                    }

                    if(s.title == "apply")
                    {
                        desc.AutoSize = true;
                    }

                    // Add to flowlayoutpanel
                    fp_resources.Controls.Add(title);
                    fp_resources.Controls.Add(desc);
                }

                // Create LinkLabel for application link
                LinkLabel ll = new LinkLabel();
                ll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                ll.Size = new Size(650, 50);
                ll.Text = a.applicationFormLink;
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(a.applicationFormLink); ll.LinkVisited = true; });
                fp_resources.Controls.Add(ll);
            }

            if(type == "forms")
            {
                // Set title and description
                Forms f = resource as Forms;
                lbl_name.Text = "Forms";
                lbl_desc.Text = "Below are the forms for Graduate and Undergraduate Students";
                this.Text = "Forms";

                // Gradute form
                Label grad = new Label();
                grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                grad.ForeColor = System.Drawing.Color.OrangeRed;
                grad.Text = "Graduate Forms";
                grad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                grad.Size = new Size(650, 20);
                fp_resources.Controls.Add(grad);

                foreach (GraduateForm gf in f.graduateForms)
                {
                    // Create linklabel for tutoring link
                    LinkLabel form = new LinkLabel();
                    form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    form.Size = new Size(650, 20);
                    form.Text = gf.formName;
                    form.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(gf.href); form.LinkVisited = true; });
                    fp_resources.Controls.Add(form);
                }

                // Add a space
                Label space = new Label();
                space.Size = new Size(500, 50);
                fp_resources.Controls.Add(space);

                // Undergradute form
                Label uGrad = new Label();
                uGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                uGrad.ForeColor = System.Drawing.Color.OrangeRed;
                uGrad.Text = "Undergraduate Forms";
                uGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                uGrad.Size = new Size(650, 20);
                fp_resources.Controls.Add(uGrad);

                foreach (UndergraduateForm ufg in f.undergraduateForms)
                {
                    // Create linklabel for tutoring link
                    LinkLabel form = new LinkLabel();
                    form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    form.Size = new Size(650, 20);
                    form.Text = ufg.formName;
                    form.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(ufg.href); form.LinkVisited = true; });
                    fp_resources.Controls.Add(form);
                }
            }

            if(type == "coop")
            {
                // Set title
                CoopEnrollment c = resource as CoopEnrollment;
                lbl_name.Text = c.title;
                this.Text = c.title;

                // Set desc
                lbl_desc.Text = c.enrollmentInformationContent[0].description;

                // For each enrollment information, create labels 
                foreach(EnrollmentInformationContent e in c.enrollmentInformationContent)
                {
                    if(e.title == "Pre-requisites")
                    {
                        continue;
                    }

                    // Create title
                    Label title = new Label();
                    title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.Color.OrangeRed;
                    title.Size = new Size(250, 20);
                    title.Text = e.title;

                    // Create for desc
                    Label desc = new Label();
                    desc.Text = e.description;

                    if (e.title == "Approval Process")
                    {
                        desc.Size = new Size(650, 40);
                    }

                    if(e.title == "How to enroll in a co-op you found on JobZone")
                    {
                        desc.Size = new Size(650, 50);
                    }

                    if(e.title == "How to enroll in a co-op you found outside of JobZone")
                    {
                        desc.Size = new Size(650, 100);
                    }

                    // Add to flowlayoutpanel
                    fp_resources.Controls.Add(title);
                    fp_resources.Controls.Add(desc);
                }

                // Add link for RITJobZoneGuideLink
                LinkLabel link = new LinkLabel();
                link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                link.Size = new Size(650, 20);
                link.Text = c.RITJobZoneGuidelink;
                link.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(c.RITJobZoneGuidelink); link.LinkVisited = true; });
                fp_resources.Controls.Add(link);
            }
        }
    }
}
