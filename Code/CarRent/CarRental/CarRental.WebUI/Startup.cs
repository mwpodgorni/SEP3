using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRental.WebUI.Startup))]
namespace CarRental.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
