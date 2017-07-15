namespace Swashbuckle.Demo.WebAPI.Controllers
{
    using System;
    using System.Security.Cryptography;
    using System.Web.Http;

    using Swashbuckle.Demo.Domain.DataTransferObjects.Responses.Animals;

    /// <summary>
    /// Test controller
    /// </summary>
    [RoutePrefix("api/animals")]
    public class AnimalsController : ApiController
    {
        /// <summary>
        /// Animals the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("{id}")]
        public Animal Animal(Int64 id)
        {
            if (id == 1)
            {
                return new AnimalExtended()
                {
                    Id = 1,
                    Name = "Latrodectus tredecimguttatus",
                    PublishDate = new DateTime(2017, 01, 01),
                    AuthorId = 1
                };
            }
            return new Animal()
            {
                Id = 1,
                Name = "Latrodectus tredecimguttatus"
            };
        }
    }
}