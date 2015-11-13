using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSandbox.Startup))]
namespace MvcSandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
