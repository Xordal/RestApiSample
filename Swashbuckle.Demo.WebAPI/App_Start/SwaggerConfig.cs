using Swashbuckle.Demo.WebAPI;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Swashbuckle.Demo.WebAPI
{
    using System;
    using System.IO;
    using System.Web.Http;

    using Swashbuckle.Application;

    /// <summary>
    /// Swagger configuration file.
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Registers this instance.
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Swashbuckle.Demo.WebAPI");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                        c.UseFullTypeNameInSchemaIds();
                    })
                .EnableSwaggerUi(c =>
                    { });
        }

        private static String GetXmlCommentsPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin\\Swashbuckle.Demo.WebAPI.XML");
        }
    }
}
