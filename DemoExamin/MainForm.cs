using System;
using System.Windows.Forms;

namespace DemoExamin
{
    public partial class MainForm : Form
    {
        private RequestManager requestManager;
        private ViewRequestsForm viewRequestsForm;

        public MainForm()
        {
            InitializeComponent();
            requestManager = new RequestManager();
            viewRequestsForm = new ViewRequestsForm(requestManager);
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            AddRequestForm addRequestForm = new AddRequestForm(requestManager);
            addRequestForm.Show();
        }

        private void btnViewRequests_Click(object sender, EventArgs e)
        {
            viewRequestsForm.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(requestManager);
            statisticsForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            SearchRequests(searchTerm);
        }

        private void SearchRequests(string searchTerm)
        {
            var foundRequests = requestManager.SearchRequests(searchTerm);
            viewRequestsForm.UpdateRequestList(foundRequests);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

