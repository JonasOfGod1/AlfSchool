using Program.Entities;
using Program.Models.Aluno;

namespace Program.Services
{
    public sealed class AlunoService
    {
        public int Create(AlunoRequestModel requestModel)
        {
            var aluno = new Aluno()
            {
                Nome = requestModel.Nome,
                Cpf = requestModel.Cpf,
                Senha = requestModel.Senha,
                Sala = requestModel.Sala,
                Tipo = requestModel.Tipo
            };

            aluno.Validar();

            return 1;
        }
    }
}
