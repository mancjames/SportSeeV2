namespace SportSeeV2.Server.Models
{
    public class UserMainModel
    {
        public int id { get; set; }
        public UserInfos userInfos { get; set; }
        public float todayScore { get; set; }

    }

    public class UserInfos
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }

    public class  KeyData 
    {
        public int calorieCount { get; set; }
        public int proteinCount { get; set; }
        public int carbohydrateCount { get; set; }
        public int lipidCount { get; set; }
    }
}
