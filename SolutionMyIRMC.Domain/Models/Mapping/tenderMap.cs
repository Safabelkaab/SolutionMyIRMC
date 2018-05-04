using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class tenderMap : EntityTypeConfiguration<tender>
    {
        public tenderMap()
        {
            // Primary Key
            this.HasKey(t => t.idTender);

            // Properties
            this.Property(t => t.idTender)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.category)
                .HasMaxLength(255);

            this.Property(t => t.contact)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.place)
                .HasMaxLength(255);

            this.Property(t => t.sourceInformation)
                .HasMaxLength(255);

            this.Property(t => t.titleTender)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tender", "myspdb");
            this.Property(t => t.idTender).HasColumnName("idTender");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.place).HasColumnName("place");
            this.Property(t => t.sourceInformation).HasColumnName("sourceInformation");
            this.Property(t => t.titleTender).HasColumnName("titleTender");
        }
    }
}
