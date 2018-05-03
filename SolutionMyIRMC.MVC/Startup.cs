using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionMyIRMC.MVC.Startup))]
namespace SolutionMyIRMC.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
