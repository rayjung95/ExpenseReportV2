using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ExpenseReportV2.Data
{
    /* This is used if database provider does't define
     * IExpenseReportV2DbSchemaMigrator implementation.
     */
    public class NullExpenseReportV2DbSchemaMigrator : IExpenseReportV2DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}