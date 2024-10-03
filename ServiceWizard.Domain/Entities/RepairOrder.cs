using ServiceWizard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServiceWizard.Domain.Entities
{
    public class RepairOrder: AuditableEntity
    {
        [Required]
        public string Title { get; set; }
        public string? DescrptionService { get; set; }
        public string? DescriptionClient { get; set; }
        public string? DescriptionFinal { get; set; }
        [DataType(DataType.Currency)]
        public decimal? CostEstimate { get; set; }
        [DataType(DataType.Currency)]
        public decimal? CostFinal { get; set; }
        public DateTime? EstimatedCompletionDate { get; set; }
        public int RepairTypeId { get; set; }
        public RepairType RepairType { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
