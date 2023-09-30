namespace BasicFacebookFeatures
{
    partial class FormBestFriendFeature
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
            this.choosePropertyOfBestFriendLabel = new System.Windows.Forms.Label();
            this.propertiesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.showBestFriendButton = new System.Windows.Forms.Button();
            this.BestFriendNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosePropertyOfBestFriendLabel
            // 
            this.choosePropertyOfBestFriendLabel.AutoSize = true;
            this.choosePropertyOfBestFriendLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePropertyOfBestFriendLabel.Location = new System.Drawing.Point(108, 70);
            this.choosePropertyOfBestFriendLabel.Name = "choosePropertyOfBestFriendLabel";
            this.choosePropertyOfBestFriendLabel.Size = new System.Drawing.Size(186, 16);
            this.choosePropertyOfBestFriendLabel.TabIndex = 1;
            this.choosePropertyOfBestFriendLabel.Text = "Select your best friend by:";
            // 
            // propertiesCheckedListBox
            // 
            this.propertiesCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propertiesCheckedListBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesCheckedListBox.FormattingEnabled = true;
            this.propertiesCheckedListBox.IntegralHeight = false;
            this.propertiesCheckedListBox.Items.AddRange(new object[] {
            "Likes",
            "Comments",
            "Tags"});
            this.propertiesCheckedListBox.Location = new System.Drawing.Point(150, 103);
            this.propertiesCheckedListBox.Name = "propertiesCheckedListBox";
            this.propertiesCheckedListBox.Size = new System.Drawing.Size(115, 63);
            this.propertiesCheckedListBox.TabIndex = 2;
            this.propertiesCheckedListBox.ThreeDCheckBoxes = true;
            // 
            // showBestFriendButton
            // 
            this.showBestFriendButton.BackColor = System.Drawing.SystemColors.Menu;
            this.showBestFriendButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBestFriendButton.Location = new System.Drawing.Point(109, 160);
            this.showBestFriendButton.Name = "showBestFriendButton";
            this.showBestFriendButton.Size = new System.Drawing.Size(185, 29);
            this.showBestFriendButton.TabIndex = 3;
            this.showBestFriendButton.Text = "Show best facebook friend";
            this.showBestFriendButton.UseVisualStyleBackColor = false;
            this.showBestFriendButton.Click += new System.EventHandler(this.showBestFriendButton_Click);
            // 
            // BestFriendNameLabel
            // 
            this.BestFriendNameLabel.AutoSize = true;
            this.BestFriendNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendNameLabel.Location = new System.Drawing.Point(86, 224);
            this.BestFriendNameLabel.Name = "BestFriendNameLabel";
            this.BestFriendNameLabel.Size = new System.Drawing.Size(0, 16);
            this.BestFriendNameLabel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.closeButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(140, 277);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FeaturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 378);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.BestFriendNameLabel);
            this.Controls.Add(this.showBestFriendButton);
            this.Controls.Add(this.propertiesCheckedListBox);
            this.Controls.Add(this.choosePropertyOfBestFriendLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FeaturesForm";
            this.ShowIcon = false;
            this.Text = "FeaturesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosePropertyOfBestFriendLabel;
        private System.Windows.Forms.CheckedListBox propertiesCheckedListBox;
        private System.Windows.Forms.Button showBestFriendButton;
        private System.Windows.Forms.Label BestFriendNameLabel;
        private System.Windows.Forms.Button closeButton;
    }
}