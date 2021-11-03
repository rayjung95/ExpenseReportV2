using ExpenseReportV2.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ExpenseReportV2.Blazor
{
    public abstract class ExpenseReportV2ComponentBase : AbpComponentBase
    {
        protected ExpenseReportV2ComponentBase()
        {
            LocalizationResource = typeof(ExpenseReportV2Resource);
        }
    }
}
