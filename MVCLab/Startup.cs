using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLab.Startup))]
namespace MVCLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
