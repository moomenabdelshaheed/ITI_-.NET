using Microsoft.EntityFrameworkCore;

namespace WebApi_Day01.Model
{
    public class ITIcontext : DbContext

    {
        public DbSet<Course> Courses { get; set; }
        public ITIcontext() : base()
        { }
        public ITIcontext(DbContextOptions<ITIcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Crs_name = "C# Basics", Crs_desc = "Intro to C#", Duration = 30 },
                new Course { Id = 2, Crs_name = "ASP.NET Core", Crs_desc = "Build Web APIs", Duration = 40 },
                new Course { Id = 3, Crs_name = "EF Core", Crs_desc = "Data access", Duration = 25 },
                new Course { Id = 4, Crs_name = "SQL Server", Crs_desc = "Query databases", Duration = 35 }
            );
        }
    }
}
