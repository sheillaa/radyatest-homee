using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homee.Startup))]
namespace Homee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
