using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DelProjektEtt_MVC_Entity_Razor.Startup))]
namespace DelProjektEtt_MVC_Entity_Razor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
