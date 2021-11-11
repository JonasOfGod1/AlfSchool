using FluentValidation;
using Program.Validations;

namespace Program.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Sala { get; set; }
        public string Tipo { get; set; }
        public bool Deletado { get; set; }

        public void Validar()
        {
            var alunoValidator = new AlunoValidator();
            alunoValidator.ValidateAndThrow(this);
        }
    }
}
