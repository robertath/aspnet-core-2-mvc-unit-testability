using System;
using System.Linq;

namespace Testability.Presidents.Api.Services
{
    public interface ISubscriptionService
    {
        void AddSubscription(string username, string subscriptionType);
        void RemoveSubscription(string username);
        string GetSubscriptionType(string username);
    }
}
