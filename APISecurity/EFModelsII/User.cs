using System;
using System.Collections.Generic;

namespace APISecurity.EFModelsII
{
    public partial class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}
