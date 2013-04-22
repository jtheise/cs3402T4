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
            this.linkLabelAddClass = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditClass = new System.Windows.Forms.LinkLabel();
            this.linkLabelDelClass = new System.Windows.Forms.LinkLabel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.linkLabelAssignRooms = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditRooms = new System.Windows.Forms.LinkLabel();
            this.linkLabelAutoAssignRooms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelAddClass
            // 
            this.linkLabelAddClass.AutoSize = true;
            this.linkLabelAddClass.Location = new System.Drawing.Point(26, 33);
            this.linkLabelAddClass.Name = "linkLabelAddClass";
            this.linkLabelAddClass.Size = new System.Drawing.Size(54, 13);
            this.linkLabelAddClass.TabIndex = 0;
            this.linkLabelAddClass.TabStop = true;
            this.linkLabelAddClass.Text = "Add Class";
            this.linkLabelAddClass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelEditClass
            // 
            this.linkLabelEditClass.AutoSize = true;
            this.linkLabelEditClass.Location = new System.Drawing.Point(26, 54);
            this.linkLabelEditClass.Name = "linkLabelEditClass";
            this.linkLabelEditClass.Size = new System.Drawing.Size(53, 13);
            this.linkLabelEditClass.TabIndex = 1;
            this.linkLabelEditClass.TabStop = true;
            this.linkLabelEditClass.Text = "Edit Class";
            this.linkLabelEditClass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelDelClass
            // 
            this.linkLabelDelClass.AutoSize = true;
            this.linkLabelDelClass.Location = new System.Drawing.Point(26, 75);
            this.linkLabelDelClass.Name = "linkLabelDelClass";
            this.linkLabelDelClass.Size = new System.Drawing.Size(66, 13);
            this.linkLabelDelClass.TabIndex = 2;
            this.linkLabelDelClass.TabStop = true;
            this.linkLabelDelClass.Text = "Delete Class";
            this.linkLabelDelClass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelHeader.Location = new System.Drawing.Point(19, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(113, 15);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Manage Classes";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelAssignRooms
            // 
            this.linkLabelAssignRooms.AutoSize = true;
            this.linkLabelAssignRooms.Location = new System.Drawing.Point(26, 116);
            this.linkLabelAssignRooms.Name = "linkLabelAssignRooms";
            this.linkLabelAssignRooms.Size = new System.Drawing.Size(69, 13);
            this.linkLabelAssignRooms.TabIndex = 4;
            this.linkLabelAssignRooms.TabStop = true;
            this.linkLabelAssignRooms.Text = "Assign Room";
            this.linkLabelAssignRooms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAssignRooms_LinkClicked);
            // 
            // linkLabelEditRooms
            // 
            this.linkLabelEditRooms.AutoSize = true;
            this.linkLabelEditRooms.Location = new System.Drawing.Point(26, 137);
            this.linkLabelEditRooms.Name = "linkLabelEditRooms";
            this.linkLabelEditRooms.Size = new System.Drawing.Size(56, 13);
            this.linkLabelEditRooms.TabIndex = 5;
            this.linkLabelEditRooms.TabStop = true;
            this.linkLabelEditRooms.Text = "Edit Room";
            this.linkLabelEditRooms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditRooms_LinkClicked);
            // 
            // linkLabelAutoAssignRooms
            // 
            this.linkLabelAutoAssignRooms.AutoSize = true;
            this.linkLabelAutoAssignRooms.Location = new System.Drawing.Point(26, 312);
            this.linkLabelAutoAssignRooms.Name = "linkLabelAutoAssignRooms";
            this.linkLabelAutoAssignRooms.Size = new System.Drawing.Size(74, 26);
            this.linkLabelAutoAssignRooms.TabIndex = 6;
            this.linkLabelAutoAssignRooms.TabStop = true;
            this.linkLabelAutoAssignRooms.Text = "Automatically\r\nAssign Rooms";
            this.linkLabelAutoAssignRooms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // ClassSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelAutoAssignRooms);
            this.Controls.Add(this.linkLabelEditRooms);
            this.Controls.Add(this.linkLabelAssignRooms);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.linkLabelDelClass);
            this.Controls.Add(this.linkLabelEditClass);
            this.Controls.Add(this.linkLabelAddClass);
            this.Name = "ClassSidePanel";
            this.Size = new System.Drawing.Size(150, 600);
            this.Load += new System.EventHandler(this.ClassSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelAddClass;
        private System.Windows.Forms.LinkLabel linkLabelEditClass;
        private System.Windows.Forms.LinkLabel linkLabelDelClass;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.LinkLabel linkLabelAssignRooms;
        private System.Windows.Forms.LinkLabel linkLabelEditRooms;
        private System.Windows.Forms.LinkLabel linkLabelAutoAssignRooms;
    }
}
