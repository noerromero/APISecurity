using APISecurity.Models;
using APISecurity.Services;
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

        private IOrganizationRepository _organizationRepository;

        public OrganizationController(IOrganizationRepository organizationRepository) {
            _organizationRepository = organizationRepository;

        }


        [HttpGet()]
        public JsonResult GetOrganization() {
            var organizations = _organizationRepository
                .GetOrganizations();

            var results = new List<OrganizationDTO>();
            foreach (var orga in organizations)
            {
                results.Add(new OrganizationDTO()
                {
                    Id= orga.Id,
                    Name = orga.Name
                });
            }

            return new JsonResult(results);
        }
    }
}
