using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using XinP3.Modal;

namespace XinP3
{
    public partial class MainForm : Form
    {
        private REST istAPI; // Helper for using ist api

        private About about;
        private Degrees degrees;
        private Minors minors;  
        private Employment employment;
        private People people;
        private Research research;
        private Resources resources;
        private News news;
        private Footer footer;

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            istAPI = new REST("http://ist.rit.edu/api"); // IST API

            PrepareAllJSON(); // Prepare all JSON objects

            // Setup GUI
            SetUpAbout();
            SetUpDegrees();
            SetUpMinors();
            SetUpEmployment();
            SetUpPeople();
            SetUpResearch();
            SetUpResources();
            SetUpNews();
            SetUpFooter();
        }

        # region Custom Form Border
        /**
         * This was taken from https://stackoverflow.com/questions/11379209/how-do-i-make-mousedrag-inside-panel-move-form-window.
         * The second best answer provided me with this solution of making the application draggable without a form.
         * 
         * This is not my code. - Xin 
         */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Custom Close Button
        // Closes the form on btn_close click
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        /**
         * Get all data from API and prepare them by creating them into objects
         */
        private void PrepareAllJSON()
        {
            // Get /about
            string aboutJSON = istAPI.getJSON("/about");
            this.about = JToken.Parse(aboutJSON).ToObject<About>();

            // Get /degrees
            string degreesJSON = istAPI.getJSON("/degrees");
            this.degrees = JToken.Parse(degreesJSON).ToObject<Degrees>();

            // Get /minors
            string minorsJSON = istAPI.getJSON("/minors");
            this.minors = JToken.Parse(minorsJSON).ToObject<Minors>();

            // Get /employment
            string employmentJSON = istAPI.getJSON("/employment");
            this.employment = JToken.Parse(employmentJSON).ToObject<Employment>();

            // Get /people
            string peopleJSON = istAPI.getJSON("/people");
            this.people = JToken.Parse(peopleJSON).ToObject<People>();

            // Get /research
            string researchJSON = istAPI.getJSON("/research");
            this.research = JToken.Parse(researchJSON).ToObject<Research>();

            // Get /resources
            string resourcesJSON = istAPI.getJSON("/resources");
            this.resources = JToken.Parse(resourcesJSON).ToObject<Resources>();

            // Get /news
            string newsJSON = istAPI.getJSON("/news");
            this.news = JToken.Parse(newsJSON).ToObject<News>();

            // Get /footer
            string footerJSON = istAPI.getJSON("/footer");
            this.footer = JToken.Parse(footerJSON).ToObject<Footer>();
        }

        /**
         * 'About' Setup
         */
        private void SetUpAbout()
        {
            // Set title
            lbl_about_title.Text = about.title;

            // Set description
            lbl_about_desc.Text = about.description;

            // Set quote
            lbl_about_quote.Text = String.Format("'' {0} '' \n\n- {1}", about.quote, about.quoteAuthor);
        }

