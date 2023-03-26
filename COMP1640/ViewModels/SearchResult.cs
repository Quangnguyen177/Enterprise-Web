using System;

namespace COMP1640.ViewModels
{
    public class SearchResult
    {
        public int IdeaId { get; set; }
        public string IdeaTile { get; set; }
        public string IdeaContent { get; set; }
        public int View { get; set; }
        public int Point { get; set; }
        public int CommentCount { get; set; }
        public string CreatedDate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerId { get; set; }
        public string Category { get; set; }  
        public int CateId { get; set; }
        public bool Anonymous { get; set; }
        public string Avatar { get; set; }
        public string UAvatar { get; set; }
    }
}
