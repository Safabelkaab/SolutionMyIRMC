using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Domain
{
    public class TopicEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idTopic { get; set; }
        public string textTopic { get; set; }
        public string categoryTopic { get; set; }
        [ForeignKey("events")]
        public Nullable<int> idEventF { get; set; }
        public Event events { get; set; }
        public ICollection<CommentEvent> commentEvents { get; set; }
    }
}

