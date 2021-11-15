using Program.Entities;
using Program.Models.Administrador;
using System.Collections.Generic;

namespace Program.Services
{
    public sealed class AdministradorService
    {
        public void Create(AdministradorRequestModel requestModel)
        {
            var administrador = new Administrador()
            {
                Nome = requestModel.Nome,
                Cpf = requestModel.Cpf,
                Senha = requestModel.Senha,
                Tipo = requestModel.Tipo
            };

            administrador.Validar();
        }

        public Administrador Autenticar(string cpf, string senha)
        {
            var administradores = new List<Administrador>();

            var administrador1 = new Administrador()
            {
                Id = 1,
                Nome = "Master",
                Cpf = "68214128048",
                Senha = "master123",
                Tipo = "Administrador"
            };
            var administrador2 = new Administrador()
            {
                Id = 2,
                Nome = "Rosane Aguilar",
                Cpf = "77695293016",
                Senha = "rosane.aguilar",
                Tipo = "Administrador"
            };
            var administrador3 = new Administrador()
            {
                Id = 3,
                Nome = "Antonio de Souza",
                Cpf = "76574341043",
                Senha = "antonio.souza",
                Tipo = "Administrador"
            };

            administradores.Add(administrador1);
            administradores.Add(administrador2);
            administradores.Add(administrador3);

            foreach (var item in administradores)
            {
                if (cpf == item.Cpf && senha == item.Senha)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
