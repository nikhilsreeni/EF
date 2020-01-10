namespace EF.Migrations
{
    using EF.Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolContext context)
        {
            context.Gender.AddOrUpdate(
                g => g.Name,
                new Gender
                {
                    Name = "Male"
                },
                new Gender
                {
                    Name = "Female"
                },
                new Gender
                {
                    Name = "Other"
                }
                ,
                new Gender
                {
                    Name = "Prefer not to say"
                });
            context.User.AddOrUpdate(
                g => g.Name,
                new User
                {
                    Name = "Nikhil",
                    GenderId= 1
                });
            context.SaveChanges();
        }
    }
}
