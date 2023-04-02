namespace COMP1640.ViewModels
{
    public class Statistic
    {
        public int Idea { get; set; }
        public int Contributor { get; set; }
        public int View { get; set; }
        public int Comment { get; set; }
        public int OldIdea { get; set; }
        public int OldContributor { get; set; }
        public int OldView { get; set; }
        public int OldComment { get; set; }

        public Statistic(int idea, int contributor, int view, int comment, int oldIdea, int oldContributor, int oldView, int oldComment)
        {
            Idea = idea;
            Contributor = contributor;
            View = view;
            Comment = comment;
            OldIdea = oldIdea;
            OldContributor = oldContributor;
            OldView = oldView;
            OldComment = oldComment;
        }
    }
}
