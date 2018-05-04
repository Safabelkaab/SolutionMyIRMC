using SolutionMyIRMC.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SolutionMyIRMC.MVC.Models
{
    public class StageViewModel
    {
        
        
        public int IdStage { get; set; }
        public string Competence { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateDebut { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateFin { get; set; }
        public string ImageLieu { get; set; }
        public Nullable<bool> Remuneration { get; set; }
        public Nullable<float> Salaire { get; set; }
        public string lieu { get; set; }
        public string Titre { get; set; }
        public virtual ICollection<document> listDocs { get; set; }
        public StageViewModel()
        {

        }
    }
}