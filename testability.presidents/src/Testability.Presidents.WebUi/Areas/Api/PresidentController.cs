using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testability.Presidents.Api.Models;
using Testability.Presidents.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Testability.Presidents.WebUi.Areas.Api
{
    [Route("api/[controller]")]
    public class PresidentController : ControllerBase
    {
        private IPresidentService _Service;

        public PresidentController(IPresidentService service)
        {
            _Service = service;
        }

        // GET: api/President
        [HttpGet]
        public IEnumerable<President> Get()
        {
            return _Service.GetPresidents();
        }

        // GET: api/President/5
        [HttpGet("{id}", Name = "Get")]
        public President Get(int id)
        {
            return _Service.GetPresidentById(id);
        }
    }
}
