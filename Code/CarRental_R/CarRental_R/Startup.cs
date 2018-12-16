using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRental_R.Startup))]
namespace CarRental_R
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
