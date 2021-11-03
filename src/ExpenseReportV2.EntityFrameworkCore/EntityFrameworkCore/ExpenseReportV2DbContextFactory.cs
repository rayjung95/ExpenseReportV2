using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ExpenseReportV2.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ExpenseReportV2DbContextFactory : IDesignTimeDbContextFactory<ExpenseReportV2DbContext>
    {
        public ExpenseReportV2DbContext CreateDbContext(string[] args)
        {
            ExpenseReportV2EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ExpenseReportV2DbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ExpenseReportV2DbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ExpenseReportV2.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
