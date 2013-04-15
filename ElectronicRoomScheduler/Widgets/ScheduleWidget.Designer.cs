namespace ElectronicRoomScheduler.Widgets
{
    partial class ScheduleWidget
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Class Name";
            this.labelName.Click += new System.EventHandler(this.ScheduleWidget_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(3, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(108, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "9:00 AM to 10:30 PM";
            this.labelTime.Click += new System.EventHandler(this.ScheduleWidget_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(3, 26);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(58, 13);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Hayes Hall";
            this.labelLocation.Click += new System.EventHandler(this.ScheduleWidget_Click);
            // 
            // ScheduleWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Name = "ScheduleWidget";
            this.Size = new System.Drawing.Size(208, 41);
            this.Load += new System.EventHandler(this.ScheduleWidget_Load);
            this.Click += new System.EventHandler(this.ScheduleWidget_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Label labelLocation;
    }
}
