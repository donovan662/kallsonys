using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kallsonys_b2c.Startup))]
namespace kallsonys_b2c
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
