using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class researchcenterMap : EntityTypeConfiguration<researchcenter>
    {
        public researchcenterMap()
        {
            // Primary Key
            this.HasKey(t => t.idcent);

            // Properties
            this.Property(t => t.Tel)
                .HasMaxLength(255);

            this.Property(t => t.acces_type)
                .HasMaxLength(255);

            this.Property(t => t.adresse)
                .HasMaxLength(255);

            this.Property(t => t.catalogue)
                .HasMaxLength(255);

            this.Property(t => t.cen_lastchange_by)
                .HasMaxLength(255);

            this.Property(t => t.cen_pays)
                .HasMaxLength(255);

            this.Property(t => t.cen_type)
                .HasMaxLength(255);

            this.Property(t => t.code_post)
                .HasMaxLength(255);

            this.Property(t => t.commentaire)
                .HasMaxLength(255);

            this.Property(t => t.domaines)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.fb)
                .HasMaxLength(255);

            this.Property(t => t.horaires)
                .HasMaxLength(255);

            this.Property(t => t.img)
                .HasMaxLength(255);

            this.Property(t => t.internet_type)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.pays)
                .HasMaxLength(255);

            this.Property(t => t.pret)
                .HasMaxLength(255);

            this.Property(t => t.sigle)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            this.Property(t => t.url)
                .HasMaxLength(255);

            this.Property(t => t.ville)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("researchcenters", "myirmcdb");
            this.Property(t => t.idcent).HasColumnName("idcent");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.acces_type).HasColumnName("acces_type");
            this.Property(t => t.adresse).HasColumnName("adresse");
            this.Property(t => t.catalogue).HasColumnName("catalogue");
            this.Property(t => t.cen_lastchange_by).HasColumnName("cen_lastchange_by");
            this.Property(t => t.cen_pays).HasColumnName("cen_pays");
            this.Property(t => t.cen_type).HasColumnName("cen_type");
            this.Property(t => t.code_post).HasColumnName("code_post");
            this.Property(t => t.commentaire).HasColumnName("commentaire");
            this.Property(t => t.domaines).HasColumnName("domaines");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fb).HasColumnName("fb");
            this.Property(t => t.horaires).HasColumnName("horaires");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.internet_type).HasColumnName("internet_type");
            this.Property(t => t.lastchange_time).HasColumnName("lastchange_time");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lng).HasColumnName("lng");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.pays).HasColumnName("pays");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.pret).HasColumnName("pret");
            this.Property(t => t.sigle).HasColumnName("sigle");
            this.Property(t => t.star).HasColumnName("star");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.ville).HasColumnName("ville");
        }
    }
}
