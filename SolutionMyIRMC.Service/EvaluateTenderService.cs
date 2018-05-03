using Data.Infrastructure;
using SolutionMyIRMC.Domain;
using SolutionMyIRMC.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Service
{
    public class EvaluateTenderService : Service<EvaluationTender>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public EvaluateTenderService() : base(ut)
        {


        }
    }
}
