using ServiceWizard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Domain.Entities
{
    public class RepairType: AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();
    }
}
