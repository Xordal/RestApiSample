namespace Swashbuckle.Demo.WebAPI
{
    using System.Web.Http;
    using Owin;

    /// <summary>
    /// Owin startup class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configurations the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(GlobalConfiguration.Configuration);
        }
    }
}