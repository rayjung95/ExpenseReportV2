using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ExpenseReportV2.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class ExpenseReportV2BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ExpenseReportV2";
    }
}
