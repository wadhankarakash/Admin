using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SparshSchoolAdmin.Startup))]
namespace SparshSchoolAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
