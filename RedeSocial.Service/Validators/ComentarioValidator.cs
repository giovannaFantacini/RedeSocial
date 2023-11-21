using FluentValidation;
using RedeSocial.Domain.Entities;

namespace RedeSocial.Service.Validators
{
    public class ComentarioValidator : AbstractValidator<Comentario>
    {
        public ComentarioValidator()
        {
            RuleFor(c => c.TextoComentario)
                .NotEmpty().WithMessage("Por favor, informe o texto do comentário.")
                .NotNull().WithMessage("Por favor, informe o texto do comentário.");

            RuleFor(c => c.Postagem)
                .NotNull().WithMessage("O comentário deve estar associado a uma postagem.");

            RuleFor(c => c.Usuario)
                .NotNull().WithMessage("O comentário deve estar associado a um usuário.");
        }
    }
}
