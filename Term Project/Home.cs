namespace Term_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (LoginScreen.privlages != "simteam")
            {
                button6.Location = new Point(317, 391);
                button5.Hide();
            }
            else
            {
                button5.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportz frm = new reportz();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportz frm = new reportz();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportz frm = new reportz();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SimTeamPage teamActionPage = new SimTeamPage();
            teamActionPage.Location = this.Location;
            teamActionPage.StartPosition = FormStartPosition.Manual;
            teamActionPage.FormClosing += delegate { this.Show(); };
            teamActionPage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Location = this.Location;
            loginScreen.StartPosition = FormStartPosition.Manual;
            loginScreen.FormClosing += delegate { this.Show(); };
            loginScreen.Show();
            this.Hide();
        }
    }
}