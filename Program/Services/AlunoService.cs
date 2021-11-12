using Program.Entities;
using Program.Models.Aluno;
using System.Collections.Generic;

namespace Program.Services
{
    public sealed class AlunoService
    {
        public void Create(AlunoRequestModel requestModel)
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
        }

        public Aluno Logar(string cpf, string senha)
        {
            var alunos = new List<Aluno>();

            var aluno1 = new Aluno()
            {
                Id = 1,
                Nome = "Vitor da Rosa",
                Cpf = "29284447003",
                Senha = "vitor.rosa",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno2 = new Aluno()
            {
                Id = 2,
                Nome = "Carlos da Silva",
                Cpf = "86451430030",
                Senha = "carlos.silva",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno3 = new Aluno()
            {
                Id = 3,
                Nome = "Lenadro de Souza",
                Cpf = "62091592064",
                Senha = "leandro.souza",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno4 = new Aluno()
            {
                Id = 4,
                Nome = "Leonardo Andrade",
                Cpf = "59118029027",
                Senha = "leonardo.andrade",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno5 = new Aluno()
            {
                Id = 5,
                Nome = "Douglas Castro",
                Cpf = "30959252045",
                Senha = "douglas.castro",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno6 = new Aluno()
            {
                Id = 6,
                Nome = "Henrique Nunes",
                Cpf = "36572460029",
                Senha = "henrique.nunes",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno7 = new Aluno()
            {
                Id = 7,
                Nome = "Pablo Vargas",
                Cpf = "44379349039",
                Senha = "pablo.vargas",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno8 = new Aluno()
            {
                Id = 8,
                Nome = "Lucas da Silva",
                Cpf = "04327688070",
                Senha = "lucas.silva",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno9 = new Aluno()
            {
                Id = 9,
                Nome = "Arthur Pereiras",
                Cpf = "89519903038",
                Senha = "arthur.pereira",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno10 = new Aluno()
            {
                Id = 10,
                Nome = "Gustavo de Souza",
                Cpf = "68302628018",
                Senha = "gustavo.souza",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno11 = new Aluno()
            {
                Id = 11,
                Nome = "Alice Barbosa",
                Cpf = "49813358068",
                Senha = "alice.barbosa",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno12 = new Aluno()
            {
                Id = 12,
                Nome = "Gabriela da Rosa",
                Cpf = "33929266040",
                Senha = "gabriela.rosa",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno13 = new Aluno()
            {
                Id = 13,
                Nome = "Geovana da Cruz",
                Cpf = "43757480015",
                Senha = "geovana.cruz",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno14 = new Aluno()
            {
                Id = 14,
                Nome = "Julia Vargas",
                Cpf = "53090307006",
                Senha = "julia.vargas",
                Sala = "302",
                Tipo = "Aluno"
            };
            var aluno15 = new Aluno()
            {
                Id = 15,
                Nome = "Letícia Rodrigues",
                Cpf = "89373458035",
                Senha = "leticia.rodrigues",
                Sala = "302",
                Tipo = "Aluno"
            };

            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);
            alunos.Add(aluno4);
            alunos.Add(aluno5);
            alunos.Add(aluno6);
            alunos.Add(aluno7);
            alunos.Add(aluno8);
            alunos.Add(aluno9);
            alunos.Add(aluno10);
            alunos.Add(aluno11);
            alunos.Add(aluno12);
            alunos.Add(aluno13);
            alunos.Add(aluno14);
            alunos.Add(aluno15);

            foreach (var item in alunos)
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
