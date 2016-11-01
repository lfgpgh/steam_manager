using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SteamManager.Server.Startup))]
namespace SteamManager.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
