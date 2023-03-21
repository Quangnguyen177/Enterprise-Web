using COMP1640.Models;

namespace COMP1640.ViewModels
{
    public class TopContributor
    {
        public Profile Infor { get; set; }
        public int PostedIdea { get; set; }

        public TopContributor(Profile infor, int postedIdea)
        {
            this.Infor = infor;
            this.PostedIdea = postedIdea;
        }
    }
}
