
using Dotnet.ExampleApp.Application.Services.Interfaces;
using Dotnet.ExampleApp.Domain.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.ExampleApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class CarsController(ICarsService _addressService) : Controller
    {
        [HttpGet(Name = "GetCars")]
        [ProducesResponseType(typeof(List<Car>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCars()
        {
            try
            {
                var result = await _addressService.GetCars();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPost(Name = "SaveCars")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SaveCar(Car car)
        {
            try
            {
                var result = await _addressService.SaveCar(car);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
