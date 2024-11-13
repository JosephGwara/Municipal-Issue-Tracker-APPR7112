using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Municipal_Issue_Tracker.ServiceRequest;

namespace Municipal_Issue_Tracker
{
    public partial class ServiceRequestStatusForm : Form
    {
        private BinarySearchTree bst = new BinarySearchTree();
        private MinHeap minHeap = new MinHeap();

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSampleData();
            DisplayRequests();
          
        }

        private void LoadSampleData()
        {
          
            var request1 = new ServiceRequest(1, "Road repair needed", "Pending");
            var request2 = new ServiceRequest(2, "Water leakage", "In Progress");
            var request3 = new ServiceRequest(3, "Garbage collection", "Completed");

           
            bst.Insert(request1);
            bst.Insert(request2);
            bst.Insert(request3);

            minHeap.Insert(request1);
            minHeap.Insert(request2);
            minHeap.Insert(request3);
        }
        private void InitializeDataGridView()
        {
            requestsDataGridView.Columns.Clear(); 

            requestsDataGridView.Columns.Add("Id", "Request ID");
            requestsDataGridView.Columns.Add("Description", "Description");
            requestsDataGridView.Columns.Add("Status", "Status");

            requestsDataGridView.Columns["Id"].DataPropertyName = "Id";
            requestsDataGridView.Columns["Description"].DataPropertyName = "Description";
            requestsDataGridView.Columns["Status"].DataPropertyName = "Status";

            
            requestsDataGridView.AutoGenerateColumns = false;
        }
        private void DisplayRequests()
        {
            requestsDataGridView.Rows.Clear();
            DisplayRequests(bst.Root);
        }

        private void DisplayRequests(BSTNode node)
        {
            if (node == null) return;

            DisplayRequests(node.Left);
            requestsDataGridView.Rows.Add(node.Data.RequestId, node.Data.Description, node.Data.Status);
            DisplayRequests(node.Right);
        }

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int requestId;
            if (int.TryParse(textBox1.Text, out requestId))
            {
                var request = bst.Search(requestId);

                if (request != null)
                {
                    MessageBox.Show($"Request ID: {request.RequestId}\nDescription: {request.Description}\nStatus: {request.Status}", "Service Request Details");
                }
                else
                {
                    MessageBox.Show("Service Request not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Input Error");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
