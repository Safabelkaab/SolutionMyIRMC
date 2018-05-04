using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutionMyIRMC.Domain
{
    [Table("CommentEvent")]
    public class CommentEvent
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idComment { get; set; }
        public string textComment { get; set; }
        public Boolean isliked { get; set; }
        [ForeignKey("topicEvens")]
        public Nullable<int> idTopicF { get; set; }

        public TopicEvent topicEvens { get; set; }

        [ForeignKey("users")]
        public Nullable<int> idUserF { get; set; }

        public User users { get; set; }

    }
}
