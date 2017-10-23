using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zentrix.Startup))]
namespace Zentrix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
