using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Bookstore.Startup))]
namespace Bookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
