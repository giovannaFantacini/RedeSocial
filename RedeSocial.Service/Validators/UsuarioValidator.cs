using FluentValidation;
using RedeSocial.Domain.Entities;

namespace RedeSocial.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.NomeUsuario)
                .NotEmpty().WithMessage("Por favor, informe o nome de usuário.")
                .NotNull().WithMessage("Por favor, informe o nome de usuário.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Por favor, informe o email.")
                .NotNull().WithMessage("Por favor, informe o email.")
                .EmailAddress().WithMessage("Formato de email inválido.");

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("Por favor, informe a senha.")
                .NotNull().WithMessage("Por favor, informe a senha.");

            RuleFor(u => u.DataDeRegistro)
                .NotNull().WithMessage("A data de registro não pode ser nula.");
        }
    }
}