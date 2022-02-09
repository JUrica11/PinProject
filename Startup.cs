using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PinProject.Startup))]
namespace PinProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
