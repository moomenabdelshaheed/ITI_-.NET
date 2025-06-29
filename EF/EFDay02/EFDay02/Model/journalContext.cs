using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFDay02.Model
{
    internal class journalContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=MOOMEN\\SQLEXPRESS;Initial Catalog=journal;Integrated Security=True;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer("Data Source=MOOMEN\\SQLEXPRESS;Initial Catalog=journal_v3;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //       modelBuilder.Entity<News>().HasData(
            //    new News { Id = 1, Title = "Champions League Final", bref = "Soccer Final", Description = "Manchester City wins the final.", DateTime = new DateTime(2025, 5, 1), CatId = 1, AuthorId = 1 },
            //    new News { Id = 2, Title = "Elections 2025", bref = "Presidential Race", Description = "Upcoming elections draw attention.", DateTime = new DateTime(2025, 4, 30), CatId = 2, AuthorId = 2 },
            //    new News { Id = 3, Title = "iPhone 16 Release", bref = "Apple Launch", Description = "Apple unveils new iPhone.", DateTime = new DateTime(2025, 4, 29), CatId = 3, AuthorId = 3 },
            //    new News { Id = 4, Title = "AI in Healthcare", bref = "Medical Tech", Description = "AI revolutionizing diagnosis.", DateTime = new DateTime(2025, 4, 28), CatId = 4, AuthorId = 4 },
            //    new News { Id = 5, Title = "Oscars 2025", bref = "Award Ceremony", Description = "Big wins at the Oscars.", DateTime = new DateTime(2025, 4, 27), CatId = 5, AuthorId = 1 },
            //    new News { Id = 6, Title = "NBA Finals", bref = "Basketball", Description = "Lakers vs Celtics showdown.", DateTime = new DateTime(2025, 4, 26), CatId = 1, AuthorId = 2 },
            //    new News { Id = 7, Title = "Global Warming Update", bref = "Climate", Description = "New data on global temperatures.", DateTime = new DateTime(2025, 4, 25), CatId = 4, AuthorId = 3 },
            //    new News { Id = 8, Title = "Cybersecurity Trends", bref = "InfoSec", Description = "Top threats in 2025.", DateTime = new DateTime(2025, 4, 24), CatId = 3, AuthorId = 4 },
            //    new News { Id = 9, Title = "New Streaming Platform", bref = "Tech & Media", Description = "A new rival to Netflix appears.", DateTime = new DateTime(2025, 4, 23), CatId = 5, AuthorId = 1 },
            //    new News { Id = 10, Title = "Election Debates", bref = "Live Debate", Description = "Candidates clash on live TV.", DateTime = new DateTime(2025, 4, 22), CatId = 2, AuthorId = 2 },
            //    new News { Id = 11, Title = "Fitness Tech 2025", bref = "Wearables", Description = "Smartwatches with health sensors.", DateTime = new DateTime(2025, 4, 21), CatId = 4, AuthorId = 3 }
            //);


            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "John Smith", email = "john.smith@example.com", password = "123456" },
                new Author { Id = 2, Name = "Emily Johnson", email = "emily.johnson@example.com", password = "pass789" },
                new Author { Id = 3, Name = "David Brown", email = "david.brown@example.com", password = "admin321" },
                new Author { Id = 4, Name = "Sophia Davis", email = "sophia.davis@example.com", password = "qwerty" }
            );
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Technology", Description = "Tech news and trends" },
            new Category { Id = 2, Name = "Health", Description = "Health and wellness articles" },
            new Category { Id = 3, Name = "Finance", Description = "Financial tips and news" },
            new Category { Id = 4, Name = "Education", Description = "Education systems and updates" }
            );
            modelBuilder.Entity<News>().HasData(
    new News
    {
        Id = 1,
        Title = "AI Breakthrough",
        bref = "New AI tech",
        Description = "Latest developments in AI and how it changes the world.",
        DateTime = new DateTime(2024, 5, 1),
        AuthorId = 1,
        CatId = 1
    },
    new News
    {
        Id = 2,
        Title = "Healthy Living",
        bref = "Wellness trends",
        Description = "Top wellness trends you need to know.",
        DateTime = new DateTime(2024, 5, 3),
        AuthorId = 2,
        CatId = 2
    },
    new News
    {
        Id = 3,
        Title = "Stock Market Insights",
        bref = "Market analysis",
        Description = "An overview of the stock market and projections.",
        DateTime = new DateTime(2024, 5, 4),
        AuthorId = 3,
        CatId = 3
    },
    new News
    {
        Id = 4,
        Title = "Education Reforms",
        bref = "System updates",
        Description = "New reforms in the education system.",
        DateTime = new DateTime(2024, 5, 5),
        AuthorId = 4,
        CatId = 4
    },
    new News
    {
        Id = 5,
        Title = "Future of Tech Jobs",
        bref = "Career advice",
        Description = "How AI and automation are impacting jobs.",
        DateTime = new DateTime(2024, 5, 6),
        AuthorId = 1,
        CatId = 1
    },
    new News
    {
        Id = 6,
        Title = "Mental Health Awareness",
        bref = "Mind matters",
        Description = "Understanding mental health in modern society.",
        DateTime = new DateTime(2024, 5, 7),
        AuthorId = 2,
        CatId = 2
    },
    new News
    {
        Id = 7,
        Title = "Crypto Investment Tips",
        bref = "Digital finance",
        Description = "How to invest safely in cryptocurrency.",
        DateTime = new DateTime(2024, 5, 8),
        AuthorId = 3,
        CatId = 3
    },
    new News
    {
        Id = 8,
        Title = "Online Learning Platforms",
        bref = "E-learning",
        Description = "Comparison between top online education platforms.",
        DateTime = new DateTime(2024, 5, 9),
        AuthorId = 4,
        CatId = 4
    }
);
            modelBuilder.Entity<News>()
             .Property(n => n.DateTime)
            .HasDefaultValueSql("GETDATE()");




        }

        public class MigrationHelper
        {
            private readonly journalContext _context;

            public MigrationHelper(journalContext context)
            {
                _context = context;
            }

            // دالة لإعادة تعيين الـ Identity (RESEED)
            public void ReseedIdentity()
            {
                // جلب أعلى قيمة ID من جدول News
                var maxId = _context.News.Max(n => (int?)n.Id) ?? 0;

                // تنفيذ عملية RESEED للـ Identity في SQL
                _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('News', RESEED, {maxId})");
            }
        }
    }
}
