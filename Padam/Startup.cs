using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Padam.Startup))]
namespace Padam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
