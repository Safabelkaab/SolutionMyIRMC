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
    public class StageService : Service<stage>, IStageService
    {
        public static DatabaseFactory databasefactory = new DatabaseFactory();
        public static IUnitOfWork utk = new UnitOfWork(databasefactory);
        public StageService():base(utk)
        {

        }

        public stage GetStageById(int id)
        {
            return GetById(id);
        }

        public IEnumerable<stage> GetStageByTitre(string Titre)
        {
            return GetMany(f => f.Titre.Contains(Titre));
        }
    }
}
