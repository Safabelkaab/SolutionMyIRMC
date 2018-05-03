using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SolutionMyIRMC.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionMyIRMC.Data.Models.Mapping
{
    class topicEventMap : EntityTypeConfiguration<TopicEvent>
    {
        public topicEventMap()
        {
            // Primary Key
            this.HasKey(t => t.idTopic);
            // Properties
      

            // Table & Column Mappings
            this.ToTable("TopicEvent", "SolutionMyIRMC.MVC");
            this.Property(t => t.idTopic).HasColumnName("idTopic");
            this.Property(t => t.textTopic).HasColumnName("textTopic");
            this.Property(t => t.idEventF).HasColumnName("idEvent_fk");

        }
    }
}
