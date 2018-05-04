using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class stage
    {
        public stage()
        {
            this.listDocs = new List<document>();
        }

        public int IdStage { get; set; }
        public string Competence { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateDebut { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateFin { get; set; }
        public string ImageLieu { get; set; }
        public Nullable<bool> Remuneration { get; set; }
        public Nullable<float> Salaire { get; set; }
        public string Titre { get; set; }
        public string lieu { get; set; }
        public virtual ICollection<document> listDocs { get; set; }
    }
}
