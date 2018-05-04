using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class evenMap : EntityTypeConfiguration<even>
    {
        public evenMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEvent);

            // Properties
            this.Property(t => t.CommentaireEvent)
                .HasMaxLength(255);

            this.Property(t => t.ContactEvent)
                .HasMaxLength(255);

            this.Property(t => t.DescriptionEvent)
                .HasMaxLength(255);

            this.Property(t => t.LieuxEvent)
                .HasMaxLength(255);

            this.Property(t => t.TitreEvent)
                .HasMaxLength(255);

            this.Property(t => t.telEvent)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("even", "myspdb");
            this.Property(t => t.IdEvent).HasColumnName("IdEvent");
            this.Property(t => t.CommentaireEvent).HasColumnName("CommentaireEvent");
            this.Property(t => t.ContactEvent).HasColumnName("ContactEvent");
            this.Property(t => t.date_event).HasColumnName("date_event");
            this.Property(t => t.DescriptionEvent).HasColumnName("DescriptionEvent");
            this.Property(t => t.LieuxEvent).HasColumnName("LieuxEvent");
            this.Property(t => t.TitreEvent).HasColumnName("TitreEvent");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.telEvent).HasColumnName("telEvent");
            this.Property(t => t.validation).HasColumnName("validation");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.user_idUser).HasColumnName("user_idUser");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.evens)
                .HasForeignKey(d => d.category_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.evens)
                .HasForeignKey(d => d.user_idUser);

        }
    }
}
