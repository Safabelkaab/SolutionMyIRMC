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
    class evaluationTendersMap : EntityTypeConfiguration<EvaluationTender>
    {
        public evaluationTendersMap()
        {

            // Primary Key
            this.HasKey(t => t.IdEvalTender);
            // Properties
            this.Property(t => t.IdEvalTender)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("EvaluationTender", "SolutionMyIRMC.MVC");
            this.Property(t => t.IdEvalTender).HasColumnName("IdEvalTender");
            this.Property(t => t.idTenderF).HasColumnName("idTender_fk");

        }
    }
}
