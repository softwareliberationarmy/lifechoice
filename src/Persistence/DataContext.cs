using Domain;
using Microsoft.EntityFrameworkCore;

[assembly:CLSCompliant(false)]
namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WeighIn> WeighIns { get; set; }
    }
}
