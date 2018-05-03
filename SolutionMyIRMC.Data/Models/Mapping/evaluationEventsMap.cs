using SolutionMyIRMC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionMyIRMC.Data.Models.Mapping
{
    class evaluationEventsMap : EntityTypeConfiguration<EvaluationEvent>
    {
        public evaluationEventsMap()
        {
            // Primary Key
            this.HasKey(t => t.idEvalEvent);
            // Properties
            this.Property(t => t.idEvalEvent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("EvaluationEvent", "SolutionMyIRMC.MVC");
            this.Property(t => t.idEvalEvent).HasColumnName("idEvalEvent");
            this.Property(t => t.instalaltionGlobale).HasColumnName("instalaltionGlobale");
            this.Property(t => t.nbPartcipant).HasColumnName("nbPartcipant");
            this.Property(t => t.nomEvent).HasColumnName("nomEvent");
            this.Property(t => t.recommandation).HasColumnName("recommandation");
            this.Property(t => t.serviceGlobal).HasColumnName("serviceGlobal");
            this.Property(t => t.idEventF).HasColumnName("idEvent_fk");





        }
    }
}
