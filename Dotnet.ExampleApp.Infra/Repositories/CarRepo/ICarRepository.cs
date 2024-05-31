using Dotnet.ExampleApp.Infra.Models;

namespace Dotnet.ExampleApp.Infra.Repositories.CarRepo
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCars();
        Task SaveCar(Car carEntity);
    }
}
