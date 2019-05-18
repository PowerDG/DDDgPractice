using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace PowerDg.ERM.Authorization
{
    public class ERMAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            #region MyRegion


            var pages = context.GetPermissionOrNull(PermissionNames.Pages);

            if (pages == null)
                pages = context.CreatePermission(PermissionNames.Pages, L(PermissionNames.Pages));

            var Pages_Bill = pages.CreateChildPermission(PermissionNames.Pages_Bill, L(PermissionNames.Pages_Bill));

            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditShipper, L(PermissionNames.Pages_BillEditShipper));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckShipper, L(PermissionNames.Pages_BillCheckShipper));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditReceiver, L(PermissionNames.Pages_BillEditReceiver));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckReceiver, L(PermissionNames.Pages_BillCheckReceiver));

            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditGood, L(PermissionNames.Pages_BillEditGood));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckGood, L(PermissionNames.Pages_BillCheckGood));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditCost, L(PermissionNames.Pages_BillEditCost));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckCost, L(PermissionNames.Pages_BillCheckCost));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditCharge, L(PermissionNames.Pages_BillEditCharge));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckCharge, L(PermissionNames.Pages_BillCheckCharge));

            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillEditOther, L(PermissionNames.Pages_BillEditOther));
            Pages_Bill.CreateChildPermission(PermissionNames.Pages_BillCheckOther, L(PermissionNames.Pages_BillCheckOther));




            var Pages_Staff = pages.CreateChildPermission(PermissionNames.Pages_Staff, L(PermissionNames.Pages_Staff));

            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Merchandiser, L(PermissionNames.Pages_Staff_Merchandiser));
            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Customer_service, L(PermissionNames.Pages_Staff_Customer_service));
            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Financial, L(PermissionNames.Pages_Staff_Financial));



            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Owner, L(PermissionNames.Pages_Staff_Owner));

            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Others, L(PermissionNames.Pages_Staff_Others));


            //Inspection

            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Inspection, L(PermissionNames.Pages_Inspection));


            var Pages_Admin = Pages_Staff.CreateChildPermission(PermissionNames.Pages_Admin, L(PermissionNames.Pages_Admin));
            Pages_Admin.CreateChildPermission(PermissionNames.Pages_Admin_Users, L(PermissionNames.Pages_Admin_Users));
            Pages_Admin.CreateChildPermission(PermissionNames.Pages_Admin_Roles, L(PermissionNames.Pages_Admin_Roles));

            var RQAssitant = Pages_Staff.CreateChildPermission(PermissionNames.Pages_RQAssitant, L(PermissionNames.Pages_RQAssitant));
            RQAssitant.CreateChildPermission(PermissionNames.Pages_RQAssitant_Users, L(PermissionNames.Pages_RQAssitant_Users));
            RQAssitant.CreateChildPermission(PermissionNames.Pages_RQAssitant_Roles, L(PermissionNames.Pages_RQAssitant_Roles));

            var tasks = pages.CreateChildPermission(PermissionNames.Pages_Tasks, L(PermissionNames.Pages_Tasks));
            tasks.CreateChildPermission(PermissionNames.Pages_Tasks_AssignPerson, L(PermissionNames.Pages_Tasks_AssignPerson));
            tasks.CreateChildPermission(PermissionNames.Pages_Tasks_Delete, L(PermissionNames.Pages_Tasks_Delete));
            //tasks.CreateChildPermission(PermissionNames.Pages_Tasks_Delete, L("DeleteTask"));


            #endregion

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ERMConsts.LocalizationSourceName);
        }
    }
}
