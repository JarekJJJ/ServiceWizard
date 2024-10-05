using ServiceWizard.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Domain.Entities
{
    public class Device: AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? SerialNumber { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string? Type { get; set; }
        public string? Notes { get; set; }
        public ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();
    }
}
