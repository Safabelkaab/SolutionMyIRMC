using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class stageMap : EntityTypeConfiguration<stage>
    {
        public stageMap()
        {
            // Primary Key
            this.HasKey(t => t.IdStage);

            // Properties
            this.Property(t => t.Competence)
                .HasMaxLength(255);

            this.Property(t => t.ImageLieu)
                .HasMaxLength(255);

            this.Property(t => t.Titre)
                .HasMaxLength(255);

            this.Property(t => t.lieu)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("stage", "myspdb");
            this.Property(t => t.IdStage).HasColumnName("IdStage");
            this.Property(t => t.Competence).HasColumnName("Competence");
            this.Property(t => t.DateDebut).HasColumnName("DateDebut");
            this.Property(t => t.DateFin).HasColumnName("DateFin");
            this.Property(t => t.ImageLieu).HasColumnName("ImageLieu");
            this.Property(t => t.Remuneration).HasColumnName("Remuneration");
            this.Property(t => t.Salaire).HasColumnName("Salaire");
            this.Property(t => t.Titre).HasColumnName("Titre");
            this.Property(t => t.lieu).HasColumnName("lieu");
        }
    }
}
