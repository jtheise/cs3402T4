namespace ElectronicRoomScheduler.SidePanels
{
    partial class BuildingsSidePanel
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
            this.linkLabelDeleteBuilding = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditBuilding = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddBuilding = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelHeader.Location = new System.Drawing.Point(19, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(123, 15);
            this.labelHeader.TabIndex = 9;
            this.labelHeader.Text = "Manage Buildings";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelDeleteBuilding
            // 
            this.linkLabelDeleteBuilding.AutoSize = true;
            this.linkLabelDeleteBuilding.Location = new System.Drawing.Point(22, 75);
            this.linkLabelDeleteBuilding.Name = "linkLabelDeleteBuilding";
            this.linkLabelDeleteBuilding.Size = new System.Drawing.Size(78, 13);
            this.linkLabelDeleteBuilding.TabIndex = 8;
            this.linkLabelDeleteBuilding.TabStop = true;
            this.linkLabelDeleteBuilding.Text = "Delete Building";
            this.linkLabelDeleteBuilding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelEditBuilding
            // 
            this.linkLabelEditBuilding.AutoSize = true;
            this.linkLabelEditBuilding.Location = new System.Drawing.Point(22, 54);
            this.linkLabelEditBuilding.Name = "linkLabelEditBuilding";
            this.linkLabelEditBuilding.Size = new System.Drawing.Size(65, 13);
            this.linkLabelEditBuilding.TabIndex = 7;
            this.linkLabelEditBuilding.TabStop = true;
            this.linkLabelEditBuilding.Text = "Edit Building";
            this.linkLabelEditBuilding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelAddBuilding
            // 
            this.linkLabelAddBuilding.AutoSize = true;
            this.linkLabelAddBuilding.Location = new System.Drawing.Point(22, 33);
            this.linkLabelAddBuilding.Name = "linkLabelAddBuilding";
            this.linkLabelAddBuilding.Size = new System.Drawing.Size(66, 13);
            this.linkLabelAddBuilding.TabIndex = 6;
            this.linkLabelAddBuilding.TabStop = true;
            this.linkLabelAddBuilding.Text = "Add Building";
            this.linkLabelAddBuilding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BuildingsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.linkLabelDeleteBuilding);
            this.Controls.Add(this.linkLabelEditBuilding);
            this.Controls.Add(this.linkLabelAddBuilding);
            this.Name = "BuildingsSidePanel";
            this.Size = new System.Drawing.Size(160, 600);
            this.Load += new System.EventHandler(this.BuildingsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelDeleteBuilding;
        private System.Windows.Forms.LinkLabel linkLabelEditBuilding;
        private System.Windows.Forms.LinkLabel linkLabelAddBuilding;
    }
}
