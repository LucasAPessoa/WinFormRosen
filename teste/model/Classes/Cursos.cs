using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.model.Abstractions;

namespace teste.model.classes
{
    public class Cursos: AbstractCursos
    {
        public static List<Cursos> ListaCursos { get; set; } = new List<Cursos>();
        public List<Alunos> Alunos { get; set; } = new List<Alunos>();
        public Professores Professor { get; set; }


        public Cursos(string nome, int cargaHoraria)
        {
            ID = Guid.NewGuid();
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }


        public override string ToString()
        {
            return Nome;

        }


        public override void ExibirDados()
        {
            MessageBox.Show($"Curso: {ID}");
            MessageBox.Show($"Curso: {Nome}");
            MessageBox.Show($"Carga Horária: {CargaHoraria} horas");
            MessageBox.Show($"Professor: {Professor.Name}");
            MessageBox.Show("Alunos:");
            foreach (var aluno in Alunos)
            {
                MessageBox.Show($"- {aluno.Name}");
            }
        }

    }
}
