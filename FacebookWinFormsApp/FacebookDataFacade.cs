using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookDataFacade
    {
        private User m_User;

        public FacebookDataFacade(User user)
        {
            m_User = user;
        }

        public List<Album> GetAlbums()
        {

        }

        public List<Post> GetPosts()
        {

        }

        public List<User> GetFriends()
        {

        }
    }
}
