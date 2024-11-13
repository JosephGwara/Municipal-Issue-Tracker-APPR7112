namespace Municipal_Issue_Tracker
{
    partial class ServiceRequestStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            requestsDataGridView = new DataGridView();
            backBtn = new Button();
            textBox1 = new TextBox();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // requestsDataGridView
            // 
            requestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsDataGridView.Location = new Point(12, 50);
            requestsDataGridView.Name = "requestsDataGridView";
            requestsDataGridView.RowHeadersWidth = 62;
            requestsDataGridView.Size = new Size(766, 322);
            requestsDataGridView.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 10);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 34);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 426);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(12, 463);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(112, 34);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += button2_Click;
            // 
            // ServiceRequestStatusForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            Controls.Add(backBtn);
            Controls.Add(requestsDataGridView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServiceRequestStatusForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Request Status Form";
            Load += ServiceRequestStatusForm_Load;
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView requestsDataGridView;
        private Button backBtn;
        private TextBox textBox1;
        private Button searchBtn;
    }
}