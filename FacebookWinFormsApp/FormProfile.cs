using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;
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

        public FormProfile(User i_UserLoggedIn)
        {
            InitializeComponent();
            InitializeComplexComponents();
            m_ParentModeFacade = new ParentModeFacade(this);
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
            m_ParentModeFacade.AttachToParentMode(homeAddressObserver);
            m_ParentModeFacade.AttachToParentMode(emailAddressObserver);
            m_ParentModeFacade.AttachToParentMode(birthdayObserver);
            m_ParentModeFacade.AttachToParentMode(profilePictureObserver);
            m_ParentModeFacade.AttachToParentMode(findBestFriendButtonObserver);
        }
        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            m_ProfileLogic.FetchAlbums(m_AlbumsFetcher);
            m_AlbumsFetcher.ListBox.Show();
            m_AlbumsFetcher.Label.Visible = true;
            LabelObserver labelAlbumsFetcherObserver = new LabelObserver(m_AlbumsFetcher.Label);
            PictureBoxObserver albumsFetchersImageObserver = new PictureBoxObserver(m_AlbumsFetcher.Image);
            m_ParentModeFacade.AttachToParentMode(labelAlbumsFetcherObserver);
            m_ParentModeFacade.AttachToParentMode(albumsFetchersImageObserver);
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
            LabelObserver labelStatusesFetcherObserver = new LabelObserver(m_StatusesFetcher.Label);
            PanelObserver statusesPanelObserver = new PanelObserver(statusesPanel);
            m_ParentModeFacade.AttachToParentMode(labelStatusesFetcherObserver);
            m_ParentModeFacade.AttachToParentMode(statusesPanelObserver);
        }
        private void showActivityButton_Click(object sender, EventArgs e)
        {
            new Thread(() => m_ProfileLogic.DisplayChart(statsChart)).Start();
            statsChart.Show();
            myActivityTimlineHeader.Visible = true;
            showActivityButton.Enabled = false;
            ChartObserver statsChartObserver = new ChartObserver(statsChart);
            LabelObserver myActivityTimlineHeaderObserver = new LabelObserver(myActivityTimlineHeader);
            m_ParentModeFacade.AttachToParentMode(statsChartObserver);
            m_ParentModeFacade.AttachToParentMode(myActivityTimlineHeaderObserver);
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
            private FormProfile FormProfile { get; set; }
            private List<IObserverForParentMode> m_Observers;
            public ParentModeFacade(FormProfile i_FormProfile)
            {
                FormProfile = i_FormProfile;
                m_Observers = new List<IObserverForParentMode>();
            }
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
