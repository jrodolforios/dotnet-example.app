using Swashbuckle.AspNetCore.Annotations;

namespace Dotnet.ExampleApp.Domain.Models.Models
{
    public class Wheel
    {
        [SwaggerSchema("The size of the wheel in inches")]
        public int Size { get; set; }

        [SwaggerSchema("The type of the wheel")]
        public string Type { get; set; }

        public Wheel(int size, string type)
        {
            Size = size;
            Type = type;
        }
    }
}
