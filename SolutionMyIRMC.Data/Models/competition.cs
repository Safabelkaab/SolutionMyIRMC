using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class competition
    {
        public long id { get; set; }
        public string center_name { get; set; }
        public string code_post { get; set; }
        public string date { get; set; }
        public string image { get; set; }
        public string lieu { get; set; }
        public string name { get; set; }
        public string prix { get; set; }
        public string titre { get; set; }
        public string ville { get; set; }
    }
}
