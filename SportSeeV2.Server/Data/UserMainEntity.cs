using SportSeeV2.Server.Models;

namespace SportSeeV2.Server.Data
{
    public class UserMainEntity
    {
        public int Id { get; set; }
        public UserInfosEntity UserInfos { get; set; }
        public float TodayScore { get; set; }
        public KeyDataEntity KeyData { get; set; }
    }

    public class UserInfosEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int UserMainEntityId { get; set; } 
        public UserMainEntity UserMainEntity { get; set; } 
    }

    public class KeyDataEntity
    {
        public int Id { get; set; }
        public int CalorieCount { get; set; }
        public int ProteinCount { get; set; }
        public int CarbohydrateCount { get; set; }
        public int LipidCount { get; set; }
        public int UserMainEntityId { get; set; } 
        public UserMainEntity UserMainEntity { get; set; } 
    }
}
