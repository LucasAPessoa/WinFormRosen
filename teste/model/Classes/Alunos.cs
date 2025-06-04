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
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome não pode estar vazio.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                throw new Exception("E-mail inválido.");

            if (string.IsNullOrWhiteSpace(phone))
                throw new Exception("O telefone não pode estar vazio.");

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11 || !cpf.All(char.IsDigit))
                throw new Exception("CPF inválido. Deve conter 11 dígitos numéricos.");

            if (!DateTime.TryParse(dataNascimento, out DateTime dataNasc) ||
                dataNasc < new DateTime(1900, 1, 1) ||
                dataNasc > DateTime.Today)
                throw new Exception("Data de nascimento inválida.");

            if (listaCursos == null || listaCursos.Count == 0)
                throw new Exception("O aluno deve estar matriculado em pelo menos um curso.");

            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = "A" + DateTime.Now.Year.ToString() + (ListaAlunos.Count + 1).ToString("D4");
            CursosMatriculados = listaCursos;
        }


    }
}