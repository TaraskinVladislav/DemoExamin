using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoExamin
{
    public partial class StatisticsForm : Form
    {
        private RequestManager requestManager;

        public StatisticsForm(RequestManager requestManager)
        {
            InitializeComponent();
            this.requestManager = requestManager;
            DisplayStatistics();
        }

        private void DisplayStatistics()
        {
            int completedRequests = requestManager.Requests.Count(r => r.Status == "выполнено");
            lblCompletedRequests.Text = $"Количество выполненных заявок: {completedRequests}";

            double averageCompletionTime = requestManager.Requests
                .Where(r => r.Status == "выполнено")
                .Average(r => (DateTime.Now - r.DateAdded).TotalHours);
            lblAverageCompletionTime.Text = $"Среднее время выполнения заявки: {averageCompletionTime:F2} часов";
        }
    }
}
