using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KapyTestData.Startup))]
namespace KapyTestData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
