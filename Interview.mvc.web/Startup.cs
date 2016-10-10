using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Interview.mvc.web.Startup))]
namespace Interview.mvc.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
