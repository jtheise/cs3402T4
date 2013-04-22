namespace ElectronicRoomScheduler.SidePanels
{
    partial class ReportsSidePanel
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.linkLabelLoadReport = new System.Windows.Forms.LinkLabel();
            this.linkLabelNewReport = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditReport = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddQuestion = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoadQuestion = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditQuestion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(19, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(113, 15);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "Manage Reports";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelLoadReport
            // 
            this.linkLabelLoadReport.AutoSize = true;
            this.linkLabelLoadReport.Location = new System.Drawing.Point(25, 54);
            this.linkLabelLoadReport.Name = "linkLabelLoadReport";
            this.linkLabelLoadReport.Size = new System.Drawing.Size(66, 13);
            this.linkLabelLoadReport.TabIndex = 17;
            this.linkLabelLoadReport.TabStop = true;
            this.linkLabelLoadReport.Text = "Load Report";
            this.linkLabelLoadReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelNewReport
            // 
            this.linkLabelNewReport.AutoSize = true;
            this.linkLabelNewReport.Location = new System.Drawing.Point(25, 33);
            this.linkLabelNewReport.Name = "linkLabelNewReport";
            this.linkLabelNewReport.Size = new System.Drawing.Size(64, 13);
            this.linkLabelNewReport.TabIndex = 16;
            this.linkLabelNewReport.TabStop = true;
            this.linkLabelNewReport.Text = "New Report";
            this.linkLabelNewReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelEditReport
            // 
            this.linkLabelEditReport.AutoSize = true;
            this.linkLabelEditReport.Location = new System.Drawing.Point(25, 75);
            this.linkLabelEditReport.Name = "linkLabelEditReport";
            this.linkLabelEditReport.Size = new System.Drawing.Size(60, 13);
            this.linkLabelEditReport.TabIndex = 18;
            this.linkLabelEditReport.TabStop = true;
            this.linkLabelEditReport.Text = "Edit Report";
            this.linkLabelEditReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelAddQuestion
            // 
            this.linkLabelAddQuestion.AutoSize = true;
            this.linkLabelAddQuestion.Location = new System.Drawing.Point(25, 106);
            this.linkLabelAddQuestion.Name = "linkLabelAddQuestion";
            this.linkLabelAddQuestion.Size = new System.Drawing.Size(71, 13);
            this.linkLabelAddQuestion.TabIndex = 19;
            this.linkLabelAddQuestion.TabStop = true;
            this.linkLabelAddQuestion.Text = "Add Question";
            this.linkLabelAddQuestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabelLoadQuestion
            // 
            this.linkLabelLoadQuestion.AutoSize = true;
            this.linkLabelLoadQuestion.Location = new System.Drawing.Point(25, 127);
            this.linkLabelLoadQuestion.Name = "linkLabelLoadQuestion";
            this.linkLabelLoadQuestion.Size = new System.Drawing.Size(76, 13);
            this.linkLabelLoadQuestion.TabIndex = 20;
            this.linkLabelLoadQuestion.TabStop = true;
            this.linkLabelLoadQuestion.Text = "Load Question";
            this.linkLabelLoadQuestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabelEditQuestion
            // 
            this.linkLabelEditQuestion.AutoSize = true;
            this.linkLabelEditQuestion.Location = new System.Drawing.Point(25, 148);
            this.linkLabelEditQuestion.Name = "linkLabelEditQuestion";
            this.linkLabelEditQuestion.Size = new System.Drawing.Size(70, 13);
            this.linkLabelEditQuestion.TabIndex = 21;
            this.linkLabelEditQuestion.TabStop = true;
            this.linkLabelEditQuestion.Text = "Edit Question";
            this.linkLabelEditQuestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // ReportsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelEditQuestion);
            this.Controls.Add(this.linkLabelLoadQuestion);
            this.Controls.Add(this.linkLabelAddQuestion);
            this.Controls.Add(this.linkLabelEditReport);
            this.Controls.Add(this.linkLabelLoadReport);
            this.Controls.Add(this.linkLabelNewReport);
            this.Controls.Add(this.labelHeader);
            this.Name = "ReportsSidePanel";
            this.Size = new System.Drawing.Size(150, 600);
            this.Load += new System.EventHandler(this.ReportsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelLoadReport;
        private System.Windows.Forms.LinkLabel linkLabelNewReport;
        private System.Windows.Forms.LinkLabel linkLabelEditReport;
        private System.Windows.Forms.LinkLabel linkLabelAddQuestion;
        private System.Windows.Forms.LinkLabel linkLabelLoadQuestion;
        private System.Windows.Forms.LinkLabel linkLabelEditQuestion;

    }
}
