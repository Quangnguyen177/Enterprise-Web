namespace COMP1640.Models
{
    public class View
    {
        public int ViewId { get; set; }

        public int NumberOfView { get; set; }

        //FK: Profile ID
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
