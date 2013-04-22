namespace ElectronicRoomScheduler.Screens
{
    partial class EditRoomScreen
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
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxTech = new System.Windows.Forms.CheckedListBox();
            this.textBoxRoomCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxIsLab = new System.Windows.Forms.CheckBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxBuildingName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuildingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveRoom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkedListBoxTech);
            this.groupBox1.Controls.Add(this.textBoxRoomCapacity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxIsLab);
            this.groupBox1.Controls.Add(this.textBoxRoomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Data";
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.Location = new System.Drawing.Point(397, 342);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveRoom.TabIndex = 6;
            this.buttonSaveRoom.Text = "Save";
            this.buttonSaveRoom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Technology";
            // 
            // checkedListBoxTech
            // 
            this.checkedListBoxTech.AllowDrop = true;
            this.checkedListBoxTech.FormattingEnabled = true;
            this.checkedListBoxTech.Items.AddRange(new object[] {
            "Visual Studio",
            "Projector",
            "Overhead",
            "Wi Fi"});
            this.checkedListBoxTech.Location = new System.Drawing.Point(107, 273);
            this.checkedListBoxTech.Name = "checkedListBoxTech";
            this.checkedListBoxTech.Size = new System.Drawing.Size(253, 94);
            this.checkedListBoxTech.TabIndex = 5;
            // 
            // textBoxRoomCapacity
            // 
            this.textBoxRoomCapacity.Location = new System.Drawing.Point(107, 159);
            this.textBoxRoomCapacity.Name = "textBoxRoomCapacity";
            this.textBoxRoomCapacity.Size = new System.Drawing.Size(55, 20);
            this.textBoxRoomCapacity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Capacity";
            // 
            // checkBoxIsLab
            // 
            this.checkBoxIsLab.AutoSize = true;
            this.checkBoxIsLab.Location = new System.Drawing.Point(26, 206);
            this.checkBoxIsLab.Name = "checkBoxIsLab";
            this.checkBoxIsLab.Size = new System.Drawing.Size(64, 17);
            this.checkBoxIsLab.TabIndex = 4;
            this.checkBoxIsLab.Text = "Is a Lab";
            this.checkBoxIsLab.UseVisualStyleBackColor = true;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(107, 120);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(58, 20);
            this.textBoxRoomNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxBuildingName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxBuildingId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Building";
            // 
            // comboBoxBuildingName
            // 
            this.comboBoxBuildingName.FormattingEnabled = true;
            this.comboBoxBuildingName.Location = new System.Drawing.Point(90, 47);
            this.comboBoxBuildingName.Name = "comboBoxBuildingName";
            this.comboBoxBuildingName.Size = new System.Drawing.Size(253, 21);
            this.comboBoxBuildingName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building Name";
            // 
            // textBoxBuildingId
            // 
            this.textBoxBuildingId.Location = new System.Drawing.Point(90, 13);
            this.textBoxBuildingId.Name = "textBoxBuildingId";
            this.textBoxBuildingId.Size = new System.Drawing.Size(105, 20);
            this.textBoxBuildingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building ID";
            // 
            // EditRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditRoomScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditRoomScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxTech;
        private System.Windows.Forms.TextBox textBoxRoomCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsLab;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxBuildingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuildingId;
        private System.Windows.Forms.Label label1;

    }
}
