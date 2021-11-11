using Program.Entities;
using Program.Models.Professor;

namespace Program.Services
{
    public sealed class ProfessorService
    {
        public int Create(ProfessorRequestModel requestModel)
        {
            var processor = new Professor()
            {
                Nome = requestModel.Nome,
                Materia = requestModel.Materia,
                Cpf = requestModel.Cpf,
                Senha = requestModel.Senha,
                Sala = requestModel.Sala,
                Tipo = requestModel.Tipo
            };

            processor.Validar();

            return 1;
        }
    }
}
