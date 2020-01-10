using EF.Migrations;
using EF.Models;
using System.Data.Entity;

namespace EF
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>());
        }
        public DbSet<User> User { get; set; }

        public DbSet<Gender> Gender { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GenderConfiguration());
        }
    }

}
