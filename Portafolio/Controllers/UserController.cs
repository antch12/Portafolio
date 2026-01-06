using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portafolio.UseCases;

namespace Portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserUseCase useCase) : ControllerBase
    {
        private readonly UserUseCase _useCase = useCase;

        [HttpGet("total")]
        public IActionResult GetTotalUser()
        {
            try
            {
                return Ok(_useCase.Count());
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
