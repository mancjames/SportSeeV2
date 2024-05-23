namespace SportSeeV2.Server.Models
{
    public class UserActivityModel
    {
        public int id { get; set; }
        public ActivitySession[] sessions { get; set; }
    }

    public class ActivitySession
    {
        public DateOnly day { get; set;}
        public int kilogram { get; set;}
        public int calories { get; set;}
    }
}
