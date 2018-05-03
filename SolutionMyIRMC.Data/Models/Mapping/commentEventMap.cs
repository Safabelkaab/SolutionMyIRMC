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
    class commentEventMap : EntityTypeConfiguration<CommentEvent>
    {
        public commentEventMap()
        {

            // Primary Key
            this.HasKey(t => t.idComment);
            // Properties
            this.Property(t => t.idComment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("CommentEvent", "SolutionMyIRMC.MVC");
            this.Property(t => t.idComment).HasColumnName("idComment");
            this.Property(t => t.textComment).HasColumnName("textComment");
            this.Property(t => t.idTopicF).HasColumnName("idTopic_fk");
        }

    }
}
