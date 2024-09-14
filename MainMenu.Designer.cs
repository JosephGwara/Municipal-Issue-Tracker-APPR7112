namespace Municipal_Issue_Tracker
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            reportIssuesBtn = new Button();
            logEventsBtn = new Button();
            serviceRequestStatusBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "ISSUE REPORTER";
            label1.Click += label1_Click;
            // 
            // reportIssuesBtn
            // 
            reportIssuesBtn.Location = new Point(224, 234);
            reportIssuesBtn.Name = "reportIssuesBtn";
            reportIssuesBtn.Size = new Size(336, 34);
            reportIssuesBtn.TabIndex = 1;
            reportIssuesBtn.Text = "Report Issues";
            reportIssuesBtn.UseVisualStyleBackColor = true;
            reportIssuesBtn.Click += button1_Click;
            // 
            // logEventsBtn
            // 
            logEventsBtn.Location = new Point(224, 309);
            logEventsBtn.Name = "logEventsBtn";
            logEventsBtn.Size = new Size(336, 34);
            logEventsBtn.TabIndex = 2;
            logEventsBtn.Text = "Local Events and Announcements";
            logEventsBtn.UseVisualStyleBackColor = true;
            // 
            // serviceRequestStatusBtn
            // 
            serviceRequestStatusBtn.Location = new Point(224, 380);
            serviceRequestStatusBtn.Name = "serviceRequestStatusBtn";
            serviceRequestStatusBtn.Size = new Size(336, 34);
            serviceRequestStatusBtn.TabIndex = 3;
            serviceRequestStatusBtn.Text = "Service Request Status";
            serviceRequestStatusBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 598);
            Controls.Add(serviceRequestStatusBtn);
            Controls.Add(logEventsBtn);
            Controls.Add(reportIssuesBtn);
            Controls.Add(label1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipality Issue Reports";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button reportIssuesBtn;
        private Button logEventsBtn;
        private Button serviceRequestStatusBtn;
    }
}
