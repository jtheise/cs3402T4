namespace ElectronicRoomScheduler.Screens
{
    partial class DefaultRoomScreen
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
            this.listviewRooms = new System.Windows.Forms.ListView();
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(242, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Manage Rooms";
            // 
            // listviewRooms
            // 
            this.listviewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bid,
            this.roomnum,
            this.cap,
            this.islab,
            this.tech});
            this.listviewRooms.Location = new System.Drawing.Point(15, 47);
            this.listviewRooms.Name = "listviewRooms";
            this.listviewRooms.Size = new System.Drawing.Size(790, 154);
            this.listviewRooms.TabIndex = 3;
            this.listviewRooms.UseCompatibleStateImageBehavior = false;
            this.listviewRooms.View = System.Windows.Forms.View.Details;
            // 
            // bid
            // 
            this.bid.Text = "Building ID";
            // 
            // roomnum
            // 
            this.roomnum.Text = "Room Number";
            // 
            // cap
            // 
            this.cap.Text = "Capacity";
            // 
            // islab
            // 
            this.islab.Text = "Lab";
            // 
            // tech
            // 
            this.tech.Text = "Technology Available";
            this.tech.Width = 114;
            // 
            // DefaultRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listviewRooms);
            this.Controls.Add(this.labelTitle);
            this.Name = "DefaultRoomScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.DefaultRoomScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listviewRooms;
        private System.Windows.Forms.ColumnHeader bid;
        private System.Windows.Forms.ColumnHeader roomnum;
        private System.Windows.Forms.ColumnHeader cap;
        private System.Windows.Forms.ColumnHeader islab;
        private System.Windows.Forms.ColumnHeader tech;
    }
}
