namespace ElectronicRoomScheduler.SidePanels
{
    partial class EventsSidePanel
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
            this.linkLabelDeleteEvent = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditEvent = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddEvent = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelHeader.Location = new System.Drawing.Point(23, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(105, 15);
            this.labelHeader.TabIndex = 18;
            this.labelHeader.Text = "Manage Events";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // linkLabelDeleteEvent
            // 
            this.linkLabelDeleteEvent.AutoSize = true;
            this.linkLabelDeleteEvent.Location = new System.Drawing.Point(28, 75);
            this.linkLabelDeleteEvent.Name = "linkLabelDeleteEvent";
            this.linkLabelDeleteEvent.Size = new System.Drawing.Size(69, 13);
            this.linkLabelDeleteEvent.TabIndex = 21;
            this.linkLabelDeleteEvent.TabStop = true;
            this.linkLabelDeleteEvent.Text = "Delete Event";
            this.linkLabelDeleteEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelEditEvent
            // 
            this.linkLabelEditEvent.AutoSize = true;
            this.linkLabelEditEvent.Location = new System.Drawing.Point(28, 54);
            this.linkLabelEditEvent.Name = "linkLabelEditEvent";
            this.linkLabelEditEvent.Size = new System.Drawing.Size(56, 13);
            this.linkLabelEditEvent.TabIndex = 20;
            this.linkLabelEditEvent.TabStop = true;
            this.linkLabelEditEvent.Text = "Edit Event";
            this.linkLabelEditEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelAddEvent
            // 
            this.linkLabelAddEvent.AutoSize = true;
            this.linkLabelAddEvent.Location = new System.Drawing.Point(28, 33);
            this.linkLabelAddEvent.Name = "linkLabelAddEvent";
            this.linkLabelAddEvent.Size = new System.Drawing.Size(57, 13);
            this.linkLabelAddEvent.TabIndex = 19;
            this.linkLabelAddEvent.TabStop = true;
            this.linkLabelAddEvent.Text = "Add Event";
            this.linkLabelAddEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EventsSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelDeleteEvent);
            this.Controls.Add(this.linkLabelEditEvent);
            this.Controls.Add(this.linkLabelAddEvent);
            this.Controls.Add(this.labelHeader);
            this.Name = "EventsSidePanel";
            this.Size = new System.Drawing.Size(150, 600);
            this.Load += new System.EventHandler(this.EventsSidePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        public System.Windows.Forms.LinkLabel linkLabelDeleteEvent;
        public System.Windows.Forms.LinkLabel linkLabelEditEvent;
        private System.Windows.Forms.LinkLabel linkLabelAddEvent;

    }
}
