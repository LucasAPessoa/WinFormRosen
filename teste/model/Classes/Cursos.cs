using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.model.Abstractions;

namespace teste.model.classes
{
    public class Cursos: AbstractCursos
    {
        public static List<Cursos> ListaCursos { get; set; } = new List<Cursos>();
        public List<Alunos> Alunos { get; set; } = new List<Alunos>();
        public Professores Professor { get; set; }

        

        public override void ExibirDados()
        {
            Console.WriteLine($"Curso: {ID}");
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"Professor: {Professor.Name}");
            Console.WriteLine("Alunos:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"- {aluno.Name}");
            }
        }

    }
}
