namespace COMP1640.ChartModels
{
    public class BarChart
    {
        public string Category { get; set; }
        public int NumOfUses { get; set; }

        public BarChart(string cate, int num)
        {
            this.Category = cate;
            this.NumOfUses = num;

        }
    }
}
