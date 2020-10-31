using DailyDev.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;

namespace DailyDev.Domain.Data
{
    public class DailyDevDbContext : DbContext
    {
        public DbSet<SiteModel> SiteModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "DailyDevDb.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
