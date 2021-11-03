using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExpenseReportV2.Data;
using Volo.Abp.DependencyInjection;

namespace ExpenseReportV2.EntityFrameworkCore
{
    public class EntityFrameworkCoreExpenseReportV2DbSchemaMigrator
        : IExpenseReportV2DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreExpenseReportV2DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ExpenseReportV2DbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ExpenseReportV2DbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
