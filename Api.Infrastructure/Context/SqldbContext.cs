using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.SQL.Context
{
    public class SqldbContext : DbContext
    {
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public SqldbContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        public DbSet<Car.Data.Entities.Car> Cars { get; set; }
        public DbSet<Booking.Data.Entities.Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: "Portal");
        }
    }
}
