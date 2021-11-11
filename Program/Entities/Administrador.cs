using FluentValidation;
using Program.Validations;

namespace Program.Entities
{
    public class Administrador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public bool Deletado { get; set; }

        public void Validar()
        {
            var administradorValidator = new AdministradorValidator();
            administradorValidator.ValidateAndThrow(this);
        }
    }
}
