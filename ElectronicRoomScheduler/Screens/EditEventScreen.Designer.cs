namespace ElectronicRoomScheduler.Screens
{
    partial class EditEventScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddEventPerson = new System.Windows.Forms.Button();
            this.buttonRemoveEventPerson = new System.Windows.Forms.Button();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.listBoxAttending = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveEditedEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHostingOrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Event";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRoom);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonAddEventPerson);
            this.groupBox1.Controls.Add(this.buttonRemoveEventPerson);
            this.groupBox1.Controls.Add(this.textBoxPerson);
            this.groupBox1.Controls.Add(this.listBoxAttending);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSaveEditedEvent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerDateTime);
            this.groupBox1.Controls.Add(this.textBoxEventName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHostingOrg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Information";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(120, 58);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(203, 21);
            this.comboBoxRoom.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(120, 347);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Notify Attendees";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Add Person";
            // 
            // buttonAddEventPerson
            // 
            this.buttonAddEventPerson.Location = new System.Drawing.Point(278, 141);
            this.buttonAddEventPerson.Name = "buttonAddEventPerson";
            this.buttonAddEventPerson.Size = new System.Drawing.Size(53, 23);
            this.buttonAddEventPerson.TabIndex = 21;
            this.buttonAddEventPerson.Text = "Add";
            this.buttonAddEventPerson.UseVisualStyleBackColor = true;
            this.buttonAddEventPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonRemoveEventPerson
            // 
            this.buttonRemoveEventPerson.Enabled = false;
            this.buttonRemoveEventPerson.Location = new System.Drawing.Point(332, 190);
            this.buttonRemoveEventPerson.Name = "buttonRemoveEventPerson";
            this.buttonRemoveEventPerson.Size = new System.Drawing.Size(57, 23);
            this.buttonRemoveEventPerson.TabIndex = 20;
            this.buttonRemoveEventPerson.Text = "Remove";
            this.buttonRemoveEventPerson.UseVisualStyleBackColor = true;
            this.buttonRemoveEventPerson.Click += new System.EventHandler(this.buttonRemovePerson_Click);
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(185, 141);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(87, 20);
            this.textBoxPerson.TabIndex = 19;
            this.textBoxPerson.Enter += new System.EventHandler(this.textBoxPerson_Enter);
            this.textBoxPerson.Leave += new System.EventHandler(this.textBoxPerson_Leave);
            // 
            // listBoxAttending
            // 
            this.listBoxAttending.FormattingEnabled = true;
            this.listBoxAttending.Location = new System.Drawing.Point(120, 170);
            this.listBoxAttending.Name = "listBoxAttending";
            this.listBoxAttending.Size = new System.Drawing.Size(206, 160);
            this.listBoxAttending.TabIndex = 14;
            this.listBoxAttending.SelectedValueChanged += new System.EventHandler(this.listBoxAttending_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "People Attending";
            // 
            // buttonSaveEditedEvent
            // 
            this.buttonSaveEditedEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveEditedEvent.Location = new System.Drawing.Point(356, 370);
            this.buttonSaveEditedEvent.Name = "buttonSaveEditedEvent";
            this.buttonSaveEditedEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEditedEvent.TabIndex = 8;
            this.buttonSaveEditedEvent.Text = "Save";
            this.buttonSaveEditedEvent.UseVisualStyleBackColor = true;
            this.buttonSaveEditedEvent.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date and Time";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(117, 111);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.ShowUpDown = true;
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(283, 20);
            this.dateTimePickerDateTime.TabIndex = 6;
            this.dateTimePickerDateTime.Value = new System.DateTime(2013, 4, 11, 10, 0, 0, 0);
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(117, 33);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(311, 20);
            this.textBoxEventName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Name";
            // 
            // textBoxHostingOrg
            // 
            this.textBoxHostingOrg.Location = new System.Drawing.Point(117, 85);
            this.textBoxHostingOrg.Name = "textBoxHostingOrg";
            this.textBoxHostingOrg.Size = new System.Drawing.Size(206, 20);
            this.textBoxHostingOrg.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hosting Organization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room";
            // 
            // EditEventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditEventScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditEventScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddEventPerson;
        private System.Windows.Forms.Button buttonRemoveEventPerson;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.ListBox listBoxAttending;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveEditedEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHostingOrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
