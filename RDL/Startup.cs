using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RDL.Startup))]
namespace RDL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
