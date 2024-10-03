using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Shared.Tasks.Commands;
public class AddTaskVm
{
    [Required(ErrorMessage ="Pole wymagane")]
    public string Name { get; set; }
    public StatusTask Status { get; set; }
    //public string? Description { get; set; }
    //public DateTime? AddDate { get; set; } = DateTime.Now;
    //public DateTime? UpdateDate { get; set; }
    //public DateTime? EndDate { get; set; }
    public enum StatusTask
    {
        [Display(Name = "Nowa")]
        New,
        Rozpoczęta,
        Zakończona
    }
}
