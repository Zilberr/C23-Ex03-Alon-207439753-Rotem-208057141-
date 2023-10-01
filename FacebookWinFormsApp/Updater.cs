namespace BasicFacebookFeatures
{
    internal class Updater
    {
        public UpdateStrategy UpdateStrategy { get; set; }
        public void Update(bool i_LikesChecked, bool i_CommentsChecked, bool i_TagsChecked)
        {
            UpdateStrategy.UpdateActivityDict(i_LikesChecked, i_CommentsChecked, i_TagsChecked);
        }
    }
}
