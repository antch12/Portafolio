using Portafolio.Models;
using Portafolio.UseCases.Abstract;
using System.Collections.Generic;

namespace Portafolio.UseCases
{
    public class ProjectUseCase : AbstractRepository<Project>
    {
        public ProjectUseCase(TaskContext context) : base(context, context.Projects)
        {
        }

        public int Count() => _set.Count;
        public List<Project> GetAll()
        {
            return base.GetAll().ToList();
        }
        public void Add(Project request)
        {
            base.Add(request);
        }
        public void Update(Project request)
        {
            var current = base.GetById(request.Id);
            current.Name = request.Name;
            current.Description = request.Description;
            current.StatusId = request.StatusId;
        }
        public void Remove(Guid id)
        {
            base.Remove(id);
        }
    }
}
