using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutionMyIRMC.Domain
{
    public class EvaluationEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idEvalEvent { get; set; }
        public String nomEvent { get; set; }
        public int nbPartcipant { get; set; }
        public String valeurGlobale { get; set; }
        public String serviceGlobal { get; set; }
        public String instalaltionGlobale { get; set; }
        public String recommandation { get; set; }
        [ForeignKey("events")]
        public Nullable<int> idEventF { get; set; }
        public Event events { get; set; }

    }
}
