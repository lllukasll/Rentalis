using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rentalis_v2.Startup))]
namespace Rentalis_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
