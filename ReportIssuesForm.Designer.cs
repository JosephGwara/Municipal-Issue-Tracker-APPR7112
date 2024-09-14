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
            submitBtn.Location = new Point(461, 667);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(141, 34);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // attachMediaBtn
            // 
            attachMediaBtn.Location = new Point(12, 581);
            attachMediaBtn.Name = "attachMediaBtn";
            attachMediaBtn.Size = new Size(141, 34);
            attachMediaBtn.TabIndex = 4;
            attachMediaBtn.Text = "Attach Media";
            attachMediaBtn.UseVisualStyleBackColor = true;
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
            categoryBox.Location = new Point(12, 239);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(315, 33);
            categoryBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 7;
            label1.Text = "Location";
            // 
            // categoryDropDown
            // 
            categoryDropDown.AutoSize = true;
            categoryDropDown.Location = new Point(12, 211);
            categoryDropDown.Name = "categoryDropDown";
            categoryDropDown.Size = new Size(84, 25);
            categoryDropDown.TabIndex = 8;
            categoryDropDown.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 734);
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
    }
}