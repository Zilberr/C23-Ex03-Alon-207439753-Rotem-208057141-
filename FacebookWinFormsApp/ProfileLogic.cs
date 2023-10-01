using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ProfileLogic
    {
        private User User { get; }
        public ProfileLogic(User i_User)
        {
            User = i_User;
        }
        public void FetchAlbums(ComplexedItemForFetching i_AlbumsFetcher)
        {
            i_AlbumsFetcher.ListBox.Items.Clear();
            i_AlbumsFetcher.ListBox.DisplayMember = "Name";
            foreach (Album album in User.Albums)
            {
                i_AlbumsFetcher.ListBox.Items.Add(album);
            }
        }
        public void FetchFriends(ComplexedItemForFetching i_FriendsFetcher)
        {
            i_FriendsFetcher.ListBox.Items.Clear();
            i_FriendsFetcher.ListBox.DisplayMember = "Name";
            foreach (User user in User.Friends)
            {
                i_FriendsFetcher.ListBox.Items.Add(user);
            }
        }
        public void DisplaySelectedAlbum(ComplexedItemForFetching i_ComplexAlbum)
        {
            if (i_ComplexAlbum.ListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = i_ComplexAlbum.ListBox.SelectedItem as Album;

                if (selectedAlbum.Pictures != null)
                {
                    i_ComplexAlbum.Image.LoadAsync(selectedAlbum.PictureAlbumURL);

                }
                else
                {
                    i_ComplexAlbum.Image.Image = i_ComplexAlbum.Image.ErrorImage;
                }
            }
        }
    }
}