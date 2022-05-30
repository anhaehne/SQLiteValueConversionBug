using Microsoft.EntityFrameworkCore;
using SQLiteValueConversionBug.Models;

namespace SQLiteValueConversionBug
{
    public class TestDatabase : DbContext
    {
        public TestDatabase(DbContextOptions<TestDatabase> options)
            :base(options)
        {

        }

        public DbSet<BaseModel> BaseModels { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseModel>()
                .Property(m => m.SubModel)
                .HasJsonConversion();
        }
    }
}
