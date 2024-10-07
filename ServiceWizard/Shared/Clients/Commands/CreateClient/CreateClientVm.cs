using System.ComponentModel.DataAnnotations;

namespace ServiceWizard.Shared.Clients.Commands.CreateClient
{
    public class CreateClientVm
    {
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone1 { get; set; }        
        public string? Phone2 { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
