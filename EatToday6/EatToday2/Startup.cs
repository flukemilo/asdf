using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EatToday2.Startup))]
namespace EatToday2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
