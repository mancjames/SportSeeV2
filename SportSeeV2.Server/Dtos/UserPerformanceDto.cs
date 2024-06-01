using System.Text.Json.Serialization;

namespace SportSeeV2.Server.Dtos
{
    public record UserPerformanceDto
    {
        [JsonIgnore]
        public int Id { get; init; }

        [JsonPropertyName("id")]
        public int UserMainEntityId { get; init; }

        public Dictionary<int, string> Kind { get; init; }
        public PerformanceDataDto[] Data { get; init; }

        public UserPerformanceDto(int id, int userMainEntityId, Dictionary<int, string> kind, PerformanceDataDto[] data)
        {
            Id = id;
            UserMainEntityId = userMainEntityId;
            Kind = kind;
            Data = data;
        }
    }

    public record PerformanceDataDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int Value { get; set; }
        public int Kind { get; set; }

        [JsonIgnore]
        public int UserPerformanceEntityId { get; set; }

        public PerformanceDataDto(int id, int value, int kind)
        {
            Id = id;
            Value = value;
            Kind = kind;
        }
    }
}
