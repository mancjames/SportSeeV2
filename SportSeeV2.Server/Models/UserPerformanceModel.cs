using Microsoft.Extensions.Configuration.UserSecrets;

namespace SportSeeV2.Server.Models
{
    public class UserPerformanceModel
    {
        public int userId { get; set; }
        public Data[] data { get; set; }
       
    }

    public class Data
    {
        public int value { get; set; }
        public Kind kind { get; set; }
    }

    public enum Kind
    {
        cardio,
        energy,
        endurance,
        strength,
        speed,
        intensity
    }
}
