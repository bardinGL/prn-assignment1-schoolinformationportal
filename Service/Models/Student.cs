using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Student
    {
        public Student()
        {
            Applications = new HashSet<Application>();
        }

        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentEmail { get; set; }
        public string MajorId { get; set; }
        public string ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Major Major { get; set; }
        public virtual Account StudentEmailNavigation { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
