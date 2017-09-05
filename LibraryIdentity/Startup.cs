using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryIdentity.Startup))]
namespace LibraryIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
