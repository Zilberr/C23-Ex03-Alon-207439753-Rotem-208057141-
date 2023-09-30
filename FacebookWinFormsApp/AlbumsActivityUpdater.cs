using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace BasicFacebookFeatures
{
    internal class AlbumsActivityUpdater : UpdateStrategy
    {

        public AlbumsActivityUpdater(User i_User, Dictionary<User, int> i_Dict) : base(i_User, i_Dict)
        {

        }
        public override void UpdateActivityDict(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked)
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
    }
}
