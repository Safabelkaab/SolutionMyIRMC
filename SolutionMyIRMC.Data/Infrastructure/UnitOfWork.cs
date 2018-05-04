using SolutionMyIRMC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDatabaseFactory factory;
        private myspdbContext datacontext;
        public UnitOfWork(IDatabaseFactory factory)
        {
            this.factory = factory;
            datacontext = factory.DataContext;
        }
        public void Commit()
        {
            datacontext.SaveChanges();
        }

        public IRepositoryBase<T> GetRepositoryBase<T>() where T : class
        {
            return new RepositoryBase<T>(factory);
        }
        public void Dispose()
        {
            datacontext.Dispose();
        }
    }
}
