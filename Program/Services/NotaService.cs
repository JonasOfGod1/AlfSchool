using Program.Entities;
using Program.Models.Nota;

namespace Program.Services
{
    public sealed class NotaService
    {
        public void Create(NotaRequestModel requestModel)
        {
            var nota = new Nota()
            {
                Valor = requestModel.Valor
            };

            nota.Validar();
        }
    }
}
