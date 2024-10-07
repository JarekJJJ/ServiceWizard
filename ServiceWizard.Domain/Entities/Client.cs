using ServiceWizard.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ServiceWizard.Domain.Entities
{
    public class Client : AuditableEntity
    {
        [Required(ErrorMessage ="Imię jest wymagane")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Email { get; set; }
        public ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();
    }
}