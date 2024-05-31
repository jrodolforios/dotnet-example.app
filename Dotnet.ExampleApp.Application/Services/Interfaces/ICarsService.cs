using Dotnet.ExampleApp.Domain.Models.Models;

namespace Dotnet.ExampleApp.Application.Services.Interfaces
{
    public interface ICarsService
    {
        Task<List<Car>> GetCars();
        Task<bool> SaveCar(Car car);
    }
}
