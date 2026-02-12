using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClinicBookingSystem.Infrastructure.Data
{
    public class ClinicContextFactory : IDesignTimeDbContextFactory<ClinicContext>
    {
        public ClinicContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicContext>();

            optionsBuilder.UseSqlite("Data Source=clinic.db");

            return new ClinicContext(optionsBuilder.Options);
        }
    }
}
