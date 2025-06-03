using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.model.Abstractions;
using teste.model.Interfaces;

namespace teste.model.classes
{
    public class Alunos : AbstractPessoa
    {

        public static List<Alunos> ListaAlunos { get; set; } = new List<Alunos>();
        public List<Cursos> CursosMatriculados { get; set; } = new List<Cursos>();

        public Alunos(string name, string email, string phone, string cpf, string dataNascimento, List<Cursos> listaCursos)
        {
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = (DateTime.Now.Year).ToString() + (ListaAlunos.Count + 1).ToString();
            CursosMatriculados = listaCursos;
        }

        public static void MatricularAluno(Alunos aluno, Cursos curso)
        {
            if (!aluno.CursosMatriculados.Contains(curso))
            {
                aluno.CursosMatriculados.Add(curso);
            } else
            {
                MessageBox.Show("Aluno já matriculado neste curso.");
            }

    

        }
    }
}