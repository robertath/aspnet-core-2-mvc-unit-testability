using System.Security.Claims;
using System.Threading.Tasks;
using Testability.Presidents.WebUi;
using Testability.Presidents.WebUi.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.Presidents.UnitTests.Security
{
    [TestClass]
    public class EditPresidentHandlerFixture
    {
        [TestMethod]
        public async Task HandlerSucceedsWhenUserIsAuthorizedToEdit_DirectPermissions()
        {
            var tester = new AuthorizationHandlerTester<
                EditPresidentRequirement, EditPresidentHandler>(
                    new EditPresidentRequirement(),
                    new EditPresidentHandler());

            tester.AddRouteDataValue("id", 123);
            tester.AddClaim(SecurityConstants.PermissionName_Edit, "123");

            await tester.AssertSuccess();
        }

        [TestMethod]
        public async Task HandlerSucceedsWhenUserIsAuthorizedToEdit_Administrator()
        {
            var tester = new AuthorizationHandlerTester<
                EditPresidentRequirement, EditPresidentHandler>(
                    new EditPresidentRequirement(),
                    new EditPresidentHandler());

            tester.AddRouteDataValue("id", 123);
            tester.AddClaim(ClaimTypes.Role, SecurityConstants.RoleName_Admin);

            await tester.AssertSuccess();
        }

        [TestMethod]
        public async Task HandlerFailsWhenUserIsNotAuthorizedToEdit()
        {
            var tester = new AuthorizationHandlerTester<
                EditPresidentRequirement, EditPresidentHandler>(
                    new EditPresidentRequirement(),
                    new EditPresidentHandler());

            tester.AddRouteDataValue("id", 123);
            // tester.AddClaim(SecurityConstants.PermissionName_Edit, "123");

            await tester.AssertFailure();
        }


    }
}