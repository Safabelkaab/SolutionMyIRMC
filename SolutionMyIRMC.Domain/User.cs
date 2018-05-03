using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SolutionMyIRMC.Domain
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idUser { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string role { get; set; }
        public ICollection<Event> listEvent { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
