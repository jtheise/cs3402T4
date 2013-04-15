namespace ElectronicRoomScheduler.Screens
{
    partial class DeleteClassScreen
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
            this.buttonLookupClassToDelete = new System.Windows.Forms.Button();
            this.textBoxClassLookup = new System.Windows.Forms.TextBox();
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
            this.labelTitle.Size = new System.Drawing.Size(196, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Delete Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLookupClassToDelete);
            this.groupBox1.Controls.Add(this.textBoxClassLookup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            // 
            // buttonLookupClassToDelete
            // 
            this.buttonLookupClassToDelete.Location = new System.Drawing.Point(316, 25);
            this.buttonLookupClassToDelete.Name = "buttonLookupClassToDelete";
            this.buttonLookupClassToDelete.Size = new System.Drawing.Size(79, 26);
            this.buttonLookupClassToDelete.TabIndex = 2;
            this.buttonLookupClassToDelete.Text = "Delete Class";
            this.buttonLookupClassToDelete.UseVisualStyleBackColor = true;
            this.buttonLookupClassToDelete.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // textBoxClassLookup
            // 
            this.textBoxClassLookup.Location = new System.Drawing.Point(102, 29);
            this.textBoxClassLookup.Name = "textBoxClassLookup";
            this.textBoxClassLookup.Size = new System.Drawing.Size(208, 20);
            this.textBoxClassLookup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course ID";
            // 
            // DeleteClassScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "DeleteClassScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.DeleteClassScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLookupClassToDelete;
        private System.Windows.Forms.TextBox textBoxClassLookup;
        private System.Windows.Forms.Label label2;


    }
}
