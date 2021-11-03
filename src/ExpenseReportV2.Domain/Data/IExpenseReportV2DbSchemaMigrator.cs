using System.Threading.Tasks;

namespace ExpenseReportV2.Data
{
    public interface IExpenseReportV2DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
