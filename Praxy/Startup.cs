using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Praxy.Startup))]
namespace Praxy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
