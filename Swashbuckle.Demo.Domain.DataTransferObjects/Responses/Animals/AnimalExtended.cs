namespace Swashbuckle.Demo.Domain.DataTransferObjects.Responses.Animals
{
    using System;

    public class AnimalExtended : Animal
    {
        public Int64 AuthorId { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
