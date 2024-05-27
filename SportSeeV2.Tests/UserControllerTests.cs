using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SportSeeV2.Server.Controllers;
using SportSeeV2.Server.Data;
using SportSeeV2.Server.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportSeeV2.Tests
{
    [TestFixture]
    public class UserControllerTests
    {
        private SportSeeDbContext _context;
        private UserController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<SportSeeDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new SportSeeDbContext(options);

            SeedTestData();

            _controller = new UserController(new UserMainRepository(_context));
        }

        private void SeedTestData()
        {
            // To complete testing - have created a mock version of the database and created fake data below to test on 
            var users = new List<UserMainEntity>
            {
                new UserMainEntity
                {
                    Id = 1,
                    TodayScore = 0.0f,
                    UserInfos = new UserInfosEntity
                    {
                        Id = 1,
                        FirstName = "test1",
                        LastName = "test1",
                        Age = 32
                    },
                    KeyData = new KeyDataEntity
                    {
                        Id = 1,
                        CalorieCount = 100,
                        ProteinCount = 100,
                        CarbohydrateCount = 100,
                        LipidCount = 100
                    }
                },
                new UserMainEntity
                {
                    Id = 2,
                    TodayScore = 0.0f,
                    UserInfos = new UserInfosEntity
                    {
                        Id = 2,
                        FirstName = "test2",
                        LastName = "test2",
                        Age = 20
                    },
                    KeyData = new KeyDataEntity
                    {
                        Id = 2,
                        CalorieCount = 200,
                        ProteinCount = 200,
                        CarbohydrateCount = 200,
                        LipidCount = 200
                    }
                }
            };

            _context.UserMainEntities.AddRange(users);
            _context.SaveChanges();
        }

        [Test]
        public async Task GetUsers_ReturnsUsers()
        {
            var result = await _controller.GetUsers();

            Assert.NotNull(result);
            Assert.IsInstanceOf<ActionResult<IEnumerable<UserMainDto>>>(result);
            Assert.IsTrue(result.Result is OkObjectResult);

            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult?.Value);

            var returnedUsers = okResult.Value as List<UserMainDto>;
            Assert.IsNotNull(returnedUsers);

            Assert.AreEqual(2, returnedUsers.Count);
            Assert.AreEqual(1, returnedUsers[0].Id);
            Assert.AreEqual("test1", returnedUsers[0].UserInfos.FirstName);
            Assert.AreEqual("test1", returnedUsers[0].UserInfos.LastName);
            Assert.AreEqual(32, returnedUsers[0].UserInfos.Age);
            Assert.AreEqual(100, returnedUsers[0].KeyData.CalorieCount);

            foreach (var user in returnedUsers)
            {
                var matchingUser = returnedUsers.FirstOrDefault(u => u.Id == user.Id);
                Assert.IsNotNull(matchingUser);
            }
        }
    }
}
