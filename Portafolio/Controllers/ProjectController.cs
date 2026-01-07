using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.UseCases;

namespace Portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(ProjectUseCase useCase) : ControllerBase
    {
        private readonly ProjectUseCase _useCase = useCase;
        [HttpPost]
        public IActionResult Create(Project request)
        {
            try
            {
                _useCase.Add(request);
                return Ok();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(Project request)
        {
            try
            {
                _useCase.Update(request);
                return Ok();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
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
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_useCase.GetAll());
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _useCase.Remove(id);
                return Ok();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
