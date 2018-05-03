using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutionMyIRMC.Domain
{
    public class EvaluationTender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdEvalTender { get; set; }
        public int nbTenderReceived { get; set; }
        public String interetTender { get; set; }
        public String prixRaisonable { get; set; }
        public int note { get; set; }
        public String recommandation { get; set; }
        [ForeignKey("tenders")]
        public Nullable<int> idTenderF { get; set; }
        public Tender tenders { get; set; }

    }
}

