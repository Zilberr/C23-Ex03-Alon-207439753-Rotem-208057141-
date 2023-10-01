using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBestFriendFeature : Form
    {
        private User User { get; set; }
        private Dictionary<User, int> FriendsActivityCount { get; set; }
        private Updater Updater { get; set; }
        public FormBestFriendFeature(User i_User)
        {
            InitializeComponent();
            User = i_User;
            Updater = new Updater();
        }
        private void showBestFriendButton_Click(object sender, EventArgs e)
        {
            if (propertiesCheckedListBox.CheckedItems.Count != 0 && (albumsRadioButton.Checked || postsRadioButton.Checked))
            {
                string name = calculateBestFacebookFriend();

                if (!name.Equals(""))
                {
                    BestFriendNameLabel.Text = $"{name} is your best facebook friend!";
                }
                else
                {
                    BestFriendNameLabel.Text = "Best facebook friend not found :(";
                }
            }
            else
            {
                MessageBox.Show("You must check a feature and source before searching friend");
            }
        }
        private string calculateBestFacebookFriend()
        {
            FriendsActivityCount = new Dictionary<User, int>();
            bool likesChecked = false, commentsChecked = false, tagsChecked = false;
            int maxActivityCount = 0;
            string nameOfMaxActivityFriend = "";

            foreach (string itemName in propertiesCheckedListBox.CheckedItems)
            {
                if (itemName.Equals("Likes"))
                {
                    likesChecked = true;
                }
                else if (itemName.Equals("Comments"))
                {
                    commentsChecked = true;
                }
                else if (itemName.Equals("Tags"))
                {
                    tagsChecked = true;
                }
            }

            foreach (string itemName in propertiesCheckedListBox.CheckedItems)
            {
                if (itemName.Equals("Likes"))
                {
                    likesChecked = true;
                }
                else if (itemName.Equals("Comments"))
                {
                    commentsChecked = true;
                }
                else if (itemName.Equals("Tags"))
                {
                    tagsChecked = true;
                }
            }

            try
            {
                if (albumsRadioButton.Checked)
                {
                    AlbumsActivityUpdater albumsActivityUpdater = new AlbumsActivityUpdater(User, FriendsActivityCount);
                    Updater.UpdateStrategy = albumsActivityUpdater;
                }
                else
                {
                    PostsActivityUpdater postsActivityUpdater = new PostsActivityUpdater(User, FriendsActivityCount);
                    Updater.UpdateStrategy = postsActivityUpdater;
                }
                Updater.Update(likesChecked, commentsChecked, tagsChecked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            foreach (var keyValuePairs in FriendsActivityCount)
            {
                if (keyValuePairs.Value > maxActivityCount)
                {
                    maxActivityCount = keyValuePairs.Value;
                    nameOfMaxActivityFriend = keyValuePairs.Key.Name;
                }
            }

            return nameOfMaxActivityFriend;
        }
        private void albumsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (albumsRadioButton.Checked == true)
            {
                postsRadioButton.Checked = false;
            }
        }
        private void postsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (postsRadioButton.Checked == true)
            {
                albumsRadioButton.Checked = false;
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
