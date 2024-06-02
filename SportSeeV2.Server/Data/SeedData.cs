using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Enums;
using System.Collections.Generic;

namespace SportSeeV2.Server.Data
{
    public class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<UserMainEntity>().HasData(new List<UserMainEntity>
            {
                new UserMainEntity
                {
                    Id = 1,
                    TodayScore = 0.12F
                },
                new UserMainEntity
                {
                    Id = 2,
                    TodayScore = 0.3F
                }
            });

            builder.Entity<UserInfosEntity>().HasData(new List<UserInfosEntity>
            {
                new UserInfosEntity
                {
                    Id = 1,
                    FirstName = "Karl",
                    LastName = "Dovineau",
                    Age = 31,
                    UserMainEntityId = 1
                },
                new UserInfosEntity
                {
                    Id = 2,
                    FirstName = "Cecilia",
                    LastName = "Ratorez",
                    Age = 34,
                    UserMainEntityId = 2
                }
            });

            builder.Entity<KeyDataEntity>().HasData(new List<KeyDataEntity>
            {
                new KeyDataEntity
                {
                    Id = 1,
                    CalorieCount = 1930,
                    ProteinCount = 155,
                    CarbohydrateCount = 290,
                    LipidCount = 50,
                    UserMainEntityId = 1
                },
                new KeyDataEntity
                {
                    Id = 2,
                    CalorieCount = 2500,
                    ProteinCount = 90,
                    CarbohydrateCount = 150,
                    LipidCount = 120,
                    UserMainEntityId = 2
                }
            });

            builder.Entity<UserActivityEntity>().HasData(new List<UserActivityEntity>
            {
                new UserActivityEntity
                {
                    id = 1,
                    UserMainEntityId = 1
                },
                new UserActivityEntity
                {
                    id = 2,
                    UserMainEntityId = 2
                }
            });

            builder.Entity<ActivitySessionEntity>().HasData(new List<ActivitySessionEntity>
            {
                new ActivitySessionEntity
                {
                    id = 1,
                    day = new DateOnly(2020, 7, 1),
                    kilogram = 80,
                    calories = 240,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 2,
                    day = new DateOnly(2020, 7, 2),
                    kilogram = 80,
                    calories = 220,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 3,
                    day = new DateOnly(2020, 7, 3),
                    kilogram = 81,
                    calories = 280,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 4,
                    day = new DateOnly(2020, 7, 4),
                    kilogram = 81,
                    calories = 290,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 5,
                    day = new DateOnly(2020, 7, 5),
                    kilogram = 80,
                    calories = 160,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 6,
                    day = new DateOnly(2020, 7, 6),
                    kilogram = 78,
                    calories = 162,
                    UserActivityEntityId = 1
                },
                new ActivitySessionEntity
                {
                    id = 7,
                    day = new DateOnly(2020, 7, 7),
                    kilogram = 76,
                    calories = 390,
                    UserActivityEntityId = 1
                },
                
                new ActivitySessionEntity
                {
                    id = 8,
                    day = new DateOnly(2020, 7, 1),
                    kilogram = 70,
                    calories = 240,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 9,
                    day = new DateOnly(2020, 7, 2),
                    kilogram = 69,
                    calories = 220,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 10,
                    day = new DateOnly(2020, 7, 3),
                    kilogram = 70,
                    calories = 280,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 11,
                    day = new DateOnly(2020, 7, 4),
                    kilogram = 70,
                    calories = 500,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 12,
                    day = new DateOnly(2020, 7, 5),
                    kilogram = 69,
                    calories = 160,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 13,
                    day = new DateOnly(2020, 7, 6),
                    kilogram = 69,
                    calories = 162,
                    UserActivityEntityId = 2
                },
                new ActivitySessionEntity
                {
                    id = 14,
                    day = new DateOnly(2020, 7, 7),
                    kilogram = 69,
                    calories = 390,
                    UserActivityEntityId = 2
                }
            });
            builder.Entity<UserAverageSessionsEntity>().HasData(new List<UserAverageSessionsEntity>
            {
                new UserAverageSessionsEntity
                {
                    id = 1,
                    UserMainEntityId = 1
                },
                new UserAverageSessionsEntity
                {
                    id = 2,
                    UserMainEntityId = 2
                }
            });
            builder.Entity<SessionsEntity>().HasData(new List<SessionsEntity>
            {
                new SessionsEntity { id = 1, day = 1, sessionLength = 30, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 2, day = 2, sessionLength = 23, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 3, day = 3, sessionLength = 45, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 4, day = 4, sessionLength = 50, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 5, day = 5, sessionLength = 0, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 6, day = 6, sessionLength = 0, UserAverageSessionsEntityId = 1 },
                new SessionsEntity { id = 7, day = 7, sessionLength = 60, UserAverageSessionsEntityId = 1 }
            });
            builder.Entity<SessionsEntity>().HasData(new List<SessionsEntity>
            {
                new SessionsEntity { id = 8, day = 1, sessionLength = 30, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 9, day = 2, sessionLength = 40, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 10, day = 3, sessionLength = 50, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 11, day = 4, sessionLength = 30, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 12, day = 5, sessionLength = 30, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 13, day = 6, sessionLength = 50, UserAverageSessionsEntityId = 2 },
                new SessionsEntity { id = 14, day = 7, sessionLength = 50, UserAverageSessionsEntityId = 2 }
            });
            builder.Entity<UserPerformanceEntity>().HasData(
                 new UserPerformanceEntity
                 {
                     Id = 1,
                     UserMainEntityId = 1
                 },
                new UserPerformanceEntity
                {
                    Id = 2,
                    UserMainEntityId = 2
                }
            );
            builder.Entity<PerformanceDataEntity>().HasData(
                    new PerformanceDataEntity { Id = 1, Value = 80, Kind = PerformanceKind.Cardio, UserPerformanceEntityId = 1 },
                    new PerformanceDataEntity { Id = 2, Value = 120, Kind = PerformanceKind.Energy, UserPerformanceEntityId = 1 },
                    new PerformanceDataEntity { Id = 3, Value = 140, Kind = PerformanceKind.Endurance, UserPerformanceEntityId = 1 },
                    new PerformanceDataEntity { Id = 4, Value = 50, Kind = PerformanceKind.Strength, UserPerformanceEntityId = 1 },
                    new PerformanceDataEntity { Id = 5, Value = 200, Kind = PerformanceKind.Speed, UserPerformanceEntityId = 1 },
                    new PerformanceDataEntity { Id = 6, Value = 90, Kind = PerformanceKind.Intensity, UserPerformanceEntityId = 1 },

                    new PerformanceDataEntity { Id = 7, Value = 200, Kind = PerformanceKind.Cardio, UserPerformanceEntityId = 2 },
                    new PerformanceDataEntity { Id = 8, Value = 240, Kind = PerformanceKind.Energy, UserPerformanceEntityId = 2 },
                    new PerformanceDataEntity { Id = 9, Value = 80, Kind = PerformanceKind.Endurance, UserPerformanceEntityId = 2 },
                    new PerformanceDataEntity { Id = 10, Value = 80, Kind = PerformanceKind.Strength, UserPerformanceEntityId = 2 },
                    new PerformanceDataEntity { Id = 11, Value = 220, Kind = PerformanceKind.Speed, UserPerformanceEntityId = 2 },
                    new PerformanceDataEntity { Id = 12, Value = 110, Kind = PerformanceKind.Intensity, UserPerformanceEntityId = 2 }
                );
        }
    }
}
