namespace COMP1640.ViewModels
{
    public class ViewPage
    {
        public int PageNum { get; set; }
        public string OrderBy { get; set; }
        public string ViewType { get; set; }
        public int Id { get; set; }

        public ViewPage(int pageNum, string orderBy, string viewType, int id)
        {
            PageNum = pageNum;
            OrderBy = orderBy;
            ViewType = viewType;
            Id = id;
        }
    }
}
