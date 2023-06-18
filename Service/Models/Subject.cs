using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Subject
    {
        public string ClassId { get; set; }
        public string SubjectId { get; set; }
        public string Description { get; set; }

        public virtual Class Class { get; set; }
    }
}
