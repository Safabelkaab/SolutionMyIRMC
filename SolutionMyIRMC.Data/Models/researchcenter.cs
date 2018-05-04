using System;
using System.Collections.Generic;

namespace SolutionMyIRMC.Domain.Models
{
    public partial class researchcenter
    {
        public long idcent { get; set; }
        public string Tel { get; set; }
        public string acces_type { get; set; }
        public string adresse { get; set; }
        public string catalogue { get; set; }
        public string cen_lastchange_by { get; set; }
        public string cen_pays { get; set; }
        public string cen_type { get; set; }
        public string code_post { get; set; }
        public string commentaire { get; set; }
        public string domaines { get; set; }
        public string email { get; set; }
        public string fb { get; set; }
        public string horaires { get; set; }
        public string img { get; set; }
        public string internet_type { get; set; }
        public Nullable<System.DateTime> lastchange_time { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string nom { get; set; }
        public string pays { get; set; }
        public byte[] photo { get; set; }
        public string pret { get; set; }
        public string sigle { get; set; }
        public int star { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string ville { get; set; }
    }
}
