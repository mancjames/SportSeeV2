using SportSeeV2.Server.Enums;

namespace SportSeeV2.Server.Data
{
    public class UserPerformanceEntity
    {
        public int Id { get; set; }
        public int UserMainEntityId { get; set; }
        public UserMainEntity UserMainEntity { get; set; }
        public ICollection<PerformanceDataEntity> Data { get; set; }
    }
    public class PerformanceDataEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public PerformanceKind Kind { get; set; }
        public int UserPerformanceEntityId { get; set; }
        public UserPerformanceEntity UserPerformanceEntity { get; set; }
    }
}
