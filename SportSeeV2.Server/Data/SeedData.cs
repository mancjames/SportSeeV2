using Microsoft.EntityFrameworkCore;
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
                
                // User 18 sessions
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
        }
    }
}
