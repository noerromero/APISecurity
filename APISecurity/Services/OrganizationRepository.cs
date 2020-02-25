using APISecurity.EFModelsII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISecurity.Services
{
    public class OrganizationRepository : IOrganizationRepository
    {
        postgresContext _context;

        public OrganizationRepository()
        { 
        }

        public OrganizationRepository(postgresContext context)
        {
            this._context = context;
        }


        public IEnumerable<Organization> GetOrganizations()
        {
            return _context.Organization.OrderBy(c => c.Name).ToList();
        }
    }
}
