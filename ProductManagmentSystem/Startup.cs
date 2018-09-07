using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagmentSystem.Startup))]
namespace ProductManagmentSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
