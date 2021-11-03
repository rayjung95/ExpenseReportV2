using ExpenseReportV2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ExpenseReportV2.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ExpenseReportV2EntityFrameworkCoreModule),
        typeof(ExpenseReportV2ApplicationContractsModule)
        )]
    public class ExpenseReportV2DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
