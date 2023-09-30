using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormProfile : Form
    {
        private ComplexedItemForFetching m_AlbumsFetcher;
        private ComplexedItemForFetching m_StatusesFetcher;
        private ComplexedItemForFetching m_FriendsFetcher;
        private ParentModeFacade m_ParentModeFacade;
        private ProfileLogic m_ProfileLogic;
        private bool m_ActivatedParentMode = false;

        public FormProfile(User i_UserLoggedIn)
        {
            InitializeComponent();
            InitializeComplexComponents();
            m_ParentModeFacade = new ParentModeFacade(this);
            User = i_UserLoggedIn;
            m_ProfileLogic = new ProfileLogic(User);
            initializeID();
        }
        private void InitializeComplexComponents()
        {
            this.m_AlbumsFetcher = new ComplexedItemForFetching.Builder(new System.Drawing.Point(820, 550))
                .AddButton("Show albums", new EventHandler(this.fetchAlbumsButton_Click))
                .AddListBoxWithEvent(new EventHandler(this.albumsList_SelectedIndexChanged))
                .AddImage()
                .AddLabel("Select an album to view and edit some details")
                .Build();

            this.m_StatusesFetcher = new ComplexedItemForFetching.Builder(new System.Drawing.Point(360, 550))
                .AddButton("Show statuses", new EventHandler(this.fetchStatusesButton_Click))
                .AddListBox()
                .AddSecondaryPanel(statusesPanel)
                .AddLabel("Select a status to change it's text")
                .Build();

            this.m_FriendsFetcher = new ComplexedItemForFetching.Builder(new System.Drawing.Point(590, 550))
                .AddButton("Show friends", new EventHandler(this.showFriendsList_Click))
                .AddListBoxWithEvent(null)
                .Build();

            m_AlbumsFetcher.ListBox.DisplayMember = "Name";
            m_FriendsFetcher.ListBox.DisplayMember = "Name";
            m_StatusesFetcher.ListBox.DisplayMember = "Message";
            m_StatusesFetcher.ListBox.DataSource = statusBindingSource;
            this.Controls.Add(m_AlbumsFetcher.Button);
            this.Controls.Add(m_AlbumsFetcher.Image);
            this.Controls.Add(m_AlbumsFetcher.Label);
            this.Controls.Add(m_AlbumsFetcher.ListBox);
            this.Controls.Add(m_StatusesFetcher.Button);
            this.Controls.Add(m_StatusesFetcher.SecondaryListBox);
            this.Controls.Add(m_StatusesFetcher.Label);
            this.Controls.Add(m_StatusesFetcher.ListBox);
            this.Controls.Add(m_FriendsFetcher.Button);
            this.Controls.Add(m_FriendsFetcher.ListBox);
        }
        private User User { get; set; }
        private void initializeID()
        {
            profilePicture.LoadAsync(User.PictureNormalURL);
            firstName.Text = User.FirstName;
            lastName.Text = User.LastName;
            birthday.Text = User.Birthday;
            homeAddress.Text = User.Location.Name;
            emailAddress.Text = User.Email;
        }
        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            m_ProfileLogic.FetchAlbums(m_AlbumsFetcher);
            m_AlbumsFetcher.ListBox.Show();
            m_AlbumsFetcher.Label.Visible = true;
        }
        private void albumsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ProfileLogic.DisplaySelectedAlbum(m_AlbumsFetcher);
        }
        private void fetchStatusesButton_Click(object sender, EventArgs e)
        {
            statusBindingSource.DataSource = User.Statuses;
            m_StatusesFetcher.ListBox.Show();
            m_StatusesFetcher.Label.Visible = true;
            statusesPanel.Visible = true;
        }
        private void showActivityButton_Click(object sender, EventArgs e)
        {
            new Thread(() => m_ProfileLogic.DisplayChart(statsChart)).Start();
            statsChart.Show();
            myActivityTimlineHeader.Visible = true;
            showActivityButton.Enabled = false;
        }
        private void showFriendsList_Click(object sender, EventArgs e)
        {
            m_FriendsFetcher.ListBox.Show();
            m_ProfileLogic.FetchFriends(m_FriendsFetcher);
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void findBestFriendButton_Click(object sender, EventArgs e)
        {
            FormBestFriendFeature featuresForm = new FormBestFriendFeature(User);
            featuresForm.ShowDialog();
        }
        private void parentModeButton_Click(object sender, EventArgs e)
        {

            FormInputPassword parentModeForm = FormInputPassword.GetInstance();
            parentModeForm.ShowDialog();

            if (m_ActivatedParentMode)
            {
                m_ParentModeFacade.DeactivateParentMode();
                m_ActivatedParentMode = false;
                parentModeButton.Text = "Activate parent mode";
            }
            else
            {
                m_ParentModeFacade.ActivateParentMode();
                m_ActivatedParentMode = true;
                parentModeButton.Text = "Deactivate parent mode";
            }

        }
        private class ParentModeFacade
        {
            private FormProfile FormProfile { get; set; }
            public ParentModeFacade(FormProfile i_FormProfile)
            {
                FormProfile = i_FormProfile;
            }
            public void ActivateParentMode()
            {
                FormProfile.homeAddress.Visible = false;
                FormProfile.emailAddress.Visible = false;
                FormProfile.birthday.Visible = false;
                FormProfile.profilePicture.Visible = false;
                FormProfile.findBestFriendButton.Enabled = false;
                FormProfile.statusesPanel.Enabled = false;
                FormProfile.m_AlbumsFetcher.Image.Visible = false;
            }
            public void DeactivateParentMode()
            {
                FormProfile.homeAddress.Visible = true;
                FormProfile.emailAddress.Visible = true;
                FormProfile.birthday.Visible = true;
                FormProfile.profilePicture.Visible = true;
                FormProfile.findBestFriendButton.Enabled = true;
                FormProfile.m_AlbumsFetcher.Image.Visible = true;
                FormProfile.statusesPanel.Enabled = true;

            }
        }
    }
}
