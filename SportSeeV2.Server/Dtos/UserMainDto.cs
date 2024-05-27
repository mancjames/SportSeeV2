using SportSeeV2.Server.Data;
using System.Text.Json.Serialization;

namespace SportSeeV2.Server.Dtos
{
    public record UserMainDto(int Id, UserInfosDto UserInfos, float TodayScore, KeyDataDto KeyData);
    public record UserInfosDto(int Id, string FirstName, string LastName, int Age)
    {
        [JsonIgnore]
        public int Id { get; init; }
    };

    public record KeyDataDto(int Id ,int CalorieCount, int ProteinCount, int CarbohydrateCount, int LipidCount)
    {
        [JsonIgnore]
        public int Id { get; init; }
    };

}
