using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_HrmsApp.Startup))]
namespace Angular_HrmsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
