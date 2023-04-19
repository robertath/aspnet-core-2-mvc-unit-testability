using Testability.DataAccess;
using Testability.Presidents.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testability.Presidents.Api.Models
{
    public abstract class Int32Identity : IInt32Identity
    {
        public int Id { get; set; }
    }
}
