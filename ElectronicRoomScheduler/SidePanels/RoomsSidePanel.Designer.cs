namespace ElectronicRoomScheduler.SidePanels
{
    partial class RoomsSidePanel
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
            this.linkLabelRequestTech = new System.Windows.Forms.LinkLabel();
            this.linkLabelDelete = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditRoom = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddRoom = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(21, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(108, 15);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Manage Rooms";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelRequestTech
            // 
            this.linkLabelRequestTech.AutoSize = true;
            this.linkLabelRequestTech.Location = new System.Drawing.Point(22, 96);
            this.linkLabelRequestTech.Name = "linkLabelRequestTech";
            this.linkLabelRequestTech.Size = new System.Drawing.Size(106, 13);
            this.linkLabelRequestTech.TabIndex = 17;
            this.linkLabelRequestTech.TabStop = true;
            this.linkLabelRequestTech.Text = "Request Technology";
            this.linkLabelRequestTech.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRequestTech_LinkClicked);
            // 
            // linkLabelDelete
            // 
            this.linkLabelDelete.AutoSize = true;
            this.linkLabelDelete.Location = new System.Drawing.Point(22, 75);
            this.linkLabelDelete.Name = "linkLabelDelete";
            this.linkLabelDelete.Size = new System.Drawing.Size(69, 13);
            this.linkLabelDelete.TabIndex = 16;
            this.linkLabelDelete.TabStop = true;
            this.linkLabelDelete.Text = "Delete Room";
            this.linkLabelDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelEditRoom
            // 
            this.linkLabelEditRoom.AutoSize = true;
            this.linkLabelEditRoom.Location = new System.Drawing.Point(22, 54);
            this.linkLabelEditRoom.Name = "linkLabelEditRoom";
            this.linkLabelEditRoom.Size = new System.Drawing.Size(56, 13);
            this.linkLabelEditRoom.TabIndex = 15;
            this.linkLabelEditRoom.TabStop = true;
            this.linkLabelEditRoom.Text = "Edit Room";
            this.linkLabelEditRoom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelAddRoom
            // 
            this.linkLabelAddRoom.AutoSize = true;
            this.linkLabelAddRoom.Location = new System.Drawing.Point(22, 33);
            this.linkLabelAddRoom.Name = "linkLabelAddRoom";
            this.linkLabelAddRoom.Size = new System.Drawing.Size(57, 13);
            this.linkLabelAddRoom.TabIndex = 14;
            this.linkLabelAddRoom.TabStop = true;
            this.linkLabelAddRoom.Text = "Add Room";
            this.linkLabelAddRoom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RoomsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelRequestTech);
            this.Controls.Add(this.linkLabelDelete);
            this.Controls.Add(this.linkLabelEditRoom);
            this.Controls.Add(this.linkLabelAddRoom);
            this.Controls.Add(this.labelHeader);
            this.Name = "RoomsSidePanel";
            this.Size = new System.Drawing.Size(150, 600);
            this.Load += new System.EventHandler(this.RoomsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelRequestTech;
        private System.Windows.Forms.LinkLabel linkLabelDelete;
        private System.Windows.Forms.LinkLabel linkLabelEditRoom;
        private System.Windows.Forms.LinkLabel linkLabelAddRoom;
    }
}
