namespace ElectronicRoomScheduler.Screens
{
    partial class SetNotificationPreferencesScreen
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxSMSMessages = new System.Windows.Forms.CheckBox();
            this.checkBoxSendMapAlert = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(412, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Set Notification Preferences";
            // 
            // checkBoxSMSMessages
            // 
            this.checkBoxSMSMessages.AutoSize = true;
            this.checkBoxSMSMessages.Location = new System.Drawing.Point(41, 47);
            this.checkBoxSMSMessages.Name = "checkBoxSMSMessages";
            this.checkBoxSMSMessages.Size = new System.Drawing.Size(142, 17);
            this.checkBoxSMSMessages.TabIndex = 3;
            this.checkBoxSMSMessages.Text = "Receive SMS messages";
            this.checkBoxSMSMessages.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendMapAlert
            // 
            this.checkBoxSendMapAlert.AutoSize = true;
            this.checkBoxSendMapAlert.Location = new System.Drawing.Point(41, 70);
            this.checkBoxSendMapAlert.Name = "checkBoxSendMapAlert";
            this.checkBoxSendMapAlert.Size = new System.Drawing.Size(121, 17);
            this.checkBoxSendMapAlert.TabIndex = 4;
            this.checkBoxSendMapAlert.Text = "Send Map with Alert";
            this.checkBoxSendMapAlert.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(332, 108);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SetNotificationPreferencesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxSendMapAlert);
            this.Controls.Add(this.checkBoxSMSMessages);
            this.Controls.Add(this.labelTitle);
            this.Name = "SetNotificationPreferencesScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.SetNotificationPreferencesScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxSMSMessages;
        private System.Windows.Forms.CheckBox checkBoxSendMapAlert;
        private System.Windows.Forms.Button buttonSave;
    }
}
