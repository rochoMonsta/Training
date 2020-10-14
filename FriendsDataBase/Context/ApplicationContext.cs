using FriendsDataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendsDataBase.Context
{
    class ApplicationContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FriendsDB;Trusted_Connection=True;");
        }
    }
}
