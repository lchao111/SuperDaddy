using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperDaddy.Startup))]
namespace SuperDaddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
