using Portafolio.Models.Interfaces;

namespace Portafolio.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = null!;
        public string Userame { get; set; } = null!;
    }
}
