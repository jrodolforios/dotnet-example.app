using Swashbuckle.AspNetCore.Annotations;

namespace Dotnet.ExampleApp.Domain.Models.Models
{
    public class Interior
    {
        [SwaggerSchema("The type of material used in the interior")]
        public string Material { get; set; }

        [SwaggerSchema("The color of the interior")]
        public string Color { get; set; }

        public Interior(string material, string color)
        {
            Material = material;
            Color = color;
        }
    }
}
