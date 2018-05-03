using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionMyIRMC.Domain
{
    public class Event
    {
        public Event() { }
        public Event(int idEvent, string titreEvent, string descriptionEvent, string lieuxEvent, string image)
        {
            this.idEvent = idEvent;
            this.titreEvent = titreEvent;
            this.descriptionEvent = descriptionEvent;
            this.lieuxEvent = lieuxEvent;
            this.image = image;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idEvent { get; set; }
        public string titreEvent { get; set; }
        public string descriptionEvent { get; set; }
        public string lieuxEvent { get; set; }
        public Category category { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public string contactEvent { get; set; }
        public string telEvent { get; set; }
        public string image { get; set; }
        public Marker marker { get; set; }
        public string commentaireEvent { get; set; }
        public Boolean validation { get; set; }

        public User user { get; set; }
        public ICollection<EvaluationEvent> EvalEvent { get; set; }
    }
}
