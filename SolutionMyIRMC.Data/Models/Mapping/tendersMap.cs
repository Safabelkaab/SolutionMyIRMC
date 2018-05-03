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
    class tendersMap : EntityTypeConfiguration<Tender>
    {
        public tendersMap()
        {
            // Primary Key
            this.HasKey(t => t.idTender);
            // Properties
            this.Property(t => t.idTender)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
