using Microsoft.EntityFrameworkCore;

namespace SDDB
{
    public class SDDBContext : DbContext
    {
        public SDDBContext(DbContextOptions<SDDBContext> options) : base(options)
        {
        }
    }
}