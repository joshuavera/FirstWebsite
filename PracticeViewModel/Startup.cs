using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeViewModel.Startup))]
namespace PracticeViewModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
