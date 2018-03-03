using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_SignalR.Startup))]
namespace WebApp_SignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
