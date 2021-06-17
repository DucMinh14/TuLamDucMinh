using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuLamDucMinh.Startup))]
namespace TuLamDucMinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
