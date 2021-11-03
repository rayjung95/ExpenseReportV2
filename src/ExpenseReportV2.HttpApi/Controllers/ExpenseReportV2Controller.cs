using ExpenseReportV2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ExpenseReportV2.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ExpenseReportV2Controller : AbpController
    {
        protected ExpenseReportV2Controller()
        {
            LocalizationResource = typeof(ExpenseReportV2Resource);
        }
    }
}