using System;
using System.Linq;
using Testability.Presidents.Api.Services;
using System.Collections.Generic;
using Testability.Presidents.Api.Models;

namespace Testability.Presidents.UnitTests.Services
{
    public class MockPresidentValidatorStrategy : IValidatorStrategy<President>
    {
        public MockPresidentValidatorStrategy()
        {
            IsValidReturnValue = true;
        }

        public bool IsValidReturnValue { get; set; }

        public bool IsValid(President validateThis)
        {
            return IsValidReturnValue;
        }
    }
}
