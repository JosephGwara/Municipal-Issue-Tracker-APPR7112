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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            Hide();
        }

        private void LogEventsBtn_Click(object sender, EventArgs e)
        {
            LocalEventsAndAnnouncements eventsAndAnnouncements = new LocalEventsAndAnnouncements();
            eventsAndAnnouncements.Show();
            Hide();
        }

        private void ServiceRequestStatusBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm serviceRequestStatusForm = new ServiceRequestStatusForm();
            serviceRequestStatusForm.Show();
            Hide();

        }
    }


}
    

