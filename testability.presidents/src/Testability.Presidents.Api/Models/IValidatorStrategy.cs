using System;
using System.Collections.Generic;
using System.Text;

namespace Testability.Presidents.Api.Models
{
    public interface IValidatorStrategy<T>
    {
        bool IsValid(T validateThis);
    }
}
