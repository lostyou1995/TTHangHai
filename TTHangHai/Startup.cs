using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTHangHai.Startup))]
namespace TTHangHai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
