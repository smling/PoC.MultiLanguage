using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoC.MultiLanguage.Startup))]
namespace PoC.MultiLanguage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
