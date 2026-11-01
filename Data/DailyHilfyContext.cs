using DailyHilfy.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyHilfy.Data
{
    public class DailyHilfyContext : DbContext
    {
        public DailyHilfyContext(DbContextOptions<DailyHilfyContext> options) : base(options)
        {

        }

        public DbSet<DailyEntry> DailyEntries => Set<DailyEntry>();
    }
}
