using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class documentMap : EntityTypeConfiguration<document>
    {
        public documentMap()
        {
            // Primary Key
            this.HasKey(t => t.idDocument);

            // Properties
            this.Property(t => t.image)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.path)
                .HasMaxLength(255);

            this.Property(t => t.pathImage)
                .HasMaxLength(255);

            this.Property(t => t.titre)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("document", "myspdb");
            this.Property(t => t.idDocument).HasColumnName("idDocument");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.nombreindex).HasColumnName("nombreindex");
            this.Property(t => t.path).HasColumnName("path");
            this.Property(t => t.pathImage).HasColumnName("pathImage");
            this.Property(t => t.titre).HasColumnName("titre");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.stage_IdStage).HasColumnName("stage_IdStage");
            this.Property(t => t.users_idUser).HasColumnName("users_idUser");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.documents)
                .HasForeignKey(d => d.users_idUser);
            this.HasOptional(t => t.stage)
                .WithMany(t => t.listDocs)
                .HasForeignKey(d => d.stage_IdStage);

        }
    }
}
