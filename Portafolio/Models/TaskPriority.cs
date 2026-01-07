using Portafolio.Models.Abstract;
using Portafolio.Models.Interfaces;

namespace Portafolio.Models
{
    public class TaskPriority : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
