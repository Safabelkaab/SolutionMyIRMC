using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace SolutionMyIRMC.Domain
{
    [Table("Tender")]
    public class Tender
    {
        public Tender() { }
        public Tender(int idTender, string titleTender, string description, string contact, string sourceInformation, Category category, Marker marker)
        {
            this.idTender = idTender;
            this.titleTender = titleTender;
            this.description = description;
            this.contact = contact;
            this.sourceInformation = sourceInformation;
            this.category = category;
            this.marker = marker;
        }
        public Tender(int idTender, string titleTender, string description, string contact, string sourceInformation)
        {
            this.idTender = idTender;
            this.titleTender = titleTender;
            this.description = description;
            this.contact = contact;
            this.sourceInformation = sourceInformation;

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idTender { get; set; }
        public string titleTender { get; set; }
        public string description { get; set; }
        public ICollection<EvaluationTender> Evaluatenders { get; set; }
        public string contact { get; set; }
        public string sourceInformation { get; set; }
        public Category category { get; set; }
        public Marker marker { get; set; }
    }
}
