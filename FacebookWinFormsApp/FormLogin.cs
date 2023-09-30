using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }
        private LoginResult LoginResult { get; set; }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginResult == null)
            {
                login();
            }
        }
        private void login()
        {
            LoginResult = FacebookService.Login("592245406316659", "user_birthday", "user_hometown", "user_location", "user_likes",
                "user_events", "user_photos", "user_friends", "user_posts", "user_gender", "email");
            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                FormProfile loggedIn = new FormProfile(LoginResult.LoggedInUser);
                loggedIn.ShowDialog();
                LoginResult = null;
            }
        }
    }
}
