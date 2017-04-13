using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstReportTest.Startup))]
namespace FirstReportTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
