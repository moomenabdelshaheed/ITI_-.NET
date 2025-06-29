using System.Data;
using Microsoft.EntityFrameworkCore;

namespace MVCEFLAB2Day02.Models
{
    public class ITIcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<crsResult> CrsResult { get; set; }
        public ITIcontext() : base() 
        { }
        public ITIcontext(DbContextOptions<ITIcontext> options) : base( options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MOOMEN\\SQLEXPRESS;Initial Catalog=M3M;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Course)
                .WithMany(i=>i.Instructors)
                .HasForeignKey(i => i.CourseID)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<crsResult>().HasOne(c => c.Course).WithMany(c => c.CrsResult).HasForeignKey(c => c.crs_ID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }

    }
