using Microsoft.Owin;
using MvcSandbox;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
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
