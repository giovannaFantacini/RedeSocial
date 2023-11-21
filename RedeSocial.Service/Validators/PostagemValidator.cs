using FluentValidation;
using RedeSocial.Domain.Entities;

namespace RedeSocial.Service.Validators
{
    public class PostagemValidator : AbstractValidator<Postagem>
    {
        public PostagemValidator()
        {
            RuleFor(p => p.TextoDaPostagem)
                .NotEmpty().WithMessage("Por favor, informe o texto da postagem.")
                .NotNull().WithMessage("Por favor, informe o texto da postagem.");

            RuleFor(p => p.Usuario)
                .NotNull().WithMessage("A postagem deve ter um usuário associado.");
        }
    }
}
