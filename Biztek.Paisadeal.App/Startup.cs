using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biztek.Paisadeal.App.Startup))]
namespace Biztek.Paisadeal.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
