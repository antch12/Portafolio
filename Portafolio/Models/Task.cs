using Microsoft.VisualBasic;
using Portafolio.Models.Interfaces;

namespace Portafolio.Models
{
    public class Task : IEntity
    {
        public Guid Id {  get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public int AssignedToUserId { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
