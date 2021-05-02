using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiProjectV2.Startup))]
namespace ApiProjectV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
