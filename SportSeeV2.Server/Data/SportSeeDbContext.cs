using Microsoft.EntityFrameworkCore;

namespace SportSeeV2.Server.Data
{
    public class SportSeeDbContext : DbContext
    {
        public SportSeeDbContext(DbContextOptions<SportSeeDbContext> options) : base(options) { }
        public DbSet<UserMainEntity> UserMainEntities => Set<UserMainEntity>();
        public DbSet<UserInfosEntity> UserInfosEntities => Set<UserInfosEntity>();
        public DbSet<KeyDataEntity> KeyDataEntities => Set<KeyDataEntity>();
        public DbSet<UserActivityEntity> UserActivityEntity => Set<UserActivityEntity>();
        public DbSet<ActivitySessionEntity> ActivitySessionEntity => Set<ActivitySessionEntity>();
        public DbSet<UserAverageSessionsEntity> UserAverageSessionsEntity => Set<UserAverageSessionsEntity>();
        public DbSet<UserPerformanceEntity> UserPerformanceEntity => Set<UserPerformanceEntity>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                options.UseSqlite($"Data Source={Path.Join(path, "sportsee.db")}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.Seed(modelBuilder);
        }

    }
}
