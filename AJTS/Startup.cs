using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AJTS.Startup))]
namespace AJTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
