using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB345.Startup))]
namespace LAB345
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
