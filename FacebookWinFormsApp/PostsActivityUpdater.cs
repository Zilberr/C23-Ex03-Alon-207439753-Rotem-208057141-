using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostsActivityUpdater : UpdateStrategy
    {
        public PostsActivityUpdater(User i_User, Dictionary<User, int> i_Dict) : base(i_User, i_Dict)
        {
        }
        public override void UpdateActivityDict(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked)
        {
            foreach (Post post in User.Posts)
            {
                if (i_TagsChecked && post.TaggedUsers != null)
                {
                    foreach (User user in post.TaggedUsers)
                    {
                        IncrementFriendInDictionary(user);
                    }
                }

                if (i_LikesChecked && post.LikedBy != null)
                {
                    foreach (User user in post.LikedBy)
                    {
                        IncrementFriendInDictionary(user);
                    }
                }

                if (i_CommentsChecked && post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        IncrementFriendInDictionary(comment.From);
                    }
                }
            }
        }
    }
}
