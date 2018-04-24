using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionMyIRMC.MVC.Models
{
    public class Document
    {
        public String type { get; set; }
        public String path { get; set; }
        public int idDocument { get; set; }
        public String image { get; set; }
        public String pathImage { get; set; }
        public int nombreindex { get; set; }
        public String nom { get; set; }
        public String titre { get; set; }
        public Document()
        {
                    
        }
    }
}