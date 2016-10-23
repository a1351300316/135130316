using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(text.Startup))]
namespace text
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
