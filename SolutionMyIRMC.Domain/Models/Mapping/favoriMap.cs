using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class favoriMap : EntityTypeConfiguration<favori>
    {
        public favoriMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFavoris);

            // Properties
            // Table & Column Mappings
            this.ToTable("favoris", "myspdb");
            this.Property(t => t.IdFavoris).HasColumnName("IdFavoris");
        }
    }
}
