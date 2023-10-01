using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.IDBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homeAddress = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showActivityByPostsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.findBestFriendButton = new System.Windows.Forms.Button();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentModeButton = new System.Windows.Forms.Button();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.statusesPanel = new System.Windows.Forms.Panel();
            this.statusInstructionLabel = new System.Windows.Forms.Label();
            this.showActivityByAlbumsButton = new System.Windows.Forms.Button();
            messageLabel = new System.Windows.Forms.Label();
            this.IDBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.statusesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(4, 17);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(78, 20);
            messageLabel.TabIndex = 20;
            messageLabel.Text = "Message:";
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IDBox.Controls.Add(this.label1);
            this.IDBox.Controls.Add(this.homeAddress);
            this.IDBox.Controls.Add(this.emailAddress);
            this.IDBox.Controls.Add(this.birthday);
            this.IDBox.Controls.Add(this.lastName);
            this.IDBox.Controls.Add(this.firstName);
            this.IDBox.Controls.Add(this.profilePicture);
            this.IDBox.Location = new System.Drawing.Point(144, 108);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(460, 295);
            this.IDBox.TabIndex = 0;
            this.IDBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Profile";
            // 
            // homeAddress
            // 
            this.homeAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.homeAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeAddress.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAddress.Location = new System.Drawing.Point(18, 238);
            this.homeAddress.Multiline = true;
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.ReadOnly = true;
            this.homeAddress.Size = new System.Drawing.Size(242, 36);
            this.homeAddress.TabIndex = 5;
            this.homeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailAddress
            // 
            this.emailAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailAddress.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddress.Location = new System.Drawing.Point(18, 185);
            this.emailAddress.Multiline = true;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.ReadOnly = true;
            this.emailAddress.Size = new System.Drawing.Size(242, 36);
            this.emailAddress.TabIndex = 4;
            this.emailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.birthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthday.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(18, 134);
            this.birthday.Multiline = true;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Size = new System.Drawing.Size(242, 36);
            this.birthday.TabIndex = 3;
            this.birthday.TabStop = false;
            this.birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(222, 68);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Size = new System.Drawing.Size(215, 36);
            this.lastName.TabIndex = 2;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(222, 26);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(215, 34);
            this.firstName.TabIndex = 1;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilePicture
            // 
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePicture.Location = new System.Drawing.Point(60, 22);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(120, 105);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // statsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statsChart.Legends.Add(legend2);
            this.statsChart.Location = new System.Drawing.Point(658, 106);
            this.statsChart.Name = "statsChart";
            this.statsChart.Size = new System.Drawing.Size(992, 357);
            this.statsChart.TabIndex = 8;
            this.statsChart.Text = "chart1";
            this.statsChart.Visible = false;
            // 
            // showActivityByPostsButton
            // 
            this.showActivityByPostsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.showActivityByPostsButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showActivityByPostsButton.Location = new System.Drawing.Point(1696, 222);
            this.showActivityByPostsButton.Name = "showActivityByPostsButton";
            this.showActivityByPostsButton.Size = new System.Drawing.Size(352, 46);
            this.showActivityByPostsButton.TabIndex = 11;
            this.showActivityByPostsButton.Text = "Show activity timeline by posts";
            this.showActivityByPostsButton.UseVisualStyleBackColor = false;
            this.showActivityByPostsButton.Click += new System.EventHandler(this.showActivityByPostsButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.logOutButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(978, 14);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(122, 42);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // findBestFriendButton
            // 
            this.findBestFriendButton.BackColor = System.Drawing.SystemColors.Menu;
            this.findBestFriendButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBestFriendButton.Location = new System.Drawing.Point(1696, 276);
            this.findBestFriendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findBestFriendButton.Name = "findBestFriendButton";
            this.findBestFriendButton.Size = new System.Drawing.Size(352, 48);
            this.findBestFriendButton.TabIndex = 16;
            this.findBestFriendButton.Text = "Find my best facebook friend";
            this.findBestFriendButton.UseVisualStyleBackColor = false;
            this.findBestFriendButton.Click += new System.EventHandler(this.findBestFriendButton_Click);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // parentModeButton
            // 
            this.parentModeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.parentModeButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentModeButton.Location = new System.Drawing.Point(1696, 333);
            this.parentModeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parentModeButton.Name = "parentModeButton";
            this.parentModeButton.Size = new System.Drawing.Size(352, 48);
            this.parentModeButton.TabIndex = 18;
            this.parentModeButton.Text = "Activate parent mode";
            this.parentModeButton.UseVisualStyleBackColor = false;
            this.parentModeButton.Click += new System.EventHandler(this.parentModeButton_Click);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Status);
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(118, 14);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 26);
            this.messageTextBox.TabIndex = 21;
            // 
            // statusesPanel
            // 
            this.statusesPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusesPanel.Controls.Add(this.statusInstructionLabel);
            this.statusesPanel.Controls.Add(this.messageTextBox);
            this.statusesPanel.Controls.Add(messageLabel);
            this.statusesPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.statusesPanel.Location = new System.Drawing.Point(60, 565);
            this.statusesPanel.Name = "statusesPanel";
            this.statusesPanel.Size = new System.Drawing.Size(321, 100);
            this.statusesPanel.TabIndex = 17;
            this.statusesPanel.Visible = false;
            // 
            // statusInstructionLabel
            // 
            this.statusInstructionLabel.AutoSize = true;
            this.statusInstructionLabel.Location = new System.Drawing.Point(87, 54);
            this.statusInstructionLabel.Name = "statusInstructionLabel";
            this.statusInstructionLabel.Size = new System.Drawing.Size(153, 20);
            this.statusInstructionLabel.TabIndex = 22;
            this.statusInstructionLabel.Text = "Rewrite your status! ";
            // 
            // showActivityByAlbumsButton
            // 
            this.showActivityByAlbumsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.showActivityByAlbumsButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showActivityByAlbumsButton.Location = new System.Drawing.Point(1696, 166);
            this.showActivityByAlbumsButton.Name = "showActivityByAlbumsButton";
            this.showActivityByAlbumsButton.Size = new System.Drawing.Size(352, 46);
            this.showActivityByAlbumsButton.TabIndex = 19;
            this.showActivityByAlbumsButton.Text = "Show activity timeline by albums";
            this.showActivityByAlbumsButton.UseVisualStyleBackColor = false;
            this.showActivityByAlbumsButton.Click += new System.EventHandler(this.showActivityByAlbumsButton_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2178, 969);
            this.Controls.Add(this.showActivityByAlbumsButton);
            this.Controls.Add(this.parentModeButton);
            this.Controls.Add(this.statusesPanel);
            this.Controls.Add(this.findBestFriendButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.showActivityByPostsButton);
            this.Controls.Add(this.statsChart);
            this.Controls.Add(this.IDBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfile";
            this.ShowIcon = false;
            this.Text = "MyProfileForm";
            this.IDBox.ResumeLayout(false);
            this.IDBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.statusesPanel.ResumeLayout(false);
            this.statusesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox IDBox;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.TextBox homeAddress;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showActivityByPostsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button findBestFriendButton;
        private BindingSource postBindingSource;
        private Button parentModeButton;
        private BindingSource statusBindingSource;
        private TextBox messageTextBox;
        private Panel statusesPanel;
        private Label statusInstructionLabel;
        private Button showActivityByAlbumsButton;
    }
}