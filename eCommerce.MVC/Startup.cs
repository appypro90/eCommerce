using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerce.MVC.Startup))]
namespace eCommerce.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
