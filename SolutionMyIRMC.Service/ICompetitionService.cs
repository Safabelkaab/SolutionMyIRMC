using SolutionMyIRMC.Domain.Models;
using SolutionMyIRMC.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Service
{
    public interface ICompetitionService : IService<competition>
    {
        
        IEnumerable<competition> GetCompetitionByTitre(string Titre);

    }
}
