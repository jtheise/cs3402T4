namespace ElectronicRoomScheduler.Screens
{
    partial class EditOrganizationScreen
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
            this.buttonLoadId = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.textBoxMembers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFacNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrgId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(264, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Organization";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadId);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBoxMembers);
            this.groupBox1.Controls.Add(this.buttonAddMember);
            this.groupBox1.Controls.Add(this.textBoxMembers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFacNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOrgId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organization Information";
            // 
            // buttonLoadId
            // 
            this.buttonLoadId.Location = new System.Drawing.Point(194, 22);
            this.buttonLoadId.Name = "buttonLoadId";
            this.buttonLoadId.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadId.TabIndex = 11;
            this.buttonLoadId.Text = "Load";
            this.buttonLoadId.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.Location = new System.Drawing.Point(93, 142);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(166, 108);
            this.listBoxMembers.TabIndex = 9;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(266, 108);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(75, 25);
            this.buttonAddMember.TabIndex = 8;
            this.buttonAddMember.Text = "Add";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // textBoxMembers
            // 
            this.textBoxMembers.Location = new System.Drawing.Point(93, 111);
            this.textBoxMembers.Name = "textBoxMembers";
            this.textBoxMembers.Size = new System.Drawing.Size(167, 20);
            this.textBoxMembers.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Members";
            // 
            // textBoxFacNumber
            // 
            this.textBoxFacNumber.Location = new System.Drawing.Point(93, 82);
            this.textBoxFacNumber.Name = "textBoxFacNumber";
            this.textBoxFacNumber.Size = new System.Drawing.Size(167, 20);
            this.textBoxFacNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Facility Contact";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textBoxOrgId
            // 
            this.textBoxOrgId.Location = new System.Drawing.Point(93, 24);
            this.textBoxOrgId.Name = "textBoxOrgId";
            this.textBoxOrgId.Size = new System.Drawing.Size(95, 20);
            this.textBoxOrgId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EditOrganizationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditOrganizationScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditOrganizationScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.TextBox textBoxMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFacNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrgId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadId;
    }
}
