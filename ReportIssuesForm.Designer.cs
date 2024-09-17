namespace Municipal_Issue_Tracker
{
    partial class ReportIssuesForm
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
            locationInputTxt = new TextBox();
            backBtn = new Button();
            progressBar1 = new ProgressBar();
            submitBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            attachMediaBtn = new Button();
            descriptionBoxTxt = new RichTextBox();
            categoryBox = new ComboBox();
            label1 = new Label();
            categoryDropDown = new Label();
            label2 = new Label();
            selectedFileTxt = new Label();
            locationErrorTxt = new Label();
            categoryErrorTxt = new Label();
            descriptionErrorTxt = new Label();
            SuspendLayout();
            // 
            // locationInputTxt
            // 
            locationInputTxt.Location = new Point(12, 141);
            locationInputTxt.Name = "locationInputTxt";
            locationInputTxt.Size = new Size(315, 31);
            locationInputTxt.TabIndex = 0;
            locationInputTxt.TextChanged += locationInputTxt_TextChanged;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(141, 34);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(374, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(236, 10);
            progressBar1.TabIndex = 2;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(461, 688);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(141, 34);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // attachMediaBtn
            // 
            attachMediaBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attachMediaBtn.Location = new Point(10, 611);
            attachMediaBtn.Name = "attachMediaBtn";
            attachMediaBtn.Size = new Size(141, 34);
            attachMediaBtn.TabIndex = 4;
            attachMediaBtn.Text = "Attach Media";
            attachMediaBtn.UseVisualStyleBackColor = true;
            attachMediaBtn.Click += attachMediaBtn_Click;
            // 
            // descriptionBoxTxt
            // 
            descriptionBoxTxt.Location = new Point(12, 343);
            descriptionBoxTxt.Name = "descriptionBoxTxt";
            descriptionBoxTxt.Size = new Size(590, 217);
            descriptionBoxTxt.TabIndex = 5;
            descriptionBoxTxt.Text = "";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Electricity", "Water Supply", "Electricity" });
            categoryBox.Location = new Point(12, 239);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(315, 33);
            categoryBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 7;
            label1.Text = "Location";
            // 
            // categoryDropDown
            // 
            categoryDropDown.AutoSize = true;
            categoryDropDown.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryDropDown.Location = new Point(12, 211);
            categoryDropDown.Name = "categoryDropDown";
            categoryDropDown.Size = new Size(98, 28);
            categoryDropDown.TabIndex = 8;
            categoryDropDown.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // selectedFileTxt
            // 
            selectedFileTxt.AutoSize = true;
            selectedFileTxt.Location = new Point(12, 648);
            selectedFileTxt.Name = "selectedFileTxt";
            selectedFileTxt.Size = new Size(139, 25);
            selectedFileTxt.TabIndex = 10;
            selectedFileTxt.Text = "selectedFileHere";
            selectedFileTxt.Visible = false;
            // 
            // locationErrorTxt
            // 
            locationErrorTxt.AutoSize = true;
            locationErrorTxt.ForeColor = Color.Red;
            locationErrorTxt.Location = new Point(10, 172);
            locationErrorTxt.Name = "locationErrorTxt";
            locationErrorTxt.Size = new Size(113, 25);
            locationErrorTxt.TabIndex = 11;
            locationErrorTxt.Text = "locationError";
            locationErrorTxt.Visible = false;
            // 
            // categoryErrorTxt
            // 
            categoryErrorTxt.AutoSize = true;
            categoryErrorTxt.ForeColor = Color.Red;
            categoryErrorTxt.Location = new Point(12, 275);
            categoryErrorTxt.Name = "categoryErrorTxt";
            categoryErrorTxt.Size = new Size(122, 25);
            categoryErrorTxt.TabIndex = 12;
            categoryErrorTxt.Text = "CategoryError";
            categoryErrorTxt.Visible = false;
            // 
            // descriptionErrorTxt
            // 
            descriptionErrorTxt.AutoSize = true;
            descriptionErrorTxt.ForeColor = Color.Red;
            descriptionErrorTxt.Location = new Point(12, 564);
            descriptionErrorTxt.Name = "descriptionErrorTxt";
            descriptionErrorTxt.Size = new Size(138, 25);
            descriptionErrorTxt.TabIndex = 13;
            descriptionErrorTxt.Text = "descriptionError";
            descriptionErrorTxt.Visible = false;
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(622, 734);
            Controls.Add(descriptionErrorTxt);
            Controls.Add(categoryErrorTxt);
            Controls.Add(locationErrorTxt);
            Controls.Add(selectedFileTxt);
            Controls.Add(label2);
            Controls.Add(categoryDropDown);
            Controls.Add(label1);
            Controls.Add(categoryBox);
            Controls.Add(descriptionBoxTxt);
            Controls.Add(attachMediaBtn);
            Controls.Add(submitBtn);
            Controls.Add(progressBar1);
            Controls.Add(backBtn);
            Controls.Add(locationInputTxt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReportIssuesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REPORT ISSUES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationInputTxt;
        private Button backBtn;
        private ProgressBar progressBar1;
        private Button submitBtn;
        private OpenFileDialog openFileDialog1;
        private Button attachMediaBtn;
        private RichTextBox descriptionBoxTxt;
        private ComboBox categoryBox;
        private Label label1;
        private Label categoryDropDown;
        private Label label2;
        private Label selectedFileTxt;
        private Label locationErrorTxt;
        private Label categoryErrorTxt;
        private Label descriptionErrorTxt;
    }
}