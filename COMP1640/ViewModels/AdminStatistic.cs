namespace COMP1640.ViewModels
{
    public class AdminStatistic
    {
        public int Idea { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Comment { get; set; }
        public int OldIdea { get; set; }
        public int OldLike { get; set; }
        public int OldDislike { get; set; }
        public int OldComment { get; set; }

        public AdminStatistic(int idea, int like, int dislike, int comment, int oldIdea, int oldLike, int oldDislike, int oldComment)
        {
            Idea = idea;
            Like = like;
            Dislike = dislike;
            Comment = comment;
            OldIdea = oldIdea;
            OldLike = oldLike;
            OldDislike = oldDislike;
            OldComment = oldComment;
        }
    }
}
