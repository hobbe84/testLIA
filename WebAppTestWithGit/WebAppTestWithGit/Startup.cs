using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTestWithGit.Startup))]
namespace WebAppTestWithGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
