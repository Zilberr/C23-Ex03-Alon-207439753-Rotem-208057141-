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
        public void DisplayChart(Chart i_StatsChart)
        {
            Dictionary<int, int> postsCount = new Dictionary<int, int>();
            Dictionary<int, int> albumsCount = new Dictionary<int, int>();

            foreach (Post post in User.Posts)
            {
                int year = post.CreatedTime.Value.Year;

                if (postsCount.ContainsKey(year))
                {
                    postsCount[year]++;
                }
                else
                {
                    postsCount[year] = 1;
                }
            }

            foreach (Album album in User.Albums)
            {
                int year = album.CreatedTime.Value.Year;

                if (albumsCount.ContainsKey(year))
                {
                    albumsCount[year]++;
                }
                else
                {
                    albumsCount[year] = 1;
                }
            }

            i_StatsChart.Invoke(new Action(() =>
            {
                foreach (var keyValuePairs in postsCount)
                {
                    i_StatsChart.Series["PostCountByYear"].Points.AddXY(keyValuePairs.Key, keyValuePairs.Value);
                }

                foreach (var keyValuePairs in albumsCount)
                {
                    i_StatsChart.Series["AlbumsCountByYear"].Points.AddXY(keyValuePairs.Key, keyValuePairs.Value);
                }

                i_StatsChart.Series["PostCountByYear"].ChartType = SeriesChartType.Column;
                i_StatsChart.Series["AlbumsCountByYear"].ChartType = SeriesChartType.Column;
                i_StatsChart.ChartAreas[0].AxisX.Title = "Year";
                i_StatsChart.ChartAreas[0].AxisY.Title = "Count";
            }));
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