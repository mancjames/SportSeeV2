namespace SportSeeV2.Server.Models
{
    public class UserAverageSessionModel
    {
        public int id { get; set; }
        public AverageSessions[] averageSessions { get; set; }
    }

    public class AverageSessions
    {
        int day { get; set; }
        int sessionLength { get; set; }
    }
}
