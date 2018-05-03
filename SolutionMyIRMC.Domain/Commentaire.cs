using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SolutionMyIRMC.Domain
{
    [Table("commentaire")]
    public class Commentaire
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idComment { get; set; }
        public string textComment { get; set; }
        public Tender tender { get; set; }
        public User user { get; set; }
    }
}
