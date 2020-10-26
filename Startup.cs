using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanguageMastery.Startup))]
namespace LanguageMastery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
