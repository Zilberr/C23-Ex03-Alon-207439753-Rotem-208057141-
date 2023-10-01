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
            this.postsRadioButton = new System.Windows.Forms.RadioButton();
            this.albumsRadioButton = new System.Windows.Forms.RadioButton();
            this.choosePropertyOfBestFriendLabel = new System.Windows.Forms.Label();
            this.propertiesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.showBestFriendButton = new System.Windows.Forms.Button();
            this.BestFriendNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postsRadioButton
            // 
            this.postsRadioButton.AutoSize = true;
            this.postsRadioButton.Location = new System.Drawing.Point(319, 187);
            this.postsRadioButton.Name = "postsRadioButton";
            this.postsRadioButton.Size = new System.Drawing.Size(74, 24);
            this.postsRadioButton.TabIndex = 10;
            this.postsRadioButton.TabStop = true;
            this.postsRadioButton.Text = "Posts";
            this.postsRadioButton.UseVisualStyleBackColor = true;
            this.postsRadioButton.CheckedChanged += new System.EventHandler(this.postsRadioButton_CheckedChanged);
            // 
            // albumsRadioButton
            // 
            this.albumsRadioButton.AutoSize = true;
            this.albumsRadioButton.Location = new System.Drawing.Point(319, 157);
            this.albumsRadioButton.Name = "albumsRadioButton";
            this.albumsRadioButton.Size = new System.Drawing.Size(87, 24);
            this.albumsRadioButton.TabIndex = 9;
            this.albumsRadioButton.TabStop = true;
            this.albumsRadioButton.Text = "Albums";
            this.albumsRadioButton.UseVisualStyleBackColor = true;
            this.albumsRadioButton.CheckedChanged += new System.EventHandler(this.albumsRadioButton_CheckedChanged);
            // 
            // choosePropertyOfBestFriendLabel
            // 
            this.choosePropertyOfBestFriendLabel.AutoSize = true;
            this.choosePropertyOfBestFriendLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePropertyOfBestFriendLabel.Location = new System.Drawing.Point(129, 81);
            this.choosePropertyOfBestFriendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choosePropertyOfBestFriendLabel.Name = "choosePropertyOfBestFriendLabel";
            this.choosePropertyOfBestFriendLabel.Size = new System.Drawing.Size(271, 24);
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
            this.propertiesCheckedListBox.Location = new System.Drawing.Point(164, 157);
            this.propertiesCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propertiesCheckedListBox.Name = "propertiesCheckedListBox";
            this.propertiesCheckedListBox.Size = new System.Drawing.Size(172, 97);
            this.propertiesCheckedListBox.TabIndex = 2;
            this.propertiesCheckedListBox.ThreeDCheckBoxes = true;
            // 
            // showBestFriendButton
            // 
            this.showBestFriendButton.BackColor = System.Drawing.SystemColors.Menu;
            this.showBestFriendButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBestFriendButton.Location = new System.Drawing.Point(153, 266);
            this.showBestFriendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showBestFriendButton.Name = "showBestFriendButton";
            this.showBestFriendButton.Size = new System.Drawing.Size(278, 45);
            this.showBestFriendButton.TabIndex = 3;
            this.showBestFriendButton.Text = "Show best facebook friend";
            this.showBestFriendButton.UseVisualStyleBackColor = false;
            this.showBestFriendButton.Click += new System.EventHandler(this.showBestFriendButton_Click);
            // 
            // BestFriendNameLabel
            // 
            this.BestFriendNameLabel.AutoSize = true;
            this.BestFriendNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendNameLabel.Location = new System.Drawing.Point(129, 345);
            this.BestFriendNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BestFriendNameLabel.Name = "BestFriendNameLabel";
            this.BestFriendNameLabel.Size = new System.Drawing.Size(0, 24);
            this.BestFriendNameLabel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.closeButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(210, 426);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(184, 43);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Properties:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Source:";
            // 
            // FormBestFriendFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 582);
            this.Controls.Add(this.postsRadioButton);
            this.Controls.Add(this.albumsRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.BestFriendNameLabel);
            this.Controls.Add(this.showBestFriendButton);
            this.Controls.Add(this.propertiesCheckedListBox);
            this.Controls.Add(this.choosePropertyOfBestFriendLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBestFriendFeature";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton postsRadioButton;
        private System.Windows.Forms.RadioButton albumsRadioButton;
    }
}