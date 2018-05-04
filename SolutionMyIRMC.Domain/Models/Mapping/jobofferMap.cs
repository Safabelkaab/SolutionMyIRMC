using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SolutionMyIRMC.Domain.Models.Mapping
{
    public class jobofferMap : EntityTypeConfiguration<joboffer>
    {
        public jobofferMap()
        {
            // Primary Key
            this.HasKey(t => t.idJob);

            // Properties
            this.Property(t => t.DescripPoste)
                .HasMaxLength(255);

            this.Property(t => t.Intitule_Poste)
                .HasMaxLength(255);

            this.Property(t => t.Mission)
                .HasMaxLength(255);

            this.Property(t => t.NomEntrep)
                .HasMaxLength(255);

            this.Property(t => t.Numtelf)
                .HasMaxLength(255);

            this.Property(t => t.Profil_candidat)
                .HasMaxLength(255);

            this.Property(t => t.Sect_Activite)
                .HasMaxLength(255);

            this.Property(t => t.Type_contrat)
                .HasMaxLength(255);

            this.Property(t => t.adresse)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("joboffer", "myspdb");
            this.Property(t => t.idJob).HasColumnName("idJob");
            this.Property(t => t.DescripPoste).HasColumnName("DescripPoste");
            this.Property(t => t.Intitule_Poste).HasColumnName("Intitule_Poste");
            this.Property(t => t.Mission).HasColumnName("Mission");
            this.Property(t => t.NomEntrep).HasColumnName("NomEntrep");
            this.Property(t => t.Numtelf).HasColumnName("Numtelf");
            this.Property(t => t.Profil_candidat).HasColumnName("Profil_candidat");
            this.Property(t => t.Sect_Activite).HasColumnName("Sect_Activite");
            this.Property(t => t.Type_contrat).HasColumnName("Type_contrat");
            this.Property(t => t.adresse).HasColumnName("adresse");
            this.Property(t => t.mail).HasColumnName("mail");
        }
    }
}
