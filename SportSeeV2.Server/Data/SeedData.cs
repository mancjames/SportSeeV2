using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SportSeeV2.Server.Data
{
    public class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            // Seed UserMainEntity
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
        }
    }
}
