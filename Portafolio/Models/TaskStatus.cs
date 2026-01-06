using Portafolio.Models.Abstract;

namespace Portafolio.Models
{
    public class TaskStatus : Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
