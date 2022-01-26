using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SignalRWebApp.Startup))]
namespace SignalRWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}