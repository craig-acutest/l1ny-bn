using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(l1ny.Startup))]
namespace l1ny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
