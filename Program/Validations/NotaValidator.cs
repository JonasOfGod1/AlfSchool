using FluentValidation;
using Program.Entities;

namespace Program.Validations
{
    public class NotaValidator : AbstractValidator<Nota>
    {
        public NotaValidator()
        {
            RuleFor(n => n.Valor)
                .NotEmpty().WithMessage("Nota deve ser informada.")
                .InclusiveBetween(0, 10).WithMessage("Nota deve ser entre 0 e 10.");
        }
    }
}
