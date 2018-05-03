using SolutionMyIRMC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace SolutionMyIRMC.Data.Models.Mapping
{
    class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.idEvent);
            // Properties
       





        }
    }
}
