using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrettyPrimate.Startup))]
namespace PrettyPrimate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
