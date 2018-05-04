using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class indexdocument
    {
        public int IdIndex { get; set; }
        public int DebutPage { get; set; }
        public int FinPage { get; set; }
        public string Nom { get; set; }
        public string Path { get; set; }
        public int ordre { get; set; }
        public string theme { get; set; }
        public Nullable<int> document_idDocument { get; set; }
        public virtual document document { get; set; }
    }
}
