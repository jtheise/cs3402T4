namespace ElectronicRoomScheduler.SidePanels
{
    partial class OrganizationsSidePanel
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
            this.linkLabelEditOrg = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddOrg = new System.Windows.Forms.LinkLabel();
            this.linkLabelDeleteOrg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(7, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(152, 15);
            this.labelHeader.TabIndex = 19;
            this.labelHeader.Text = "Manage Organizations";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelEditOrg
            // 
            this.linkLabelEditOrg.AutoSize = true;
            this.linkLabelEditOrg.Location = new System.Drawing.Point(9, 54);
            this.linkLabelEditOrg.Name = "linkLabelEditOrg";
            this.linkLabelEditOrg.Size = new System.Drawing.Size(87, 13);
            this.linkLabelEditOrg.TabIndex = 21;
            this.linkLabelEditOrg.TabStop = true;
            this.linkLabelEditOrg.Text = "Edit Organization";
            this.linkLabelEditOrg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelAddOrg
            // 
            this.linkLabelAddOrg.AutoSize = true;
            this.linkLabelAddOrg.Location = new System.Drawing.Point(9, 33);
            this.linkLabelAddOrg.Name = "linkLabelAddOrg";
            this.linkLabelAddOrg.Size = new System.Drawing.Size(88, 13);
            this.linkLabelAddOrg.TabIndex = 20;
            this.linkLabelAddOrg.TabStop = true;
            this.linkLabelAddOrg.Text = "Add Organization";
            this.linkLabelAddOrg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelDeleteOrg
            // 
            this.linkLabelDeleteOrg.AutoSize = true;
            this.linkLabelDeleteOrg.Location = new System.Drawing.Point(9, 75);
            this.linkLabelDeleteOrg.Name = "linkLabelDeleteOrg";
            this.linkLabelDeleteOrg.Size = new System.Drawing.Size(100, 13);
            this.linkLabelDeleteOrg.TabIndex = 22;
            this.linkLabelDeleteOrg.TabStop = true;
            this.linkLabelDeleteOrg.Text = "Delete Organization";
            this.linkLabelDeleteOrg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // OrganizationsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelDeleteOrg);
            this.Controls.Add(this.linkLabelEditOrg);
            this.Controls.Add(this.linkLabelAddOrg);
            this.Controls.Add(this.labelHeader);
            this.Name = "OrganizationsSidePanel";
            this.Size = new System.Drawing.Size(160, 600);
            this.Load += new System.EventHandler(this.OrganizationsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelEditOrg;
        private System.Windows.Forms.LinkLabel linkLabelAddOrg;
        private System.Windows.Forms.LinkLabel linkLabelDeleteOrg;

    }
}