        /**
         * 'Degrees' Setup
         */
        private void SetUpDegrees()
        {
            // Set title
            lbl_degrees_title.Text = "Degrees";

            // Prepare undergraduate views first
            // Get list of all undergraduate data
            List<Undergraduate> ug = degrees.undergraduate;

            // Iterate the list
            foreach(Undergraduate u in ug)
            {
                // Get attributes
                string name = u.degreeName;
                string title = u.title;
                string desc = u.description;
                List<string> c = u.concentrations;

                if(name == "wmc")
                {
                    lbl_wmc_title.Text = title;
                    lbl_wmc_title.MouseEnter += new EventHandler((s, e) => { lbl_wmc_title.Cursor = Cursors.Hand; });
                    lbl_wmc_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_wmc_desc.Text = desc;
                }
                else if(name == "hcc")
                {
                    lbl_hcc_title.Text = title;
                    lbl_hcc_title.MouseEnter += new EventHandler((s, e) => { lbl_hcc_title.Cursor = Cursors.Hand; });
                    lbl_hcc_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_hcc_desc.Text = desc;
                }
                else if(name == "cit")
                {
                    lbl_cit_title.Text = title;
                    lbl_cit_title.MouseEnter += new EventHandler((s, e) => { lbl_cit_title.Cursor = Cursors.Hand; });
                    lbl_cit_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_cit_desc.Text = desc;
                }
            }

            // Prepare graduate views
            // Get list of all graduate data
            List<Graduate> g = degrees.graduate;

            // Iterate the list
            foreach(Graduate _g in g)
            {
                // Get attributes          
                string name = _g.degreeName;
                string title = _g.title;
                string desc = _g.description;
                List<string> c = _g.concentrations;

                if(name == "ist")
                {
                    lbl_ist_title.Text = title;
                    lbl_ist_title.MouseEnter += new EventHandler((s, e) => { lbl_ist_title.Cursor = Cursors.Hand; });
                    lbl_ist_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_ist_desc.Text = desc;
                }
                else if(name == "hci")
                {
                    lbl_hci_title.Text = title;
                    lbl_hci_title.MouseEnter += new EventHandler((s, e) => { lbl_hci_title.Cursor = Cursors.Hand; });
                    lbl_hci_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_hci_desc.Text = desc;
                }
                else if(name == "nsa")
                {
                    lbl_nsa_title.Text = title;
                    lbl_nsa_title.MouseEnter += new EventHandler((s, e) => { lbl_nsa_title.Cursor = Cursors.Hand; });
                    lbl_nsa_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, title, c));
                    lbl_nsa_desc.Text = desc;
                }
                else if(name == "graduate advanced certificates")
                {
                    lbl_advanced_title.Text = "Gradute Advanced Certificates";
                    lbl_advanced_title.MouseEnter += new EventHandler((s, e) => { lbl_advanced_title.Cursor = Cursors.Hand; });
                    lbl_advanced_title.Click += new EventHandler((s, e) => degrees_title_click(s, e, "Gradute Advanced Certificates", _g.availableCertificates));
                }
            }
        }

        /**
         * 'Minors' Setup
         */
        private void SetUpMinors()
        {
            // Set title
            lbl_minors_title.Text = "Minors";

            // Get minors
            List<UgMinor> m = minors.UgMinors;
            
            // Iterate through each and create a label and panel to stick in FlowLayoutPanel
            foreach(UgMinor ug in m)
            {
                // Get attributes
                string name = ug.title;
                string desc = ug.description;
                List<string> c = ug.courses;

                // Create panel
                Panel p = new Panel();
                p.BackColor = System.Drawing.Color.Coral;
                p.Size = new System.Drawing.Size(330, 100);

                // Create labels
                Label title = new Label();
                title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.Size = new System.Drawing.Size(330, 47);
                title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                title.MouseEnter += new EventHandler((s, e) => { title.Cursor = Cursors.Hand; });
                title.Click += new EventHandler((s, e) => minors_title_click(s, e, name, desc, c));

                // Add to panel
                title.Text = ug.title;
                p.Controls.Add(title);
                fp_minors.Controls.Add(p);
            }
        }

        /**
         * 'Employment' Setup 
         */
        private void SetUpEmployment()
        {
            // Get attributes
            Introduction intro = employment.introduction;
            DegreeStatistics stats = employment.degreeStatistics;
            Employers employers = employment.employers;
            Careers careers = employment.careers;
            CoopTable coopTable = employment.coopTable;
            EmploymentTable eTable = employment.employmentTable;

            // Prepare intro
            lbl_employment_title.Text = intro.title;
            List<Content> contents = intro.content;
            foreach(Content c in contents)
            {
                if(c.title == "Employment")
                {
                    lbl_employment_e_title.Text = c.title;
                    lbl_employment_e_desc.Text = c.description;
                }

                if(c.title == "Cooperative Education")
                {
                    lbl_employment_coop_title.Text = c.title;
                    lbl_employment_coop_desc.Text = c.description;
                }
            }

            // Prepare stats
            List<Statistic> allStats = stats.statistics;
            foreach(Statistic s in allStats)
            {
                // Get attributes
                string value = s.value;
                string description = s.description;

                // Create labels
                Label title = new Label();
                title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = System.Drawing.Color.OrangeRed;
                title.Text = value;

                Label desc = new Label();
                desc.AutoSize = false;
                desc.Size = new Size(5000, 20);
                desc.Text = description;

                // Add to flowlayoutpanel
                fp_degree_stats.Controls.Add(title);
                fp_degree_stats.Controls.Add(desc);
            }

            // Prepare employers
            List<string> allEmployers = employers.employerNames;
            foreach(string name in allEmployers)
            {
                // Create label
                Label l = new Label();
                l.ForeColor = System.Drawing.Color.OrangeRed;
                l.Text = name;

                // Add to flowlayoutpanel
                fp_employers.Controls.Add(l);
            }

            // Prepare careers
            List<string> allCareers = careers.careerNames;
            foreach(string name in allCareers)
            {
                // Create label
                Label l = new Label();
                l.ForeColor = System.Drawing.Color.OrangeRed;
                l.Text = name;

                // Add to flowlayoutpanel
                fp_careers.Controls.Add(l);
            }

            // Prepare coop table
            List<CoopInformation> cInfo = coopTable.coopInformation;
            btn_employment_coop.Click += new EventHandler((s, e) => employment_btn_click(s, e, "coop", cInfo));

            // Prepare employmer table
            List<ProfessionalEmploymentInformation> eInfo = eTable.professionalEmploymentInformation;
            btn_employment_e.Click += new EventHandler((s, e) => employment_btn_click(s, e, "employment", eInfo));
        }

        /**
         * 'People' Setup
         */
        private void SetUpPeople()
        {
            // Set titles
            lbl_people_title.Text = people.title;
            lbl_people_subtitle.Text = people.subTitle;

            // Prepare faculty data
            List<Faculty> allFaculty = people.faculty;
            foreach(Faculty f in allFaculty)
            {
                // Get attributes 
                string uName = f.username;
                string name = f.name;
                string tagline = f.tagline;
                string imagePath = f.imagePath;
                string title = f.title;
                string interest = f.interestArea;
                string office = f.office;
                string website = f.website;
                string phone = f.phone;
                string email = f.email;
                string twitter = f.twitter;
                string facebook = f.facebook;

                // Create a list of info about the person to be passed into click event
                List<string> info = new List<string>();
                info.Add(title);
                info.Add(imagePath);
                info.Add(office);
                info.Add(website);
                info.Add(phone);
                info.Add(email);

                // Create panel to be placed into flowlayoutpanel
                Panel p = new Panel();
                p.BackColor = System.Drawing.Color.Coral;
                p.Size = new System.Drawing.Size(200, 50);

                // Create panel labels
                Label lName = new Label();
                Label lTitle = new Label();
                lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lName.Size = new System.Drawing.Size(200, 20);
                lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lName.MouseEnter += new EventHandler((s, e) => { lName.Cursor = Cursors.Hand; });
                lName.Click += new EventHandler((s, e) => people_title_click(s, e, name, info));

                lTitle.Size = new System.Drawing.Size(200, 65);
                lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // Add to panel
                lName.Text = name;
                lTitle.Text = title;
                p.Controls.Add(lName);
                p.Controls.Add(lTitle);
                fp_faculty.Controls.Add(p);
            }

            // Prepare staff
            List<Staff> allStaff = people.staff;
            foreach(Staff s in allStaff)
            {
                // Get attributes 
                string uName = s.username;
                string name = s.name;
                string tagline = s.tagline;
                string imagePath = s.imagePath;
                string title = s.title;
                string interest = s.interestArea;
                string office = s.office;
                string website = s.website;
                string phone = s.phone;
                string email = s.email;
                string twitter = s.twitter;
                string facebook = s.facebook;

                // Create a list of info about the person to be passed into click event
                List<string> info = new List<string>();
                info.Add(title);
                info.Add(imagePath);
                info.Add(office);
                info.Add(website);
                info.Add(phone);
                info.Add(email);

                // Create panel to be placed into flowlayoutpanel
                Panel p = new Panel();
                p.BackColor = System.Drawing.Color.Coral;
                p.Size = new System.Drawing.Size(200, 50);

                // Create panel labels
                Label lName = new Label();
                Label lTitle = new Label();
                lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lName.Size = new System.Drawing.Size(200, 20);
                lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lName.MouseEnter += new EventHandler((o, e) => { lName.Cursor = Cursors.Hand; });
                lName.Click += new EventHandler((o, e) => people_title_click(o, e, name, info));

                lTitle.Size = new System.Drawing.Size(200, 65);
                lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // Add to panel
                lName.Text = name;
                lTitle.Text = title;
                p.Controls.Add(lName);
                p.Controls.Add(lTitle);
                fp_staff.Controls.Add(p);
            }
        }

        /**
         * 'Research' Setup
         */
        private void SetUpResearch()
        {
            // Set titles
            lbl_research_title.Text = "Faculty Research";
            lbl_research_subtitle.Text = "To explore our research by interest or by faculty, click below.";

            // Prepare interest area research  
            List<ByInterestArea> interest = research.byInterestArea;
            foreach(ByInterestArea i in interest)
            {
                // Get attributes
                string area = i.areaName;
                List<string> c = i.citations;

                // Create a panel for each to be placed into flowlayoutpanel
                Panel p = new Panel();
                p.BackColor = System.Drawing.Color.Coral;
                p.Size = new System.Drawing.Size(200, 50);

                // Create label for area name
                Label lName = new Label();
                lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lName.Size = new System.Drawing.Size(200, 20);
                lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lName.MouseEnter += new EventHandler((o, e) => { lName.Cursor = Cursors.Hand; });
                lName.Click += new EventHandler((s, e) => research_title_click(s, e, area, c));

                // Add to panel
                lName.Text = area;
                p.Controls.Add(lName);
                fp_research_interest.Controls.Add(p);
            }

            // Prepare faculty research
            List<ByFaculty> faculty = research.byFaculty;
            foreach(ByFaculty f in faculty)
            {
                // Get attributes
                string name = f.facultyName;
                List<string> c = f.citations;

                // Create a panel for each to be placed into flowlayoutpanel
                Panel p = new Panel();
                p.BackColor = System.Drawing.Color.Coral;
                p.Size = new System.Drawing.Size(200, 50);

                // Create label for area name
                Label lName = new Label();
                lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lName.Size = new System.Drawing.Size(200, 20);
                lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lName.MouseEnter += new EventHandler((o, e) => { lName.Cursor = Cursors.Hand; });
                lName.Click += new EventHandler((s, e) => research_title_click(s, e, name, c));

                // Add to panel
                lName.Text = name;
                p.Controls.Add(lName);
                fp_research_faculty.Controls.Add(p);
            }
        }

        /**
         * 'Resources' Setup
         */
        private void SetUpResources()
        {
            // Setup titles
            lbl_resources_title.Text = resources.title;
            lbl_resources_subtitle.Text = resources.subTitle;

            // Get subsets of resources
            StudyAbroad study = resources.studyAbroad;
            StudentServices services = resources.studentServices;
            TutorsAndLabInformation tutors = resources.tutorsAndLabInformation;
            StudentAmbassadors ambassadors = resources.studentAmbassadors;
            Forms forms = resources.forms;
            CoopEnrollment coop = resources.coopEnrollment;

            /**
             * Study abroad
             */
            // Create a panel 
            Panel saPanel = new Panel();
            saPanel.BackColor = System.Drawing.Color.Coral;
            saPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label saLabel = new Label();
            saLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saLabel.Size = new System.Drawing.Size(330, 47);
            saLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            saLabel.MouseEnter += new EventHandler((o, e) => { saLabel.Cursor = Cursors.Hand; });
            saLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "abroad", study));
            saLabel.Text = study.title;

            // Add to flowlayoutpanel
            saPanel.Controls.Add(saLabel);
            fp_resources.Controls.Add(saPanel);

            /**
             * Student Services
             */
            // Create a panel 
            Panel ssPanel = new Panel();
            ssPanel.BackColor = System.Drawing.Color.Coral;
            ssPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label ssLabel = new Label();
            ssLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ssLabel.Size = new System.Drawing.Size(330, 47);
            ssLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ssLabel.MouseEnter += new EventHandler((o, e) => { ssLabel.Cursor = Cursors.Hand; });
            ssLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "services", services));
            ssLabel.Text = services.title;

            // Add to flowlayoutpanel
            ssPanel.Controls.Add(ssLabel);
            fp_resources.Controls.Add(ssPanel);

            /**
             * Tutors
             */
            // Create a panel 
            Panel tPanel = new Panel();
            tPanel.BackColor = System.Drawing.Color.Coral;
            tPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label tLabel = new Label();
            tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tLabel.Size = new System.Drawing.Size(330, 47);
            tLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tLabel.MouseEnter += new EventHandler((o, e) => { tLabel.Cursor = Cursors.Hand; });
            tLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "tutors", tutors));
            tLabel.Text = tutors.title;

            // Add to flowlayoutpanel
            tPanel.Controls.Add(tLabel);
            fp_resources.Controls.Add(tPanel);

            /**
             * Student Ambassasors
             */
            // Create a panel 
            Panel aPanel = new Panel();
            aPanel.BackColor = System.Drawing.Color.Coral;
            aPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label aLabel = new Label();
            aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aLabel.Size = new System.Drawing.Size(330, 47);
            aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            aLabel.MouseEnter += new EventHandler((o, e) => { aLabel.Cursor = Cursors.Hand; });
            aLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "ambassadors", ambassadors));
            aLabel.Text = ambassadors.title;

            // Add to flowlayoutpanel
            aPanel.Controls.Add(aLabel);
            fp_resources.Controls.Add(aPanel);

            /**
             * Forms
             */
            // Create a panel 
            Panel fPanel = new Panel();
            fPanel.BackColor = System.Drawing.Color.Coral;
            fPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label fLabel = new Label();
            fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fLabel.Size = new System.Drawing.Size(330, 47);
            fLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            fLabel.MouseEnter += new EventHandler((o, e) => { fLabel.Cursor = Cursors.Hand; });
            fLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "forms", forms));
            fLabel.Text = "Forms";

            // Add to flowlayoutpanel
            fPanel.Controls.Add(fLabel);
            fp_resources.Controls.Add(fPanel);

            /**
             * Coop Enrollment
             */
            // Create a panel 
            Panel cPanel = new Panel();
            cPanel.BackColor = System.Drawing.Color.Coral;
            cPanel.Size = new System.Drawing.Size(330, 100);

            // Create label
            Label cLabel = new Label();
            cLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLabel.Size = new System.Drawing.Size(330, 47);
            cLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cLabel.MouseEnter += new EventHandler((o, e) => { cLabel.Cursor = Cursors.Hand; });
            cLabel.Click += new EventHandler((s, e) => resources_title_click(s, e, "coop", coop));
            cLabel.Text = coop.title;

            // Add to flowlayoutpanel
            cPanel.Controls.Add(cLabel);
            fp_resources.Controls.Add(cPanel);
        }

        /**
         * 'News' Setup
         */
        private void SetUpNews()
        {
            // Set title
            lbl_news_title.Text = "News";

            // Set subtitle
            lbl_news_subtitle.Text = "RIT in the News";

            // Change listview view type
            lv_news.View = View.Details;

            // Add columns
            lv_news.Columns.Add("Date");
            lv_news.Columns.Add("Title");
            lv_news.Columns.Add("Description");

            // Get news
            List<Older> o = news.older;
            for(int i=0; i<o.Count; i++)
            {
                // Add items
                string[] items = { o[i].date, o[i].title, o[i].description };
                ListViewItem row = new ListViewItem(items);
                lv_news.Items.Add(row);
            }

            // Autosize
            lv_news.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /**
         * 'Footer' Setup
         * 
         *  NOTE: for the sake of relevance, this section will be renamed to 'miscellaneous' in the tab section 
         */
        private void SetUpFooter()
        {
            // Set title
            lbl_footer_title.Text = "Miscellaneous";

            // Social
            Social s = footer.social;
            string social = s.title + " " + s.tweet + " " + s.by;
            lbl_footer_social_title.Text = social;

            // Set twitter label
            ll_twitter.Text = s.twitter;
            ll_twitter.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(s.twitter); }); 
            ll_facebook.Text = s.facebook;
            ll_facebook.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(s.facebook); });

            // Set links 
            List<QuickLink> q = footer.quickLinks;
            ll_apply.Text = q[0].href;
            ll_apply.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(q[0].href); });
            ll_about.Text = q[1].href;
            ll_about.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(q[1].href); });
            ll_support.Text = q[2].href;
            ll_support.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(q[2].href); });
            ll_hours.Text = q[3].href;
            ll_hours.LinkClicked += new LinkLabelLinkClickedEventHandler((o, e) => { System.Diagnostics.Process.Start(q[3].href); });
        }

        /**
         * GENERIC methods
         */
        private void degrees_title_click(object sender, EventArgs e, string name, List<string> extra)
        {
            new DegreesModal(name, extra).ShowDialog();
        }

        private void minors_title_click(object sender, EventArgs e, string title, string desc, List<string> courses)
        {
            new MinorsModal(title, desc, courses).ShowDialog();
        }

        private void employment_btn_click<T>(object sender, EventArgs e, string tableType, List<T> data) 
        {
            // Check tableType
            if(tableType == "coop")
            {
                // Coop button clicked
                new EmploymentModal(data as List<CoopInformation>).ShowDialog();
            }

            if(tableType == "employment")
            {
                // Employment button clicked
                new EmploymentModal(data as List<ProfessionalEmploymentInformation>).ShowDialog();
            }
        }

        private void people_title_click(object sender, EventArgs e, string name, List<string> info)
        {
            new PeopleModal(name, info).ShowDialog();
        }

        private void research_title_click(object sender, EventArgs e, string name, List<string> data)
        {
            new ResearchModal(name, data).ShowDialog();
        }

        private void resources_title_click(object sender, EventArgs e, string resourceType, object resource) {
            new ResourceModal(resourceType, resource).ShowDialog();
        }
    }
}
