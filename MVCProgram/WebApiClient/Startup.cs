using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiClient.Startup))]
namespace WebApiClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
