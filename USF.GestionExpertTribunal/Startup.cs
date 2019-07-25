using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(USF.GestionExpertTribunal.Startup))]
namespace USF.GestionExpertTribunal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
