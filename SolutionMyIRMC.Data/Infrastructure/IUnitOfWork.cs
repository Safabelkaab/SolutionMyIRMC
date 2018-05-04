using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Data
{
    public interface IUnitOfWork :IDisposable
    {
        void Commit();
        IRepositoryBase<T> GetRepositoryBase<T>() where T : class;

    }
}
