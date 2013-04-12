namespace ElectronicRoomScheduler.Screens
{
    partial class EditClassScreen
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.textBoxClassLookup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxClassDays = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInstructor = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLookup);
            this.groupBox1.Controls.Add(this.textBoxClassLookup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            // 
            // buttonLookup
            // 
            this.buttonLookup.Location = new System.Drawing.Point(395, 27);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(75, 23);
            this.buttonLookup.TabIndex = 2;
            this.buttonLookup.Text = "Lookup";
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // textBoxClassLookup
            // 
            this.textBoxClassLookup.Location = new System.Drawing.Point(177, 29);
            this.textBoxClassLookup.Name = "textBoxClassLookup";
            this.textBoxClassLookup.Size = new System.Drawing.Size(212, 20);
            this.textBoxClassLookup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course ID / Course Name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 37);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Edit Class";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxClassDays);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSection);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerEndTime);
            this.groupBox2.Controls.Add(this.dateTimePickerStartTime);
            this.groupBox2.Controls.Add(this.textBoxCourseId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxInstructor);
            this.groupBox2.Controls.Add(this.textBoxDepartment);
            this.groupBox2.Controls.Add(this.textBoxCourseName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(29, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 267);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // checkedListBoxClassDays
            // 
            this.checkedListBoxClassDays.CheckOnClick = true;
            this.checkedListBoxClassDays.ColumnWidth = 45;
            this.checkedListBoxClassDays.FormattingEnabled = true;
            this.checkedListBoxClassDays.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.checkedListBoxClassDays.Location = new System.Drawing.Point(104, 173);
            this.checkedListBoxClassDays.MultiColumn = true;
            this.checkedListBoxClassDays.Name = "checkedListBoxClassDays";
            this.checkedListBoxClassDays.Size = new System.Drawing.Size(324, 19);
            this.checkedListBoxClassDays.TabIndex = 17;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(356, 238);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Save";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Days";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Location = new System.Drawing.Point(106, 111);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(89, 20);
            this.textBoxSection.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Section #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Time";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(106, 224);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerEndTime.TabIndex = 6;
            this.dateTimePickerEndTime.Value = new System.DateTime(2013, 4, 11, 10, 50, 0, 0);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(106, 198);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerStartTime.TabIndex = 5;
            this.dateTimePickerStartTime.Value = new System.DateTime(2013, 4, 11, 10, 0, 0, 0);
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(106, 33);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(89, 20);
            this.textBoxCourseId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course ID";
            // 
            // textBoxInstructor
            // 
            this.textBoxInstructor.Location = new System.Drawing.Point(106, 146);
            this.textBoxInstructor.Name = "textBoxInstructor";
            this.textBoxInstructor.Size = new System.Drawing.Size(206, 20);
            this.textBoxInstructor.TabIndex = 4;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(106, 85);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(206, 20);
            this.textBoxDepartment.TabIndex = 2;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(106, 59);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(269, 20);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Instructor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Course Name";
            // 
            // EditClassScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditClassScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditClassScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxClassLookup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxClassDays;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInstructor;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}
