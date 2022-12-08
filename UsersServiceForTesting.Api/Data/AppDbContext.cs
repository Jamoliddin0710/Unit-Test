using Microsoft.EntityFrameworkCore;

namespace UsersServiceForTesting.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=ds");
        }
    }

    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
