namespace ElectronicRoomScheduler.Screens
{
    partial class AssignRoomScreen
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
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Assign Room";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(69, 47);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(351, 21);
            this.comboBoxClass.TabIndex = 3;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buildings";
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Location = new System.Drawing.Point(77, 74);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(343, 21);
            this.comboBoxBuilding.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rooms";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(77, 101);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(343, 21);
            this.comboBoxRooms.TabIndex = 7;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(345, 204);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(75, 23);
            this.buttonAssign.TabIndex = 9;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // AssignRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBuilding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelTitle);
            this.Name = "AssignRoomScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.AssignRoomScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.Button buttonAssign;
    }
}
