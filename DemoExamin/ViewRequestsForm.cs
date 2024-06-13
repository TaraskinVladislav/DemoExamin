using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoExamin
{
    public partial class ViewRequestsForm : Form
    {
        private RequestManager requestManager;

        public ViewRequestsForm(RequestManager requestManager)
        {
            InitializeComponent();
            this.requestManager = requestManager;
            UpdateRequestList(requestManager.Requests);
        }

        public void UpdateRequestList(List<Request> requests)
        {
            dataGridViewRequests.DataSource = null;
            dataGridViewRequests.DataSource = requests;
        }
    }
}
