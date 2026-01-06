using Portafolio.Models.Interfaces;

namespace Portafolio.Models
{
    public class Project : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } 
        public int CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StatusId { get; set; }
    }
}
