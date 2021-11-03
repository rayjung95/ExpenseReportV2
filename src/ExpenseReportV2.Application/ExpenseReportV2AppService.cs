using System;
using System.Collections.Generic;
using System.Text;
using ExpenseReportV2.Localization;
using Volo.Abp.Application.Services;

namespace ExpenseReportV2
{
    /* Inherit your application services from this class.
     */
    public abstract class ExpenseReportV2AppService : ApplicationService
    {
        protected ExpenseReportV2AppService()
        {
            LocalizationResource = typeof(ExpenseReportV2Resource);
        }
    }
}
