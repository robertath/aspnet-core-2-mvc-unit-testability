using Testability.Presidents.Common;
using Testability.Presidents.Api.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testability.Presidents.Api.Services
{
    public interface ILogger
    {
        void LogFeatureUsage(string featureName);
        void LogCustomerSatisfaction(string feedback);
    }
}
