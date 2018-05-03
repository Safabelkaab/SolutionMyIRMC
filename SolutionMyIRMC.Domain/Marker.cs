using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SolutionMyIRMC.Domain
{
    public class Marker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double lng { get; set; }
        public double lat { get; set; }
        public String type { get; set; }
    }
}
