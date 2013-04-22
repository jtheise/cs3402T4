namespace ElectronicRoomScheduler.SidePanels
{
    partial class NotificationsSidePanel
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
            this.linkLabelSetPrep = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditAlert = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddAlert = new System.Windows.Forms.LinkLabel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelSetPrep
            // 
            this.linkLabelSetPrep.AutoSize = true;
            this.linkLabelSetPrep.Location = new System.Drawing.Point(12, 80);
            this.linkLabelSetPrep.Name = "linkLabelSetPrep";
            this.linkLabelSetPrep.Size = new System.Drawing.Size(79, 26);
            this.linkLabelSetPrep.TabIndex = 20;
            this.linkLabelSetPrep.TabStop = true;
            this.linkLabelSetPrep.Text = "Set Notification\r\nPreferences";
            this.linkLabelSetPrep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSetPrep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelEditAlert
            // 
            this.linkLabelEditAlert.AutoSize = true;
            this.linkLabelEditAlert.Location = new System.Drawing.Point(12, 54);
            this.linkLabelEditAlert.Name = "linkLabelEditAlert";
            this.linkLabelEditAlert.Size = new System.Drawing.Size(49, 13);
            this.linkLabelEditAlert.TabIndex = 19;
            this.linkLabelEditAlert.TabStop = true;
            this.linkLabelEditAlert.Text = "Edit Alert";
            this.linkLabelEditAlert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelAddAlert
            // 
            this.linkLabelAddAlert.AutoSize = true;
            this.linkLabelAddAlert.Location = new System.Drawing.Point(12, 33);
            this.linkLabelAddAlert.Name = "linkLabelAddAlert";
            this.linkLabelAddAlert.Size = new System.Drawing.Size(50, 13);
            this.linkLabelAddAlert.TabIndex = 18;
            this.linkLabelAddAlert.TabStop = true;
            this.linkLabelAddAlert.Text = "Add Alert";
            this.linkLabelAddAlert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelHeader.Location = new System.Drawing.Point(9, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(143, 15);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Text = "Manage Notifications";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // NotificationsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelSetPrep);
            this.Controls.Add(this.linkLabelEditAlert);
            this.Controls.Add(this.linkLabelAddAlert);
            this.Controls.Add(this.labelHeader);
            this.Name = "NotificationsSidePanel";
            this.Size = new System.Drawing.Size(160, 600);
            this.Load += new System.EventHandler(this.NotificationsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelSetPrep;
        private System.Windows.Forms.LinkLabel linkLabelEditAlert;
        private System.Windows.Forms.LinkLabel linkLabelAddAlert;
        private System.Windows.Forms.Label labelHeader;

    }
}
