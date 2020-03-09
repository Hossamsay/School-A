using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schoola.Startup))]
namespace Schoola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
