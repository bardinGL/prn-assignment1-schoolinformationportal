using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
            Subjects = new HashSet<Subject>();
        }

        public string ClassId { get; set; }
        public string MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
