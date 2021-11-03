using Volo.Abp.Settings;

namespace ExpenseReportV2.Settings
{
    public class ExpenseReportV2SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ExpenseReportV2Settings.MySetting1));
        }
    }
}
