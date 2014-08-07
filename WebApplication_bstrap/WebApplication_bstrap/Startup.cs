using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication_bstrap.Startup))]
namespace WebApplication_bstrap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
