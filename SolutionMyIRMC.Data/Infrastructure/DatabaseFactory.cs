using SolutionMyIRMC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionMyIRMC.Data
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {

        private myspdbContext datacontext;
        public DatabaseFactory()
        {
            datacontext = new myspdbContext();
        }
        public myspdbContext DataContext
        {
            get
            {
                return datacontext;
            }
        }
        protected override void DisposeCore()
        {
            if(DataContext!=null)
            DataContext.Dispose();
        }
    }
}
