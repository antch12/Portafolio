using Portafolio.Models;
using Portafolio.UseCases.Abstract;
using System.Collections.Generic;

namespace Portafolio.UseCases
{
    public class TaskPriorityUseCase : AbstractRepository<TaskPriority>
    {
        public TaskPriorityUseCase(TaskContext context) : base(context, context.TaskPriorities)
        {
        }

        public int Count() => _set.Count;
        public List<TaskPriority> GetAll()
        {
            return base.GetAll().ToList();
        }
        public void Add(TaskPriority request)
        {
            base.Add(request);
        }
        public void Update(TaskPriority request)
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
