using Portafolio.Models.Interfaces;

namespace Portafolio.Models
{
    public class Comment : IEntity
    {
        public Guid Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
