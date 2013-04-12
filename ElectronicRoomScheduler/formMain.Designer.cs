namespace ElectronicRoomScheduler
{
    partial class FormMain
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
            this.containerTopBottom = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.buttonBuildings = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonNotifications = new System.Windows.Forms.Button();
            this.buttonOrganizations = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.containerLeftRight = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.containerTopBottom)).BeginInit();
            this.containerTopBottom.Panel1.SuspendLayout();
            this.containerTopBottom.Panel2.SuspendLayout();
            this.containerTopBottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerLeftRight)).BeginInit();
            this.containerLeftRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerTopBottom
            // 
            this.containerTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.containerTopBottom.IsSplitterFixed = true;
            this.containerTopBottom.Location = new System.Drawing.Point(0, 0);
            this.containerTopBottom.Margin = new System.Windows.Forms.Padding(4);
            this.containerTopBottom.Name = "containerTopBottom";
            this.containerTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerTopBottom.Panel1
            // 
            this.containerTopBottom.Panel1.BackColor = System.Drawing.Color.Silver;
            this.containerTopBottom.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // containerTopBottom.Panel2
            // 
            this.containerTopBottom.Panel2.Controls.Add(this.containerLeftRight);
            this.containerTopBottom.Size = new System.Drawing.Size(1271, 674);
            this.containerTopBottom.SplitterDistance = 75;
            this.containerTopBottom.SplitterWidth = 5;
            this.containerTopBottom.TabIndex = 0;
            this.containerTopBottom.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonHome);
            this.flowLayoutPanel1.Controls.Add(this.buttonClasses);
            this.flowLayoutPanel1.Controls.Add(this.buttonBuildings);
            this.flowLayoutPanel1.Controls.Add(this.buttonRooms);
            this.flowLayoutPanel1.Controls.Add(this.buttonEvents);
            this.flowLayoutPanel1.Controls.Add(this.buttonNotifications);
            this.flowLayoutPanel1.Controls.Add(this.buttonOrganizations);
            this.flowLayoutPanel1.Controls.Add(this.buttonReports);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1271, 75);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(6, 13);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(100, 50);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.TabStop = false;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasses.Location = new System.Drawing.Point(116, 13);
            this.buttonClasses.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(100, 50);
            this.buttonClasses.TabIndex = 9;
            this.buttonClasses.TabStop = false;
            this.buttonClasses.Text = "Classes";
            this.buttonClasses.UseVisualStyleBackColor = true;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // buttonBuildings
            // 
            this.buttonBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuildings.Location = new System.Drawing.Point(226, 13);
            this.buttonBuildings.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonBuildings.Name = "buttonBuildings";
            this.buttonBuildings.Size = new System.Drawing.Size(100, 50);
            this.buttonBuildings.TabIndex = 14;
            this.buttonBuildings.TabStop = false;
            this.buttonBuildings.Text = "Buildings";
            this.buttonBuildings.UseVisualStyleBackColor = true;
            this.buttonBuildings.Click += new System.EventHandler(this.buttonBuildings_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRooms.Location = new System.Drawing.Point(336, 13);
            this.buttonRooms.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(100, 50);
            this.buttonRooms.TabIndex = 15;
            this.buttonRooms.TabStop = false;
            this.buttonRooms.Text = "Rooms";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.Location = new System.Drawing.Point(446, 13);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(100, 50);
            this.buttonEvents.TabIndex = 8;
            this.buttonEvents.TabStop = false;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonNotifications
            // 
            this.buttonNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotifications.Location = new System.Drawing.Point(556, 13);
            this.buttonNotifications.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonNotifications.Name = "buttonNotifications";
            this.buttonNotifications.Size = new System.Drawing.Size(100, 50);
            this.buttonNotifications.TabIndex = 11;
            this.buttonNotifications.TabStop = false;
            this.buttonNotifications.Text = "Notifications";
            this.buttonNotifications.UseVisualStyleBackColor = true;
            this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
            // 
            // buttonOrganizations
            // 
            this.buttonOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrganizations.Location = new System.Drawing.Point(666, 13);
            this.buttonOrganizations.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonOrganizations.Name = "buttonOrganizations";
            this.buttonOrganizations.Size = new System.Drawing.Size(100, 50);
            this.buttonOrganizations.TabIndex = 12;
            this.buttonOrganizations.TabStop = false;
            this.buttonOrganizations.Text = "Organizations";
            this.buttonOrganizations.UseVisualStyleBackColor = true;
            this.buttonOrganizations.Click += new System.EventHandler(this.buttonOrganizations_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(776, 13);
            this.buttonReports.Margin = new System.Windows.Forms.Padding(6, 13, 4, 4);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(100, 50);
            this.buttonReports.TabIndex = 13;
            this.buttonReports.TabStop = false;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // containerLeftRight
            // 
            this.containerLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerLeftRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.containerLeftRight.IsSplitterFixed = true;
            this.containerLeftRight.Location = new System.Drawing.Point(0, 0);
            this.containerLeftRight.Margin = new System.Windows.Forms.Padding(4);
            this.containerLeftRight.Name = "containerLeftRight";
            // 
            // containerLeftRight.Panel1
            // 
            this.containerLeftRight.Panel1.BackColor = System.Drawing.Color.White;
            this.containerLeftRight.Size = new System.Drawing.Size(1271, 594);
            this.containerLeftRight.SplitterDistance = 172;
            this.containerLeftRight.SplitterWidth = 5;
            this.containerLeftRight.TabIndex = 0;
            this.containerLeftRight.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 674);
            this.Controls.Add(this.containerTopBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1279, 701);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Room Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.containerTopBottom.Panel1.ResumeLayout(false);
            this.containerTopBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerTopBottom)).EndInit();
            this.containerTopBottom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerLeftRight)).EndInit();
            this.containerLeftRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerTopBottom;
        private System.Windows.Forms.SplitContainer containerLeftRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonClasses;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonNotifications;
        private System.Windows.Forms.Button buttonOrganizations;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonBuildings;
        private System.Windows.Forms.Button buttonRooms;
    }
}