namespace COMP1640.ViewModels
{
    public class Statistic
    {
        public int Idea { get; set; }
        public int Contributor { get; set; }
        public int View { get; set; }
        public int Comment { get; set; }

        public Statistic(int idea, int contributor, int view, int comment)
        {
            Idea = idea;
            Contributor = contributor;
            View = view;
            Comment = comment;
        }
        
    }
}
