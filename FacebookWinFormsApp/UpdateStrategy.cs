using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace BasicFacebookFeatures
{
    internal abstract class UpdateStrategy
    {
        protected User User { get; set; }
        protected Dictionary<User, int> FriendsActivity { get; set; }
        public UpdateStrategy(User user, Dictionary<User, int> i_Dict)
        {
            User = user;
            FriendsActivity = i_Dict;
        }
        public abstract void UpdateActivityDict(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked);
        protected void incrementFriendInDictionary(User i_UserToIncrement)
        {
            if (FriendsActivity.ContainsKey(i_UserToIncrement))
            {
                FriendsActivity[i_UserToIncrement]++;
            }
            else
            {
                FriendsActivity.Add(i_UserToIncrement, 1);
            }
        }
    }
}
