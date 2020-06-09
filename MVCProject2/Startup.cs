using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProject2.Startup))]
namespace MVCProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
