using APISecurity.EFModelsII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISecurity.Services
{
    public interface IOrganizationRepository
    {
        IEnumerable<Organization> GetOrganizations();
    }
}
