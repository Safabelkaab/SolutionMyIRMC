using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutionMyIRMC.Domain
{
    public class CommentEvent
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idComment { get; set; }
        public string textComment { get; set; }
        [ForeignKey("topicEvens")]
        public Nullable<int> idTopicF { get; set; }

        public TopicEvent topicEvens { get; set; }
    }
}
