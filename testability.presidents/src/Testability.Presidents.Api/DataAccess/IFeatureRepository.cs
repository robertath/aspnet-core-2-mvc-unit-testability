using Testability.DataAccess;
using Testability.Presidents.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testability.Presidents.Api.DataAccess
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        IList<Feature> GetByUsername(string username);
    }
}
