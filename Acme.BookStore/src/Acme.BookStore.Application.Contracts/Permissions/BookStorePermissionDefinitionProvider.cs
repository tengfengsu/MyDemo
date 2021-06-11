using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStorePermissions.GroupName, L("BookStore"));

            myGroup.AddPermission(
                "BookStore_Author_Create",
                L("Permission:BookStore_Author_Create"),
                multiTenancySide: MultiTenancySides.Tenant //set multi-tenancy side!
            );

            var authorManagement = myGroup.AddPermission("Author_Management");
            authorManagement.AddChild("Author_Management_Create_Books");
            authorManagement.AddChild("Author_Management_Edit_Books");
            authorManagement.AddChild("Author_Management_Delete_Books");

            context
                .GetPermissionOrNull(IdentityPermissions.Roles.Delete)
                .IsEnabled = false;
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}
