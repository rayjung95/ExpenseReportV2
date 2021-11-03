using ExpenseReportV2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ExpenseReportV2
{
    [DependsOn(
        typeof(ExpenseReportV2EntityFrameworkCoreTestModule)
        )]
    public class ExpenseReportV2DomainTestModule : AbpModule
    {

    }
}