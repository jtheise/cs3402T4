namespace ElectronicRoomScheduler.Screens
{
    partial class EditReportScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadReport = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxQuestionInformation = new System.Windows.Forms.ListBox();
            this.checkedListBoxQuestionPicker = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReportId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadReport);
            this.groupBox1.Controls.Add(this.buttonSaveReport);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxReportId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Data";
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.Location = new System.Drawing.Point(115, 10);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(75, 25);
            this.buttonLoadReport.TabIndex = 2;
            this.buttonLoadReport.Text = "Load";
            this.buttonLoadReport.UseVisualStyleBackColor = true;
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(546, 299);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveReport.TabIndex = 5;
            this.buttonSaveReport.Text = "Save";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.listBoxQuestionInformation);
            this.groupBox2.Controls.Add(this.checkedListBoxQuestionPicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 255);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Questions Information";
            // 
            // listBoxQuestionInformation
            // 
            this.listBoxQuestionInformation.FormattingEnabled = true;
            this.listBoxQuestionInformation.Location = new System.Drawing.Point(165, 32);
            this.listBoxQuestionInformation.Name = "listBoxQuestionInformation";
            this.listBoxQuestionInformation.Size = new System.Drawing.Size(426, 199);
            this.listBoxQuestionInformation.TabIndex = 4;
            // 
            // checkedListBoxQuestionPicker
            // 
            this.checkedListBoxQuestionPicker.FormattingEnabled = true;
            this.checkedListBoxQuestionPicker.Items.AddRange(new object[] {
            "Q1 Name",
            "Q2 Name",
            "Q3 Name",
            "Q4 Name"});
            this.checkedListBoxQuestionPicker.Location = new System.Drawing.Point(9, 32);
            this.checkedListBoxQuestionPicker.Name = "checkedListBoxQuestionPicker";
            this.checkedListBoxQuestionPicker.Size = new System.Drawing.Size(150, 199);
            this.checkedListBoxQuestionPicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pick Questions to Run";
            // 
            // textBoxReportId
            // 
            this.textBoxReportId.Location = new System.Drawing.Point(30, 13);
            this.textBoxReportId.Name = "textBoxReportId";
            this.textBoxReportId.Size = new System.Drawing.Size(79, 20);
            this.textBoxReportId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EditReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditReportScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditReportScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoadReport;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxQuestionInformation;
        private System.Windows.Forms.CheckedListBox checkedListBoxQuestionPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReportId;
        private System.Windows.Forms.Label label1;
    }
}
