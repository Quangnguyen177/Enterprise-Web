namespace COMP1640.ChartModels
{
    public class PieChart
    {
        public string Department { get; set; }
        public double Contributors { get; set; }

        public PieChart(string department, double contributors)
        {
            this.Department = department;
            this.Contributors = contributors;
        }

    }
}
