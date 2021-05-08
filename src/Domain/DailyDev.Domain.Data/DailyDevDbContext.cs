using DailyDev.Domain.Data.Seeders;
using DailyDev.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;

namespace DailyDev.Domain.Data
{
    public class DailyDevDbContext : DbContext
    {
        public DbSet<SiteModel> SiteModels { get; set; }
        public DbSet<TempLink> TempLinks { get; set; }

        #region overrides

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(Assembly.GetExecutingAssembly().Location, "DailyDevDb.db");
            dbPath = dbPath.Replace(@"DailyDev.Domain.Data.dll\", "");
            optionsBuilder.UseSqlite($"Data Source={dbPath}", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogsSeeder());
        }

        #endregion
    }
}
