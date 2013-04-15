namespace ElectronicRoomScheduler.Screens
{
    partial class AutoAssignRoomsScreen
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
            this.buttonRunAutomaticRoomScheduler = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRunAutomaticRoomScheduler
            // 
            this.buttonRunAutomaticRoomScheduler.Location = new System.Drawing.Point(15, 67);
            this.buttonRunAutomaticRoomScheduler.Name = "buttonRunAutomaticRoomScheduler";
            this.buttonRunAutomaticRoomScheduler.Size = new System.Drawing.Size(186, 62);
            this.buttonRunAutomaticRoomScheduler.TabIndex = 2;
            this.buttonRunAutomaticRoomScheduler.Text = "Run Automatic Room Scheduler";
            this.buttonRunAutomaticRoomScheduler.UseVisualStyleBackColor = true;
            this.buttonRunAutomaticRoomScheduler.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(424, 37);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Automatically Assign Rooms";
            // 
            // AutoAssignRoomsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRunAutomaticRoomScheduler);
            this.Name = "AutoAssignRoomsScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.AssignRoomsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunAutomaticRoomScheduler;
        private System.Windows.Forms.Label labelTitle;
    }
}
