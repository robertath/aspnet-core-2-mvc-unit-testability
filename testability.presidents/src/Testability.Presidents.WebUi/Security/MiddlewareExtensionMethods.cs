using Microsoft.AspNetCore.Builder;

namespace Testability.Presidents.WebUi.Security
{
    public static class MiddlewareExtensionMethods
    {
        public static IApplicationBuilder UsePopulateSubscriptionClaimsMiddleware(
                    this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PopulateSubscriptionClaimsMiddleware>();
        }
    }
}