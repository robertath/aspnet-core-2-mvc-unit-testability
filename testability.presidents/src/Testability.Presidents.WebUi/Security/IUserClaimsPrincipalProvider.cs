using System.Security.Claims;

namespace Testability.Presidents.WebUi.Security
{
    public interface IUserClaimsPrincipalProvider
    {
        ClaimsPrincipal GetUser();
    }
}