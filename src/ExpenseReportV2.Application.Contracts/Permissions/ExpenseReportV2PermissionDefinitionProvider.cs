using ExpenseReportV2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ExpenseReportV2.Permissions
{
    public class ExpenseReportV2PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ExpenseReportV2Permissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ExpenseReportV2Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ExpenseReportV2Resource>(name);
        }
    }
}
