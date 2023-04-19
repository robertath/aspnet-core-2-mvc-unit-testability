using System.Collections.Generic;

namespace Testability.Presidents.Api.Models
{
    public interface IDaysInOfficeStrategy
    {
         int GetDaysInOffice(IEnumerable<Term> terms);
    }
}