namespace Municipal_Issue_Tracker
{
    partial class LocalEventsAndAnnouncements
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
            searchBox = new TextBox();
            search_btn = new Button();
            flowLayoutPanelEvents = new FlowLayoutPanel();
            comboBoxCategory = new ComboBox();
            dateTimePickerEventDate = new DateTimePicker();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(51, 21);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(349, 31);
            searchBox.TabIndex = 0;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(638, 21);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(112, 34);
            search_btn.TabIndex = 1;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // flowLayoutPanelEvents
            // 
            flowLayoutPanelEvents.Location = new Point(51, 70);
            flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            flowLayoutPanelEvents.Size = new Size(699, 449);
            flowLayoutPanelEvents.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Food", "Technology", "Art", "Music" });
            comboBoxCategory.Location = new Point(522, 21);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(110, 33);
            comboBoxCategory.TabIndex = 3;
            comboBoxCategory.Text = "Category";
            // 
            // dateTimePickerEventDate
            // 
            dateTimePickerEventDate.Location = new Point(406, 21);
            dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            dateTimePickerEventDate.Size = new Size(110, 31);
            dateTimePickerEventDate.TabIndex = 4;
            // 
            // LocalEventsAndAnnouncements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(dateTimePickerEventDate);
            Controls.Add(comboBoxCategory);
            Controls.Add(flowLayoutPanelEvents);
            Controls.Add(search_btn);
            Controls.Add(searchBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LocalEventsAndAnnouncements";
            Text = "Local Events And Announcements";
            Load += LocalEventsAndAnnouncements_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button search_btn;
        private FlowLayoutPanel flowLayoutPanelEvents;
        private ComboBox comboBoxCategory;
        private DateTimePicker dateTimePickerEventDate;
    }
}