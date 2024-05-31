using System.Text.Json.Serialization;

namespace SportSeeV2.Server.Dtos
{
    public record UserActivityDto
    {
        [JsonIgnore]
        public int Id { get; init; }

        [JsonPropertyName("id")]
        public int UserMainEntityId { get; init; }

        public ActivitySessionsDto[] ActivitySessions { get; init; }

        public UserActivityDto(int id, int userMainEntityId, ActivitySessionsDto[] activitySessions)
        {
            Id = id;
            UserMainEntityId = userMainEntityId;
            ActivitySessions = activitySessions;
        }
    }

    public record ActivitySessionsDto
    {
        public string Date { get; init; }
        public int Kilogram { get; init; }
        public int Calories { get; init; }
        [JsonIgnore]
        public int Id { get; init; }
        [JsonIgnore]
        public int UserActivityEntityId { get; init; }

        public ActivitySessionsDto(string date, int kilogram, int calories)
        {
            Date = date;
            Kilogram = kilogram;
            Calories = calories;
        }
    }

}
