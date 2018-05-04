using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class user
    {
        public user()
        {
            this.documents = new List<document>();
            this.evens = new List<even>();
        }

        public int idUser { get; set; }
        public string email { get; set; }
        public string nom { get; set; }
        public string password { get; set; }
        public string prenom { get; set; }
        public string role { get; set; }
        public virtual ICollection<document> documents { get; set; }
        public virtual ICollection<even> evens { get; set; }
    }
}
