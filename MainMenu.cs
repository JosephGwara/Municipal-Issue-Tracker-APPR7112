namespace Municipal_Issue_Tracker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            Hide();
        }

        private void logEventsBtn_Click(object sender, EventArgs e)
        {
            LocalEventsAndAnnouncements eventsAndAnnouncements = new LocalEventsAndAnnouncements();
            eventsAndAnnouncements.Show();
            Hide();
        }
    }


}
    

