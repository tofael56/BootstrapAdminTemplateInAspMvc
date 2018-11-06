using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapAdminTemplateInAspMvc.Startup))]
namespace BootstrapAdminTemplateInAspMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
