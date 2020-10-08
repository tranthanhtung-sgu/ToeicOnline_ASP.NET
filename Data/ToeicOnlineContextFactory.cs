using Microsoft.EntityFrameworkCore;
using ToeicOnline.Data;

namespace Data
{
    public class ToeicOnlineContextFactory
    {
        public ToeicOnlineContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ToeicOnlineContext>();
            optionsBuilder.UseSqlite("Data Source=MvcToeic.db");

            return new ToeicOnlineContext(optionsBuilder.Options);
        }
    }
}