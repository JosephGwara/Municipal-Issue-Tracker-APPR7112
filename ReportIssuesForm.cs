using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Issue_Tracker
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void locationInputTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void attachMediaBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*", // File type filters
                Title = "Select a Media File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                selectedFileTxt.Visible = true;
                selectedFileTxt.Text = filePath;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            clearErrors();
            string location = locationInputTxt.Text.ToString();
            string selectedItem = "";
            string description = descriptionBoxTxt.Text.ToString();

            if (categoryBox.SelectedItem != null)
            {
             selectedItem = categoryBox.SelectedItem.ToString();
          
            }
            else
            {
                categoryErrorTxt.Visible = true;
                categoryErrorTxt.Text = "No category selected. please select a category";
                
            }
           
            if(string.IsNullOrEmpty(location))
            {
                locationErrorTxt.Visible = true;
                locationErrorTxt.Text = "No location entered. Please enter a location";
            }
            if (string.IsNullOrEmpty(description))
            { 
            descriptionErrorTxt.Visible = true;
                descriptionErrorTxt.Text = "No description entered. Please enter a description";
            }

            if (!string.IsNullOrEmpty(location) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(selectedItem))
            {
                clearData();
                MessageBox.Show("Report completed");
            }
         
        }

        private void clearErrors()
        {
            locationErrorTxt.Visible = false;
            categoryErrorTxt.Visible = false;
            descriptionErrorTxt.Visible = false;

        }
        private void clearData()
        {
            locationInputTxt.Text = string.Empty;
            categoryBox.SelectedItem = null;
            descriptionBoxTxt.Text = string.Empty;
            selectedFileTxt.Text = string.Empty;
            selectedFileTxt.Visible = false;
        }
    }
}
