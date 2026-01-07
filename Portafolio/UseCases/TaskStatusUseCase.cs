using Portafolio.Models;
using Portafolio.UseCases.Abstract;
using System.Collections.Generic;

namespace Portafolio.UseCases
{
    public class TaskStatusUseCase : AbstractRepository<Portafolio.Models.TaskStatus>
    {
        public TaskStatusUseCase(TaskContext context) : base(context, context.TaskStatus)
        {
        }

        public int Count() => _set.Count;
        public List<Portafolio.Models.TaskStatus> GetAll()
        {
            return base.GetAll().ToList();
        }
        public void Add(Portafolio.Models.TaskStatus request)
        {
            base.Add(request);
        }
        public void Update(Portafolio.Models.TaskStatus request)
        {
            var current = base.GetById(request.Id);
            current.Name = request.Name;
        }
        public void Remove(Guid id)
        {
            base.Remove(id);
        }
    }
}
