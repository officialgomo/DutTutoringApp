using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DutTutoringApp.Startup))]
namespace DutTutoringApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
