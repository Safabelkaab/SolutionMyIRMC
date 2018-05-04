using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class competitionMap : EntityTypeConfiguration<competition>
    {
        public competitionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.center_name)
                .HasMaxLength(255);

            this.Property(t => t.code_post)
                .HasMaxLength(255);

            this.Property(t => t.date)
                .HasMaxLength(255);

            this.Property(t => t.image)
                .HasMaxLength(255);

            this.Property(t => t.lieu)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.prix)
                .HasMaxLength(255);

            this.Property(t => t.titre)
                .HasMaxLength(255);

            this.Property(t => t.ville)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("competition", "myirmcdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.center_name).HasColumnName("center_name");
            this.Property(t => t.code_post).HasColumnName("code_post");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.lieu).HasColumnName("lieu");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prix).HasColumnName("prix");
            this.Property(t => t.titre).HasColumnName("titre");
            this.Property(t => t.ville).HasColumnName("ville");
        }
    }
}
