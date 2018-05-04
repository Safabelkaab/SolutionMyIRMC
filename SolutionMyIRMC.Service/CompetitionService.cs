
using SolutionMyIRMC.Data;
using SolutionMyIRMC.Domain.Models;
using SolutionMyIRMC.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Service
{
    public class CompetitionService : Service<competition>, ICompetitionService
    {
        public static DatabaseFactory databasefactory = new DatabaseFactory();
        public static IUnitOfWork utk = new UnitOfWork(databasefactory);
        public CompetitionService():base(utk)
        {

        }

        public IEnumerable<competition> GetCompetitionByTitre(string Titre)
        {
            return GetMany(f => f.titre.Contains(Titre));
        }

        
    }
}
