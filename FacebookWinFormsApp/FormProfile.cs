using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

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
        private ButtonObserver m_PostsButtonObserver;
        private ButtonObserver m_AlbumsButtonObserver;
        public FormProfile(User i_UserLoggedIn)
        {
            InitializeComponent();
            InitializeComplexComponents();
            m_ParentModeFacade = new ParentModeFacade();
            User = i_UserLoggedIn;
            m_ProfileLogic = new ProfileLogic(User);
            initializeID();
            initializeParentMode();
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
        private void initializeParentMode()
        {
            TextBoxObserver homeAddressObserver = new TextBoxObserver(homeAddress);
            TextBoxObserver emailAddressObserver = new TextBoxObserver(emailAddress);
            TextBoxObserver birthdayObserver = new TextBoxObserver(birthday);
            PictureBoxObserver profilePictureObserver = new PictureBoxObserver(profilePicture);
            ButtonObserver findBestFriendButtonObserver = new ButtonObserver(findBestFriendButton);
            ButtonObserver albumsFetchButton = new ButtonObserver(m_AlbumsFetcher.Button);
            ButtonObserver statusesFetchButton = new ButtonObserver(m_StatusesFetcher.Button);
            ButtonObserver friendsFetchButton = new ButtonObserver(m_FriendsFetcher.Button);
            m_PostsButtonObserver = new ButtonObserver(showActivityByPostsButton);
            m_AlbumsButtonObserver = new ButtonObserver(showActivityByAlbumsButton);

            m_ParentModeFacade.AttachToParentMode(homeAddressObserver);
            m_ParentModeFacade.AttachToParentMode(emailAddressObserver);
            m_ParentModeFacade.AttachToParentMode(birthdayObserver);
            m_ParentModeFacade.AttachToParentMode(profilePictureObserver);
            m_ParentModeFacade.AttachToParentMode(findBestFriendButtonObserver);
            m_ParentModeFacade.AttachToParentMode(albumsFetchButton);
            m_ParentModeFacade.AttachToParentMode(statusesFetchButton);
            m_ParentModeFacade.AttachToParentMode(friendsFetchButton);
            m_ParentModeFacade.AttachToParentMode(m_PostsButtonObserver);
            m_ParentModeFacade.AttachToParentMode(m_AlbumsButtonObserver);
        }
        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            LabelObserver labelAlbumsFetcherObserver = new LabelObserver(m_AlbumsFetcher.Label);
            PictureBoxObserver albumsFetchersImageObserver = new PictureBoxObserver(m_AlbumsFetcher.Image);
            
            m_ProfileLogic.FetchAlbums(m_AlbumsFetcher);
            m_AlbumsFetcher.ListBox.Show();
            m_AlbumsFetcher.Label.Visible = true;
            m_ParentModeFacade.AttachToParentMode(labelAlbumsFetcherObserver);
            m_ParentModeFacade.AttachToParentMode(albumsFetchersImageObserver);
        }
        private void albumsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ProfileLogic.DisplaySelectedAlbum(m_AlbumsFetcher);
        }
        private void fetchStatusesButton_Click(object sender, EventArgs e)
        {
            LabelObserver labelStatusesFetcherObserver = new LabelObserver(m_StatusesFetcher.Label);
            PanelObserver statusesPanelObserver = new PanelObserver(statusesPanel);
            
            statusBindingSource.DataSource = User.Statuses;
            m_StatusesFetcher.ListBox.Show();
            m_StatusesFetcher.Label.Visible = true;
            statusesPanel.Visible = true;
            m_ParentModeFacade.AttachToParentMode(labelStatusesFetcherObserver);
            m_ParentModeFacade.AttachToParentMode(statusesPanelObserver);
        }
        private void showActivityByPostsButton_Click(object sender, EventArgs e)
        {
            PostsChartUpdater postsChartUpdater = new PostsChartUpdater(User, statsChart);
            ChartObserver statsChartObserver = new ChartObserver(statsChart);

            postsChartUpdater.DisplayChart();
            showActivityByPostsButton.Enabled = false;
            showActivityByAlbumsButton.Enabled = false;
            m_ParentModeFacade.DetachToParentMode(m_PostsButtonObserver);
            m_ParentModeFacade.DetachToParentMode(m_AlbumsButtonObserver);
            m_ParentModeFacade.AttachToParentMode(statsChartObserver);
        }
        private void showActivityByAlbumsButton_Click(object sender, EventArgs e)
        {
            AlbumsChartUpdater albumsChartUpdater = new AlbumsChartUpdater(User, statsChart);
            ChartObserver statsChartObserver = new ChartObserver(statsChart);

            albumsChartUpdater.DisplayChart();
            showActivityByAlbumsButton.Enabled = false;
            showActivityByPostsButton.Enabled = false;
            m_ParentModeFacade.DetachToParentMode(m_PostsButtonObserver);
            m_ParentModeFacade.DetachToParentMode(m_AlbumsButtonObserver);
            m_ParentModeFacade.AttachToParentMode(statsChartObserver);
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
                m_ActivatedParentMode = false;
                parentModeButton.Text = "Activate parent mode";
            }
            else
            {
                m_ActivatedParentMode = true;
                parentModeButton.Text = "Deactivate parent mode";
            }

            m_ParentModeFacade.NotifyToObservers(m_ActivatedParentMode);
        }
        private class ParentModeFacade
        {
            private List<IObserverForParentMode> m_Observers = new List<IObserverForParentMode>();
            public void AttachToParentMode(IObserverForParentMode i_Observer)
            {
                m_Observers.Add(i_Observer);
            }
            public void DetachToParentMode(IObserverForParentMode i_Observer)
            {
                m_Observers.Remove(i_Observer);
            }
            public void NotifyToObservers(bool i_ParentModeStatus)
            {
                foreach (IObserverForParentMode observer in m_Observers)
                {
                    observer.Update(i_ParentModeStatus);
                }
            }
        }
    }
}
