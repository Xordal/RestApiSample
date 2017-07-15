namespace Swashbuckle.Demo.WebAPI
{
    using System;
    using System.Web.Http;

    using Swashbuckle.Demo.WebAPI.App_Start;

    /// <summary>
    /// Entry point to Rest API.
    /// </summary>
    /// <seealso cref="System.Web.HttpApplication" />
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Handles the Start event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Application_Start(Object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}