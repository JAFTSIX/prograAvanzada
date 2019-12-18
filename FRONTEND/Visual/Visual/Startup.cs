using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Visual.Startup))]
namespace Visual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
