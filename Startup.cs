using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTraining.Startup))]
namespace MVCTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
