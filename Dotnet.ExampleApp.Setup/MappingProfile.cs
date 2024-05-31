using AutoMapper;
using CarDto = Dotnet.ExampleApp.Infra.Models.Car;
using EngineDto = Dotnet.ExampleApp.Infra.Models.Engine;
using WheelDto = Dotnet.ExampleApp.Infra.Models.Wheel;
using InteriorDto = Dotnet.ExampleApp.Infra.Models.Interior;
using Dotnet.ExampleApp.Domain.Models.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Mapping from EF models to DTOs
        CreateMap<Car, CarDto>();
        CreateMap<Engine, EngineDto>();
        CreateMap<Wheel, WheelDto>();
        CreateMap<Interior, InteriorDto>();

        // Mapping from DTOs to EF models (if needed)
        CreateMap<CarDto, Car>();
        CreateMap<EngineDto, Engine>();
        CreateMap<WheelDto, Wheel>();
        CreateMap<InteriorDto, Interior>();
    }
}
