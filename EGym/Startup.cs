using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EGym.Startup))]
namespace EGym
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
