using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DemoExamin
{
    public partial class AddRequestForm : Form
    {
        private RequestManager requestManager;

        public AddRequestForm(RequestManager requestManager)
        {
            InitializeComponent();
            this.requestManager = requestManager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Логика для сохранения новой заявки
            Request newRequest = new Request
            {
                Number = int.Parse(txtNumber.Text),
                DateAdded = DateTime.Now,
                Equipment = txtEquipment.Text,
                IssueType = txtIssueType.Text,
                Description = txtDescription.Text,
                Client = txtClient.Text,
                Status = "в ожидании", // Начальный статус
                Responsible = txtResponsible.Text,
                Comments = txtComments.Text
            };

            requestManager.AddRequest(newRequest);
            MessageBox.Show("Заявка добавлена успешно");
            this.Close();
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}

