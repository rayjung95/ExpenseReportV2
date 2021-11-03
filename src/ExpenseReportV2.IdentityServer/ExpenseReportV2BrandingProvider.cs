using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ExpenseReportV2
{
    [Dependency(ReplaceServices = true)]
    public class ExpenseReportV2BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ExpenseReportV2";
    }
}
