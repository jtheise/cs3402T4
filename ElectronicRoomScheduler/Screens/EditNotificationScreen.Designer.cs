namespace ElectronicRoomScheduler.Screens
{
    partial class EditNotificationScreen
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
            this.labelWarning = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClearEventsClasses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRecurring = new System.Windows.Forms.CheckBox();
            this.checkedListBoxFrequency = new System.Windows.Forms.CheckedListBox();
            this.buttonSaveNotification = new System.Windows.Forms.Button();
            this.flowLayoutPanelClassesAndEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddNewPhoneEmail = new System.Windows.Forms.Button();
            this.textBoxPhoneEmail = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelEmailsAndPhones = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelFor = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelTo = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Notification";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Yellow;
            this.labelWarning.Location = new System.Drawing.Point(206, 20);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(208, 20);
            this.labelWarning.TabIndex = 7;
            this.labelWarning.Text = "Screen Not Implemented";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Time before class begins to send alert:";
            // 
            // buttonClearEventsClasses
            // 
            this.buttonClearEventsClasses.Location = new System.Drawing.Point(750, 195);
            this.buttonClearEventsClasses.Name = "buttonClearEventsClasses";
            this.buttonClearEventsClasses.Size = new System.Drawing.Size(48, 19);
            this.buttonClearEventsClasses.TabIndex = 34;
            this.buttonClearEventsClasses.Text = "Clear";
            this.buttonClearEventsClasses.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Right click to delete";
            // 
            // checkBoxRecurring
            // 
            this.checkBoxRecurring.AutoSize = true;
            this.checkBoxRecurring.Location = new System.Drawing.Point(643, 454);
            this.checkBoxRecurring.Name = "checkBoxRecurring";
            this.checkBoxRecurring.Size = new System.Drawing.Size(78, 17);
            this.checkBoxRecurring.TabIndex = 32;
            this.checkBoxRecurring.Text = "Recurring?";
            this.checkBoxRecurring.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxFrequency
            // 
            this.checkedListBoxFrequency.CheckOnClick = true;
            this.checkedListBoxFrequency.ColumnWidth = 80;
            this.checkedListBoxFrequency.FormattingEnabled = true;
            this.checkedListBoxFrequency.Items.AddRange(new object[] {
            "15 Mins",
            "30 Mins",
            "1 Hour",
            "3 Hours",
            "1 Day"});
            this.checkedListBoxFrequency.Location = new System.Drawing.Point(17, 450);
            this.checkedListBoxFrequency.MultiColumn = true;
            this.checkedListBoxFrequency.Name = "checkedListBoxFrequency";
            this.checkedListBoxFrequency.Size = new System.Drawing.Size(463, 19);
            this.checkedListBoxFrequency.TabIndex = 31;
            // 
            // buttonSaveNotification
            // 
            this.buttonSaveNotification.Location = new System.Drawing.Point(727, 450);
            this.buttonSaveNotification.Name = "buttonSaveNotification";
            this.buttonSaveNotification.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNotification.TabIndex = 30;
            this.buttonSaveNotification.Text = "Save";
            this.buttonSaveNotification.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelClassesAndEvents
            // 
            this.flowLayoutPanelClassesAndEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelClassesAndEvents.Location = new System.Drawing.Point(409, 8);
            this.flowLayoutPanelClassesAndEvents.Name = "flowLayoutPanelClassesAndEvents";
            this.flowLayoutPanelClassesAndEvents.Size = new System.Drawing.Size(389, 177);
            this.flowLayoutPanelClassesAndEvents.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email or Phone:";
            // 
            // buttonAddNewPhoneEmail
            // 
            this.buttonAddNewPhoneEmail.Location = new System.Drawing.Point(242, 59);
            this.buttonAddNewPhoneEmail.Name = "buttonAddNewPhoneEmail";
            this.buttonAddNewPhoneEmail.Size = new System.Drawing.Size(53, 23);
            this.buttonAddNewPhoneEmail.TabIndex = 28;
            this.buttonAddNewPhoneEmail.Text = "Add";
            this.buttonAddNewPhoneEmail.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneEmail
            // 
            this.textBoxPhoneEmail.Location = new System.Drawing.Point(98, 59);
            this.textBoxPhoneEmail.Name = "textBoxPhoneEmail";
            this.textBoxPhoneEmail.Size = new System.Drawing.Size(138, 20);
            this.textBoxPhoneEmail.TabIndex = 27;
            // 
            // flowLayoutPanelEmailsAndPhones
            // 
            this.flowLayoutPanelEmailsAndPhones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelEmailsAndPhones.Location = new System.Drawing.Point(14, 88);
            this.flowLayoutPanelEmailsAndPhones.Name = "flowLayoutPanelEmailsAndPhones";
            this.flowLayoutPanelEmailsAndPhones.Size = new System.Drawing.Size(389, 104);
            this.flowLayoutPanelEmailsAndPhones.TabIndex = 25;
            // 
            // flowLayoutPanelFor
            // 
            this.flowLayoutPanelFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelFor.Location = new System.Drawing.Point(417, 220);
            this.flowLayoutPanelFor.Name = "flowLayoutPanelFor";
            this.flowLayoutPanelFor.Size = new System.Drawing.Size(389, 211);
            this.flowLayoutPanelFor.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Drag Classes and Events Here       (click clear to remove)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Drag E-mail Addresses and Phone Numbers Here      (click to remove)";
            // 
            // flowLayoutPanelTo
            // 
            this.flowLayoutPanelTo.AllowDrop = true;
            this.flowLayoutPanelTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTo.Location = new System.Drawing.Point(14, 220);
            this.flowLayoutPanelTo.Name = "flowLayoutPanelTo";
            this.flowLayoutPanelTo.Size = new System.Drawing.Size(389, 211);
            this.flowLayoutPanelTo.TabIndex = 21;
            // 
            // EditNotificationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClearEventsClasses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxRecurring);
            this.Controls.Add(this.checkedListBoxFrequency);
            this.Controls.Add(this.buttonSaveNotification);
            this.Controls.Add(this.flowLayoutPanelClassesAndEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNewPhoneEmail);
            this.Controls.Add(this.textBoxPhoneEmail);
            this.Controls.Add(this.flowLayoutPanelEmailsAndPhones);
            this.Controls.Add(this.flowLayoutPanelFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelTo);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditNotificationScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditNotificationScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClearEventsClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxRecurring;
        private System.Windows.Forms.CheckedListBox checkedListBoxFrequency;
        private System.Windows.Forms.Button buttonSaveNotification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelClassesAndEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewPhoneEmail;
        private System.Windows.Forms.TextBox textBoxPhoneEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmailsAndPhones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTo;
    }
}
