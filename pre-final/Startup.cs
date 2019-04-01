using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pre_final.Startup))]
namespace pre_final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
