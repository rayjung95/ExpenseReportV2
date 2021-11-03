using Volo.Abp.Modularity;

namespace ExpenseReportV2
{
    [DependsOn(
        typeof(ExpenseReportV2ApplicationModule),
        typeof(ExpenseReportV2DomainTestModule)
        )]
    public class ExpenseReportV2ApplicationTestModule : AbpModule
    {

    }
}