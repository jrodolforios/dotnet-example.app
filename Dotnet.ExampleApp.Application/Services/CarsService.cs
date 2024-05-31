using Dotnet.ExampleApp.Application.Services.Interfaces;
using Dotnet.ExampleApp.Domain.Models.Models;
using Dotnet.ExampleApp.Infra.Repositories;
using AutoMapper;

namespace Dotnet.ExampleApp.Application.Services
{
    public class CarsService(IUnitOfWork _unitOfWork, IMapper _mapper) : ICarsService
    {
        public async Task<List<Car>> GetCars()
        {
            var carsEntities = await _unitOfWork.Cars.GetCars();

            var carsResult = _mapper.Map<List<Car>>(carsEntities);

            return carsResult;
        }

        public async  Task<bool> SaveCar(Car car)
        {
            var carEntity = _mapper.Map<Infra.Models.Car>(car);

            await _unitOfWork.Cars.SaveCar(carEntity);

            return true;
        }
    }
}
