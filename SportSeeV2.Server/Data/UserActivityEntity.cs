using SportSeeV2.Server.Models;

namespace SportSeeV2.Server.Data
{
    public class UserActivityEntity
    {
        public int id { get; set; }
        public ICollection<ActivitySessionEntity> ActivitySessions{ get; set; }
        public int UserMainEntityId { get; set; }
        public UserMainEntity UserMainEntity { get; set; }
    }

    public class ActivitySessionEntity
    {
        public int id { get; set; }
        public DateOnly day { get; set; }
        public int kilogram { get; set; }
        public int calories { get; set; }
        public int UserActivityEntityId { get; set; }
        public UserActivityEntity UserActivityEntity { get; set; }
    }
}
