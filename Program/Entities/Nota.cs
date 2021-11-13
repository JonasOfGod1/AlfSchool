using FluentValidation;
using Program.Validations;

namespace Program.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public bool Deletado { get; set; }

        public void Validar()
        {
            var notaValidator = new NotaValidator();
            notaValidator.ValidateAndThrow(this);
        }
    }
}
