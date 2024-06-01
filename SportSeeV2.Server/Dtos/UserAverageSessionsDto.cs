using System.Text.Json.Serialization;

namespace SportSeeV2.Server.Dtos
{
    public record UserAverageSessionsDto
    {
        [JsonIgnore]
        public int Id { get; init; }
        [JsonPropertyName("id")]
        public int UserMainEntityId { get; init; }
        public SessionsDto[] Sessions { get; init; }
        public UserAverageSessionsDto(int id, int userMainEntityId, SessionsDto[] sessions)
        {
            Id = id;
            UserMainEntityId = userMainEntityId;
            Sessions = sessions;
        }
    }

    public record SessionsDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int Day { get; set; }
        public int SessionLength { get; set; }
        [JsonIgnore]
        public int UserAverageSessionsEntityId { get; set; }
        public SessionsDto(int id, int day, int sessionLength)
        {
            Id = id;
            Day = day;
            SessionLength = sessionLength;
        }
    }
}
