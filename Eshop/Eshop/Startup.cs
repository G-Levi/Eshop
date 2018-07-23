using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eshop.Startup))]
namespace Eshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
