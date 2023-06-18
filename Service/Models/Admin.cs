using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Applications = new HashSet<Application>();
        }

        public string AdminId { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
