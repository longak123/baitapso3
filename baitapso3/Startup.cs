using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baitapso3.Startup))]
namespace baitapso3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
