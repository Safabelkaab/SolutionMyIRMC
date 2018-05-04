using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.prenom)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "myspdb");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.prenom).HasColumnName("prenom");
            this.Property(t => t.role).HasColumnName("role");
        }
    }
}
