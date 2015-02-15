using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog_App_MVC.Startup))]
namespace Blog_App_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
