using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class tender
    {
        public int idTender { get; set; }
        public string category { get; set; }
        public string contact { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string sourceInformation { get; set; }
        public string titleTender { get; set; }
    }
}
