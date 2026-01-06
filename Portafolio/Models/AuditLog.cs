using Portafolio.Models.Interfaces;
using System;

namespace Portafolio.Models
{
    public class AuditLog : IEntity
    {
        public Guid Id { get; set; }
        public string EntityName { get; set; } = null!;
        public int EntityId { get; set; }
        public ActionsLogs Action {  get; set; }
        public int PerformedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public enum ActionsLogs
    {
        CREATE,
        UPDATE,
        DELETE,
    }
}
