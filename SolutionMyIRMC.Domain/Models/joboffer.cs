using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class joboffer
    {
        public int idJob { get; set; }
        public string DescripPoste { get; set; }
        public string Intitule_Poste { get; set; }
        public string Mission { get; set; }
        public string NomEntrep { get; set; }
        public string Numtelf { get; set; }
        public string Profil_candidat { get; set; }
        public string Sect_Activite { get; set; }
        public string Type_contrat { get; set; }
        public string adresse { get; set; }
        public string mail { get; set; }
    }
}
