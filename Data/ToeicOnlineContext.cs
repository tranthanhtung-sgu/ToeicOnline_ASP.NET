using Microsoft.EntityFrameworkCore;
using ToeicOnline.Configurations;
using ToeicOnline.Models;

namespace ToeicOnline.Data
{
    public class ToeicOnlineContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public ToeicOnlineContext (DbContextOptions<ToeicOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}