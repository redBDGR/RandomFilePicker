namespace RandomFilePicker
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.selectDirButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileNameTextHeader = new System.Windows.Forms.Label();
            this.selectNewButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filePositionText = new System.Windows.Forms.Label();
            this.fileNameText = new System.Windows.Forms.Label();
            this.previousFileButton = new System.Windows.Forms.Button();
            this.nextFileButton = new System.Windows.Forms.Button();
            this.moveFileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirTextBox
            // 
            this.dirTextBox.Location = new System.Drawing.Point(17, 18);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(338, 20);
            this.dirTextBox.TabIndex = 0;
            // 
            // selectDirButton
            // 
            this.selectDirButton.AllowDrop = true;
            this.selectDirButton.AutoEllipsis = true;
            this.selectDirButton.Location = new System.Drawing.Point(361, 18);
            this.selectDirButton.Name = "selectDirButton";
            this.selectDirButton.Size = new System.Drawing.Size(126, 21);
            this.selectDirButton.TabIndex = 1;
            this.selectDirButton.Text = "Select Target Directory";
            this.selectDirButton.UseVisualStyleBackColor = true;
            this.selectDirButton.Click += new System.EventHandler(this.selectDirButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dirTextBox);
            this.panel1.Controls.Add(this.selectDirButton);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 54);
            this.panel1.TabIndex = 2;
            // 
            // fileNameTextHeader
            // 
            this.fileNameTextHeader.AutoSize = true;
            this.fileNameTextHeader.Location = new System.Drawing.Point(10, 59);
            this.fileNameTextHeader.Name = "fileNameTextHeader";
            this.fileNameTextHeader.Size = new System.Drawing.Size(102, 13);
            this.fileNameTextHeader.TabIndex = 3;
            this.fileNameTextHeader.Text = "Selected File Name:";
            // 
            // selectNewButton
            // 
            this.selectNewButton.Enabled = false;
            this.selectNewButton.Location = new System.Drawing.Point(356, 81);
            this.selectNewButton.Name = "selectNewButton";
            this.selectNewButton.Size = new System.Drawing.Size(126, 20);
            this.selectNewButton.TabIndex = 4;
            this.selectNewButton.Text = "Select New";
            this.selectNewButton.UseVisualStyleBackColor = true;
            this.selectNewButton.Click += new System.EventHandler(this.selectNewButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Enabled = false;
            this.openFileButton.Location = new System.Drawing.Point(91, 117);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(98, 23);
            this.openFileButton.TabIndex = 6;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Enabled = false;
            this.deleteFileButton.Location = new System.Drawing.Point(299, 117);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(98, 23);
            this.deleteFileButton.TabIndex = 7;
            this.deleteFileButton.Text = "Delete";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Position:";
            // 
            // filePositionText
            // 
            this.filePositionText.AutoSize = true;
            this.filePositionText.Location = new System.Drawing.Point(356, 59);
            this.filePositionText.Name = "filePositionText";
            this.filePositionText.Size = new System.Drawing.Size(0, 13);
            this.filePositionText.TabIndex = 9;
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Location = new System.Drawing.Point(12, 85);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(0, 13);
            this.fileNameText.TabIndex = 10;
            // 
            // previousFileButton
            // 
            this.previousFileButton.Enabled = false;
            this.previousFileButton.Location = new System.Drawing.Point(13, 117);
            this.previousFileButton.Name = "previousFileButton";
            this.previousFileButton.Size = new System.Drawing.Size(33, 22);
            this.previousFileButton.TabIndex = 11;
            this.previousFileButton.Text = "<";
            this.previousFileButton.UseVisualStyleBackColor = true;
            this.previousFileButton.Click += new System.EventHandler(this.previousFileButton_Click);
            // 
            // nextFileButton
            // 
            this.nextFileButton.Enabled = false;
            this.nextFileButton.Location = new System.Drawing.Point(52, 117);
            this.nextFileButton.Name = "nextFileButton";
            this.nextFileButton.Size = new System.Drawing.Size(33, 23);
            this.nextFileButton.TabIndex = 12;
            this.nextFileButton.Text = ">";
            this.nextFileButton.UseVisualStyleBackColor = true;
            this.nextFileButton.Click += new System.EventHandler(this.nextFileButton_Click);
            // 
            // moveFileButton
            // 
            this.moveFileButton.Enabled = false;
            this.moveFileButton.Location = new System.Drawing.Point(195, 117);
            this.moveFileButton.Name = "moveFileButton";
            this.moveFileButton.Size = new System.Drawing.Size(98, 23);
            this.moveFileButton.TabIndex = 13;
            this.moveFileButton.Text = "Move";
            this.moveFileButton.UseVisualStyleBackColor = true;
            this.moveFileButton.Click += new System.EventHandler(this.moveFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 152);
            this.Controls.Add(this.moveFileButton);
            this.Controls.Add(this.nextFileButton);
            this.Controls.Add(this.previousFileButton);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.filePositionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.selectNewButton);
            this.Controls.Add(this.fileNameTextHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Random File Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.Button selectDirButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fileNameTextHeader;
        private System.Windows.Forms.Button selectNewButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filePositionText;
        private System.Windows.Forms.Label fileNameText;
        private System.Windows.Forms.Button previousFileButton;
        private System.Windows.Forms.Button nextFileButton;
        private System.Windows.Forms.Button moveFileButton;
    }
}

