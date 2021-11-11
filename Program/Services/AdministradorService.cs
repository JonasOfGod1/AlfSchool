using Program.Entities;
using Program.Models.Administrador;

namespace Program.Services
{
    public sealed class AdministradorService
    {

        public int Create(AdministradorRequestModel requestModel)
        {
            var administrador = new Administrador()
            {
                Nome = requestModel.Nome,
                Cpf = requestModel.Cpf,
                Senha = requestModel.Senha,
                Tipo = requestModel.Tipo
            };

            administrador.Validar();

            return 1;
        }
    }
}
