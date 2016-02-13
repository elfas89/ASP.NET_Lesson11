using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Less_11.Startup))]
namespace Less_11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
