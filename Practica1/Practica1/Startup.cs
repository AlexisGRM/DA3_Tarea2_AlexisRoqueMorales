using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica1.Startup))]
namespace Practica1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
