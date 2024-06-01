namespace SportSeeV2.Server.Data
{
    public class UserAverageSessionsEntity
    {
        public int id { get; set; }
        public int UserMainEntityId { get; set; }
        public UserMainEntity UserMainEntity { get; set; }
        public ICollection<SessionsEntity> Sessions { get; set; }
    }

    public class SessionsEntity
    {
        public int id { get; set; }
        //below is a number to match previous data provided from node backend
        public int day { get; set; }
        public int sessionLength { get; set; } 
        public int UserAverageSessionsEntityId { get; set; }
        public UserAverageSessionsEntity UserAverageSessionsEntity { get; set; }
    }
}
