using FluentValidation;
using RedeSocial.Domain.Entities;

namespace RedeSocial.Service.Validators
{
    public class CurtidaValidator : AbstractValidator<Curtida>
    {
        public CurtidaValidator()
        {
            RuleFor(c => c.Postagem)
                .NotNull().WithMessage("A curtida deve estar associada a uma postagem.");

            RuleFor(c => c.Usuario)
                .NotNull().WithMessage("A curtida deve estar associada a um usuário.");
        }
    }
}
