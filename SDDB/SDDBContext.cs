using Microsoft.EntityFrameworkCore;
using SDDB.Models;

namespace SDDB
{
    public class SDDBContext : DbContext
    {
        public SDDBContext(DbContextOptions<SDDBContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<LogEntry> Logs { get; set; }
    }
}