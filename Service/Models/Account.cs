using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Account
    {
        public Account()
        {
            Students = new HashSet<Student>();
        }

        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
