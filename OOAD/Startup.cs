using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OOAD.Startup))]
namespace OOAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
