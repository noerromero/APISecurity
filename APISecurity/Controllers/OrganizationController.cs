using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISecurity.Controllers
{
    [Route("api/organizations")]
    public class OrganizationController: Controller
    {
        [HttpGet()]
        public JsonResult GetOrganization() {
            return new JsonResult(new List<object>()
            {
                new { OrganizationId = 1, Name = "Organizacion1"},
                new { OrganizationId = 1, Name = "Organizacion2"}
            });
        }
    }
}
