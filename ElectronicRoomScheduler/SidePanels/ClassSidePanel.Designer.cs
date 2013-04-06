namespace ElectronicRoomScheduler.SidePanels
{
    partial class ClassSidePanel
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.linkLabelAssignRooms = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditRooms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Class";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 56);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Edit Class";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(12, 73);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(66, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Delete Class";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(99, 13);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Manage Classes";
            // 
            // linkLabelAssignRooms
            // 
            this.linkLabelAssignRooms.AutoSize = true;
            this.linkLabelAssignRooms.Location = new System.Drawing.Point(12, 104);
            this.linkLabelAssignRooms.Name = "linkLabelAssignRooms";
            this.linkLabelAssignRooms.Size = new System.Drawing.Size(74, 13);
            this.linkLabelAssignRooms.TabIndex = 4;
            this.linkLabelAssignRooms.TabStop = true;
            this.linkLabelAssignRooms.Text = "Assign Rooms";
            this.linkLabelAssignRooms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAssignRooms_LinkClicked);
            // 
            // linkLabelEditRooms
            // 
            this.linkLabelEditRooms.AutoSize = true;
            this.linkLabelEditRooms.Location = new System.Drawing.Point(12, 121);
            this.linkLabelEditRooms.Name = "linkLabelEditRooms";
            this.linkLabelEditRooms.Size = new System.Drawing.Size(56, 13);
            this.linkLabelEditRooms.TabIndex = 5;
            this.linkLabelEditRooms.TabStop = true;
            this.linkLabelEditRooms.Text = "Edit Room";
            this.linkLabelEditRooms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditRooms_LinkClicked);
            // 
            // ClassSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelEditRooms);
            this.Controls.Add(this.linkLabelAssignRooms);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "ClassSidePanel";
            this.Size = new System.Drawing.Size(160, 600);
            this.Load += new System.EventHandler(this.ClassSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelAssignRooms;
        private System.Windows.Forms.LinkLabel linkLabelEditRooms;
    }
}
