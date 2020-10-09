using Microsoft.EntityFrameworkCore;
using ToeicOnline.Configurations;
using ToeicOnline.Models;
using ToeicOnline_ASP.NET.Data.Extensions;

namespace ToeicOnline.Data
{
    public class ToeicOnlineContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public ToeicOnlineContext (DbContextOptions<ToeicOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}