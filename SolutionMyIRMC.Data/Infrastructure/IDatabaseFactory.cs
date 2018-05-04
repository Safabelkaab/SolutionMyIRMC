using SolutionMyIRMC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Data
{
    public interface IDatabaseFactory : IDisposable
    {
        myspdbContext DataContext { get;}


    }
}
