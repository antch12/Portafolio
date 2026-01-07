using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.UseCases;

namespace Portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskPriorityController(TaskPriorityUseCase useCase) : ControllerBase
    {
        private readonly TaskPriorityUseCase _useCase = useCase;
        [HttpPost]
        public IActionResult Create(TaskPriority user)
        {
            try
            {
                _useCase.Add(user);
                return Ok();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(TaskPriority request)
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
