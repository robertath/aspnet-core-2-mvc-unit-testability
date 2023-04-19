using Testability.Presidents.Api.Interfaces;
using System;

namespace Testability.Presidents.UnitTests.Presentation
{
    public class MockFeatureManager : IFeatureManager
    {

        public bool Search { get; set; }
        public bool SearchByBirthDeathState { get; set; }
        public bool PerformanceCounters { get; set; }
        public bool FeatureUsageLogging { get; set; }
        public bool CustomerSatisfaction { get; set; }
    }
}