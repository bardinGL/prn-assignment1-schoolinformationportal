using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Application
    {
        public string AdminId { get; set; }
        public string StudentId { get; set; }
        public string ApplicationId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ApproveDate { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Student Student { get; set; }
    }
}
