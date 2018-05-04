using SolutionMyIRMC.Domain.Models;
using SolutionMyIRMC.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Service
{
    public interface IStageService : IService<stage>
    {
        
        IEnumerable<stage> GetStageByTitre(string Titre);
        stage GetStageById(int id);
    }
}
