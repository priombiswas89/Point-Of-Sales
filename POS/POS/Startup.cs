using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POS.Startup))]
namespace POS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
