using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(snpptt.Startup))]
namespace snpptt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
