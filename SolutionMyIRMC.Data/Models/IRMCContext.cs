using SolutionMyIRMC.Data.Models.Mapping;
using SolutionMyIRMC.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Data.Models
{
  //  [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class IRMCContext : DbContext
    {
        static IRMCContext()
        {
            Database.SetInitializer<IRMCContext>(null);
        }

        public IRMCContext()
            : base("Name=IRMCContext")
        {
        }

        public DbSet<Event> events { get; set; }
        public DbSet<CommentEvent> commentEvents { get; set; }
        public DbSet<TopicEvent> topicEvents { get; set; }
        public DbSet<EvaluationEvent> evaluationEvents { get; set; }
        public DbSet<EvaluationTender> evaluationTenders { get; set; }
        public DbSet<Tender> tenders { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
  
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new commentEventMap());
            modelBuilder.Configurations.Add(new topicEventMap());
            modelBuilder.Configurations.Add(new evaluationEventsMap());
            modelBuilder.Configurations.Add(new evaluationTendersMap());
            modelBuilder.Configurations.Add(new tendersMap());



        }
    }
}
