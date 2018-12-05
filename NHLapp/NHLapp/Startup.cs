using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHLapp.Startup))]
namespace NHLapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
