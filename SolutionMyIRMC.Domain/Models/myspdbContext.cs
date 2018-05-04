using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SolutionMyIRMC.Domain.Models.Mapping;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class myspdbContext : DbContext
    {
        static myspdbContext()
        {
            //Database.SetInitializer<myspdbContext>(null);
        }

        public myspdbContext()
            : base("name=myspdbContext")
        {
        }

        public DbSet<category> categories { get; set; }
        public DbSet<document> documents { get; set; }
        public DbSet<even> evens { get; set; }
        public DbSet<favori> favoris { get; set; }
        public DbSet<indexdocument> indexdocuments { get; set; }
        public DbSet<joboffer> joboffers { get; set; }
        public DbSet<researchcenter> researchcenters { get; set; }
        public DbSet<stage> stages { get; set; }
        public DbSet<tender> tenders { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new documentMap());
            modelBuilder.Configurations.Add(new evenMap());
            modelBuilder.Configurations.Add(new favoriMap());
            modelBuilder.Configurations.Add(new indexdocumentMap());
            modelBuilder.Configurations.Add(new jobofferMap());
            modelBuilder.Configurations.Add(new researchcenterMap());
            modelBuilder.Configurations.Add(new stageMap());
            modelBuilder.Configurations.Add(new tenderMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
