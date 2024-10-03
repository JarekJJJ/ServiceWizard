using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Domain.Common
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public int StatusId { get; set; }
        public string? InactivatedBy { get; set; }
        public DateTime? Inactivated { get; set; }
    }
}
