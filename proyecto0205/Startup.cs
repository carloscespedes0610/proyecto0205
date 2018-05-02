using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto0205.Startup))]
namespace proyecto0205
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
