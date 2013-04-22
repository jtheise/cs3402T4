namespace ElectronicRoomScheduler.Screens
{
    partial class DefaultBuildingsScreen
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
            this.listView = new System.Windows.Forms.ListView();
            this.building_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.building_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location_lat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location_long = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Manage Buildings";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.building_id,
            this.building_name,
            this.location_lat,
            this.location_long});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(15, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(790, 154);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // building_id
            // 
            this.building_id.Text = "ID";
            this.building_id.Width = 91;
            // 
            // building_name
            // 
            this.building_name.Text = "Name";
            this.building_name.Width = 89;
            // 
            // location_lat
            // 
            this.location_lat.Text = "Latitude";
            this.location_lat.Width = 96;
            // 
            // location_long
            // 
            this.location_long.Text = "Longitude";
            this.location_long.Width = 102;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Yellow;
            this.labelWarning.Location = new System.Drawing.Point(285, 20);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(212, 20);
            this.labelWarning.TabIndex = 4;
            this.labelWarning.Text = "Section Not Implemented";
            // 
            // DefaultBuildingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelTitle);
            this.Name = "DefaultBuildingsScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.DefaultBuildingsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader building_id;
        private System.Windows.Forms.ColumnHeader building_name;
        private System.Windows.Forms.ColumnHeader location_lat;
        private System.Windows.Forms.ColumnHeader location_long;
        private System.Windows.Forms.Label labelWarning;

    }
}
