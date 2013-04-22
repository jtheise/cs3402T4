namespace ElectronicRoomScheduler.Screens
{
    partial class DeleteOrganizationScreen
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
            this.buttonDeleteOrg = new System.Windows.Forms.Button();
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
            this.labelTitle.Size = new System.Drawing.Size(299, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Delete Organization";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteOrg);
            this.groupBox1.Controls.Add(this.textBoxOrgId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organization Information";
            // 
            // buttonDeleteOrg
            // 
            this.buttonDeleteOrg.Location = new System.Drawing.Point(211, 19);
            this.buttonDeleteOrg.Name = "buttonDeleteOrg";
            this.buttonDeleteOrg.Size = new System.Drawing.Size(75, 25);
            this.buttonDeleteOrg.TabIndex = 2;
            this.buttonDeleteOrg.Text = "Delete";
            this.buttonDeleteOrg.UseVisualStyleBackColor = true;
            // 
            // textBoxOrgId
            // 
            this.textBoxOrgId.Location = new System.Drawing.Point(30, 22);
            this.textBoxOrgId.Name = "textBoxOrgId";
            this.textBoxOrgId.Size = new System.Drawing.Size(175, 20);
            this.textBoxOrgId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeleteOrganizationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "DeleteOrganizationScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.DeleteOrganizationScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOrgId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteOrg;
    }
}
