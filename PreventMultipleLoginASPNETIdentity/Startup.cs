using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreventMultipleLoginASPNETIdentity.Startup))]
namespace PreventMultipleLoginASPNETIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
