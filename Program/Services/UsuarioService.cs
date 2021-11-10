using Program.Entities;
using Program.Models.Administrador;

namespace Program.Services
{
    public sealed class UsuarioService
    {

        public int Create(UsuarioRequestModel requestModel)
        {
            var usuario = new Usuario()
            {
                Nome = requestModel.Nome,
                Cpf = requestModel.Cpf,
                Senha = requestModel.Senha,
                Tipo = requestModel.Tipo
            };

            usuario.Validar();

            return 1;
        }
    }
}
