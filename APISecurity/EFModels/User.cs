using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISecurity.EFModels
{
    public class User
    {

        public User() { }

        public long Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }

    }
}
