using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timmy.Startup))]
namespace Timmy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
