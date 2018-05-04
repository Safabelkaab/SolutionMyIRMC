using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class document
    {
        public document()
        {
            this.indexdocuments = new List<indexdocument>();
        }

        public int idDocument { get; set; }
        public string image { get; set; }
        public string nom { get; set; }
        public int nombreindex { get; set; }
        public string path { get; set; }
        public string pathImage { get; set; }
        public string titre { get; set; }
        public string type { get; set; }
        public Nullable<int> stage_IdStage { get; set; }
        public Nullable<int> users_idUser { get; set; }
        public virtual ICollection<indexdocument> indexdocuments { get; set; }
        public virtual user user { get; set; }
        public virtual stage stage { get; set; }
    }
}
