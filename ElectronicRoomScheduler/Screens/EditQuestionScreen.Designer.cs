﻿namespace ElectronicRoomScheduler.Screens
{
    partial class EditQuestionScreen
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
            this.buttonLoadQuestion = new System.Windows.Forms.Button();
            this.buttonSaveQuestion = new System.Windows.Forms.Button();
            this.textBoxQuestionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSelection = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(209, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Edit Question";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadQuestion);
            this.groupBox1.Controls.Add(this.buttonSaveQuestion);
            this.groupBox1.Controls.Add(this.textBoxQuestionId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 322);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Data";
            // 
            // buttonLoadQuestion
            // 
            this.buttonLoadQuestion.Location = new System.Drawing.Point(86, 10);
            this.buttonLoadQuestion.Name = "buttonLoadQuestion";
            this.buttonLoadQuestion.Size = new System.Drawing.Size(75, 25);
            this.buttonLoadQuestion.TabIndex = 2;
            this.buttonLoadQuestion.Text = "Load";
            this.buttonLoadQuestion.UseVisualStyleBackColor = true;
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Location = new System.Drawing.Point(616, 289);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveQuestion.TabIndex = 4;
            this.buttonSaveQuestion.Text = "Save";
            this.buttonSaveQuestion.UseVisualStyleBackColor = true;
            // 
            // textBoxQuestionId
            // 
            this.textBoxQuestionId.Location = new System.Drawing.Point(33, 13);
            this.textBoxQuestionId.Name = "textBoxQuestionId";
            this.textBoxQuestionId.Size = new System.Drawing.Size(47, 20);
            this.textBoxQuestionId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxCondition);
            this.groupBox3.Controls.Add(this.comboBoxOperator);
            this.groupBox3.Controls.Add(this.comboBoxProperty);
            this.groupBox3.Location = new System.Drawing.Point(6, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matching Conditions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logical Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(204, 39);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(129, 20);
            this.textBoxCondition.TabIndex = 4;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            ">=",
            ">",
            "<=",
            "<",
            "=",
            "!="});
            this.comboBoxOperator.Location = new System.Drawing.Point(143, 39);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(55, 21);
            this.comboBoxOperator.TabIndex = 2;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Location = new System.Drawing.Point(6, 39);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(131, 21);
            this.comboBoxProperty.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxSelection);
            this.groupBox2.Location = new System.Drawing.Point(6, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select";
            // 
            // checkedListBoxSelection
            // 
            this.checkedListBoxSelection.FormattingEnabled = true;
            this.checkedListBoxSelection.Items.AddRange(new object[] {
            "Students",
            "Professors",
            "Classes"});
            this.checkedListBoxSelection.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxSelection.Name = "checkedListBoxSelection";
            this.checkedListBoxSelection.Size = new System.Drawing.Size(673, 109);
            this.checkedListBoxSelection.TabIndex = 0;
            // 
            // EditQuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditQuestionScreen";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.EditQuestionScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoadQuestion;
        private System.Windows.Forms.Button buttonSaveQuestion;
        private System.Windows.Forms.TextBox textBoxQuestionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.ComboBox comboBoxProperty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelection;
    }
}
