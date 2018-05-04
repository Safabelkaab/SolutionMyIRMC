using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class indexdocumentMap : EntityTypeConfiguration<indexdocument>
    {
        public indexdocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.IdIndex);

            // Properties
            this.Property(t => t.Nom)
                .HasMaxLength(255);

            this.Property(t => t.Path)
                .HasMaxLength(255);

            this.Property(t => t.theme)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("indexdocument", "myspdb");
            this.Property(t => t.IdIndex).HasColumnName("IdIndex");
            this.Property(t => t.DebutPage).HasColumnName("DebutPage");
            this.Property(t => t.FinPage).HasColumnName("FinPage");
            this.Property(t => t.Nom).HasColumnName("Nom");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.ordre).HasColumnName("ordre");
            this.Property(t => t.theme).HasColumnName("theme");
            this.Property(t => t.document_idDocument).HasColumnName("document_idDocument");

            // Relationships
            this.HasOptional(t => t.document)
                .WithMany(t => t.indexdocuments)
                .HasForeignKey(d => d.document_idDocument);

        }
    }
}
