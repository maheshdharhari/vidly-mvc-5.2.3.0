using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyAdmin.Startup))]
namespace VidlyAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
