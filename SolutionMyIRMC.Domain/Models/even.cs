using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class even
    {
        public int IdEvent { get; set; }
        public string CommentaireEvent { get; set; }
        public string ContactEvent { get; set; }
        public Nullable<System.DateTime> date_event { get; set; }
        public string DescriptionEvent { get; set; }
        public string LieuxEvent { get; set; }
        public string TitreEvent { get; set; }
        public byte[] image { get; set; }
        public string telEvent { get; set; }
        public bool validation { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual category category { get; set; }
        public virtual user user { get; set; }
    }
}
