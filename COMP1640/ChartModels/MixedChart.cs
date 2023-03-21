namespace COMP1640.ChartModels
{
    public class MixedChart
    {
        public int Point { get; set; }
        public int View { get; set; }
        public string Date { get; set; }
        public MixedChart(int point, int view, string date)
        {
            Point = point;
            View = view;
            Date = date;
        }

    }
}
