using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProdCode.Startup))]
namespace ProdCode
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
