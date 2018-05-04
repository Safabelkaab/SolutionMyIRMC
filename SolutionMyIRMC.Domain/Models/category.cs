using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class category
    {
        public category()
        {
            this.evens = new List<even>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<even> evens { get; set; }
    }
}
