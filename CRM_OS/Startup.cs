using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_OS.Startup))]
namespace CRM_OS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
