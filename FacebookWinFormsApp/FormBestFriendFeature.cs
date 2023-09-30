using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBestFriendFeature : Form
    {
        public FormBestFriendFeature(User i_User)
        {
            InitializeComponent();
            User = i_User;
        }
        private User User { get; set; }
        private Dictionary<User, int> FriendsActivityCount { get; set; }
        private void showBestFriendButton_Click(object sender, EventArgs e)
        {
            if (propertiesCheckedListBox.CheckedItems.Count != 0)
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
                MessageBox.Show("You must check a feature before searching best friend");
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

            updateFromPosts(likesChecked, commentsChecked, tagsChecked);
            updateFromPhotos(likesChecked, commentsChecked, tagsChecked);

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
        private void updateFromPosts(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked)
        {
            foreach (Post post in User.Posts)
            {

                if (i_TagsChecked && post.TaggedUsers != null)
                {
                    foreach (User user in post.TaggedUsers)
                    {
                        incrementFriendInDictionary(user);
                    }
                }

                if (i_LikesChecked && post.LikedBy != null)
                {
                    foreach (User user in post.LikedBy)
                    {
                        incrementFriendInDictionary(user);
                    }
                }

                if (i_CommentsChecked && post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        incrementFriendInDictionary(comment.From);
                    }
                }
            }
        }
        private void updateFromPhotos(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked)
        {
            foreach (Album album in User.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (i_TagsChecked && photo.Tags != null)
                    {
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            incrementFriendInDictionary(tag.User);
                        }
                    }

                    if (i_LikesChecked && photo.LikedBy != null)
                    {
                        foreach (User user in photo.LikedBy)
                        {
                            incrementFriendInDictionary(user);
                        }
                    }

                    if (i_CommentsChecked && photo.Comments != null)
                    {
                        foreach (Comment comment in photo.Comments)
                        {
                            incrementFriendInDictionary(comment.From);
                        }
                    }
                }
            }
        }
        private void incrementFriendInDictionary(User i_UserToIncrement)
        {
            if (FriendsActivityCount.ContainsKey(i_UserToIncrement))
            {
                FriendsActivityCount[i_UserToIncrement]++;
            }
            else
            {
                FriendsActivityCount.Add(i_UserToIncrement, 1);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
