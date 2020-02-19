using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Human_Resource.Startup))]
namespace Human_Resource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
