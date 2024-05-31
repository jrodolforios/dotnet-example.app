using Swashbuckle.AspNetCore.Annotations;

namespace Dotnet.ExampleApp.Domain.Models.Models
{
    public class Engine
    {
        [SwaggerSchema("The type of the engine")]
        public string Type { get; set; }

        [SwaggerSchema("The horsepower of the engine")]
        public int Horsepower { get; set; }

        public Engine(string type, int horsepower)
        {
            Type = type;
            Horsepower = horsepower;
        }
    }
}
