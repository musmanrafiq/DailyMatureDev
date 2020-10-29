using DailyDev.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DailyDev.Domain.Data
{
    public class DailyDevDbContext : DbContext
    {
        public DbSet<SiteModel> SiteModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=G:\dot net\DailyMatureDev\src\DailyDevDb.db;", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
