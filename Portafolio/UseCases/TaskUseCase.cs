using Portafolio.Models;
using Portafolio.UseCases.Abstract;
using System.Collections.Generic;

namespace Portafolio.UseCases
{
    public class TaskUseCase : AbstractRepository<Portafolio.Models.Task>
    {
        public TaskUseCase(TaskContext context) : base(context, context.Tasks)
        {
        }

        public int Count() => _set.Count;
        public List<Portafolio.Models.Task> GetAll()
        {
            return base.GetAll().ToList();
        }
        public void Add(Portafolio.Models.Task request)
        {
            base.Add(request);
        }
        public void Update(Portafolio.Models.Task request)
        {
            var current = base.GetById(request.Id);
            current.Title = request.Title;
            current.Description = request.Description;
            current.ProjectId = request.ProjectId;
            current.StatusId = request.StatusId;
            current.PriorityId = request.PriorityId;
            current.AssignedToUserId = request.AssignedToUserId;
        }
        public void Remove(Guid id)
        {
            base.Remove(id);
        }
    }
}
