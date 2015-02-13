using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoApp.AdminSite.Startup))]
namespace TodoApp.AdminSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
