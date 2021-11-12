using Program.Entities;
using Program.Models.Professor;
using System.Collections.Generic;

namespace Program.Services
{
    public sealed class ProfessorService
    {
        public void Create(ProfessorRequestModel requestModel)
        {

        }

        public Professor Logar(string cpf, string senha)
        {
            var professores = new List<Professor>();

            var professor1 = new Professor
            {
                Id = 1,
                Nome = "Rogério da Silva",
                Materia = "Matemática",
                Cpf = "81288212020",
                Senha = "rogerio.silva",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor2 = new Professor
            {
                Id = 2,
                Nome = "Eliane Borges",
                Materia = "Português",
                Cpf = "40244494002",
                Senha = "eliane.borges",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor3 = new Professor
            {
                Id = 3,
                Nome = "Adriano de Sa",
                Materia = "História",
                Cpf = "19623843062",
                Senha = "adriano.sa",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor4 = new Professor
            {
                Id = 4,
                Nome = "Vera da Cruz",
                Materia = "Geografia",
                Cpf = "20550860061",
                Senha = "vera.cruz",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor5 = new Professor
            {
                Id = 5,
                Nome = "Mauricio da Silva",
                Materia = "Biologia",
                Cpf = "89626287080",
                Senha = "mauricio.silva",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor6 = new Professor
            {
                Id = 6,
                Nome = "Carlos Schimit",
                Materia = "Química",
                Cpf = "76550160030",
                Senha = "carlos.schimit",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor7 = new Professor
            {
                Id = 7,
                Nome = "Renato Machado",
                Materia = "Física",
                Cpf = "20256674000",
                Senha = "renato.machado",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor8 = new Professor
            {
                Id = 8,
                Nome = "Marcos Andrade",
                Materia = "Educação Física",
                Cpf = "43184493008",
                Senha = "marcos.andrade",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor9 = new Professor
            {
                Id = 9,
                Nome = "Janaina dos Santos",
                Materia = "Inglês",
                Cpf = "44954515025",
                Senha = "janaina.santos",
                Sala = "302",
                Tipo = "Professor"
            };
            var professor10 = new Professor
            {
                Id = 9,
                Nome = "Diego Alves",
                Materia = "Artes",
                Cpf = "81185546006",
                Senha = "diego.alves",
                Sala = "302",
                Tipo = "Professor"
            };

            professores.Add(professor1);
            professores.Add(professor2);
            professores.Add(professor3);
            professores.Add(professor4);
            professores.Add(professor5);
            professores.Add(professor6);
            professores.Add(professor7);
            professores.Add(professor8);
            professores.Add(professor9);
            professores.Add(professor10);

            foreach (var item in professores)
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
