using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Utp.Startup))]
namespace Utp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
