using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(uniaspappc2.Startup))]
namespace uniaspappc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
