using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemoProject.Startup))]
namespace GitDemoProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
