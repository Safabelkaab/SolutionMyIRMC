using SolutionMyIRMC.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SolutionMyIRMC.MVC.Models
{
    public class DocumentViewModel
    {
        public int idDocument { get; set; }
        public string image { get; set; }
        public string nom { get; set; }
        public int nombreindex { get; set; }
        [DataType(DataType.ImageUrl), Display(Name = "Img")]
        public string path { get; set; }
        public string pathImage { get; set; }
        public string titre { get; set; }
        public string type { get; set; }

        

        public virtual stage stage { get; set; }
    }
}