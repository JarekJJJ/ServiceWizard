using FluentValidation;
using ServiceWizard.Shared.Clients.Commands.CreateClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.CreateClient
{
    public class CreateClientCommandValidator: AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
             RuleFor(RuleFor => RuleFor.Client.FirstName)
                .NotEmpty().WithMessage("Imię jest wymagane")
                .MaximumLength(50).WithMessage("Pole może mieć maksymalnie 50 znaków!");
            RuleFor(RuleFor => RuleFor.Client.LastName)
                .NotEmpty().WithMessage("Nazwisko jest wymagane")
                .MaximumLength(50).WithMessage("Pole może mieć maksymalnie 50 znaków!");
            RuleFor(RuleFor => RuleFor.Client.Email)
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("Niepoprawny adres email")
                .When(RuleFor => !string.IsNullOrEmpty(RuleFor.Client.Email));
            RuleFor(x => x.Client.Phone1)
            .Matches(@"^\+?[1-9]\d{1,14}$")
            .When(x => !string.IsNullOrEmpty(x.Client.Phone1))
            .WithMessage("Pozostaw pole puste lub podaj poprawny numer telefonu");
            RuleFor(x => x.Client.Phone2)
                .Matches(@"^\+?[1-9]\d{1,14}$")
                .When(x => !string.IsNullOrEmpty(x.Client.Phone2))
                .WithMessage("Pozostaw pole puste lub podaj poprawny numer telefonu");
        }
    }
}
