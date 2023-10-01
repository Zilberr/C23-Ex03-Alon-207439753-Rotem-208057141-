using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    internal abstract class ChartUpdater
    {
        protected User User { get; }
        protected Chart StatsChart { get; }
        public ChartUpdater(User i_User, Chart i_StatsChart)
        {
            User = i_User;
            StatsChart = i_StatsChart;
        }
        public void DisplayChart()
        {
            Dictionary<int, int> data = CollectData();

            foreach (var keyValuePairs in data)
            {
                StatsChart.Series[GetSeriesName()].Points.AddXY(keyValuePairs.Key, keyValuePairs.Value);
            }

            StatsChart.Series[GetSeriesName()].ChartType = GetChartType();
            StatsChart.ChartAreas[0].AxisX.Title = "Year";
            StatsChart.ChartAreas[0].AxisY.Title = "Count";
            StatsChart.Show();
        }
        protected abstract Dictionary<int, int> CollectData();
        protected abstract string GetSeriesName();
        protected virtual SeriesChartType GetChartType()
        {
            
            return SeriesChartType.Column;
        }
    }
    internal class PostsChartUpdater : ChartUpdater
    {
        public PostsChartUpdater(User i_User, Chart i_StatsChart) : base(i_User, i_StatsChart)
        {
            Series series = new Series("PostCountByYear");

            StatsChart.Series.Add(series);
        }
        protected override Dictionary<int, int> CollectData()
        {
            Dictionary<int, int> postsCount = new Dictionary<int, int>();

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

            return postsCount;
        }
        protected override string GetSeriesName()
        {
            
            return "PostCountByYear";
        }
    }

    internal class AlbumsChartUpdater : ChartUpdater
    {
        public AlbumsChartUpdater(User i_User, Chart i_StatsChart) : base(i_User, i_StatsChart)
        {
            Series series = new Series("AlbumsCountByYear");
            
            StatsChart.Series.Add(series);
            StatsChart.Titles.Add("Albums Chart By Year");
        }
        protected override Dictionary<int, int> CollectData()
        {
            Dictionary<int, int> albumsCount = new Dictionary<int, int>();

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

            return albumsCount;
        }
        protected override string GetSeriesName()
        {
            
            return "AlbumsCountByYear";
        }
        protected override SeriesChartType GetChartType()
        {
            
            return SeriesChartType.Pie;
        }
    }
}
