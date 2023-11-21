using FluentValidation;
using RedeSocial.Domain.Entities;

namespace RedeSocial.Service.Validators
{
    public class AmizadeValidator : AbstractValidator<Amizade>
    {
        public AmizadeValidator()
        {
            RuleFor(a => a.Usuario1)
                .NotNull().WithMessage("A amizade deve estar associada a um usuário.");

            RuleFor(a => a.Usuario2)
                .NotNull().WithMessage("A amizade deve estar associada a um segundo usuário.");

            RuleFor(a => a.EstadoAmizade)
                .NotEmpty().WithMessage("Por favor, informe o estado da amizade.")
                .NotNull().WithMessage("Por favor, informe o estado da amizade.");
        }
    }
}
