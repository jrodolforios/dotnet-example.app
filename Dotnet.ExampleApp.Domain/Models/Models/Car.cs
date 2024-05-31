using Swashbuckle.AspNetCore.Annotations;

namespace Dotnet.ExampleApp.Domain.Models.Models
{
    public class Car
    {
        [SwaggerSchema("The make of the car")]
        public string Make { get; set; }

        [SwaggerSchema("The model of the car")]
        public string Model { get; set; }

        [SwaggerSchema("The year the car was manufactured")]
        public int Year { get; set; }

        [SwaggerSchema("Engine details of the car")]
        public Engine Engine { get; set; }

        [SwaggerSchema("Details of the car wheels")]
        public List<Wheel> Wheels { get; set; }

        [SwaggerSchema("Interior details of the car")]
        public Interior Interior { get; set; }

        public Car(string make, string model, int year, Engine engine, List<Wheel> wheels, Interior interior)
        {
            Make = make;
            Model = model;
            Year = year;
            Engine = engine;
            Wheels = wheels;
            Interior = interior;
        }
    }
}
