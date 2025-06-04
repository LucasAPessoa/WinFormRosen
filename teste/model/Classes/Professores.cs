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
    public class Professores : AbstractPessoa
    {
        public static List<Professores> ListaProfessores { get; set; } = new List<Professores>();
        public List<Cursos> Cursos { get; set; } = new List<Cursos>();

        public Professores() { }

        public Professores(string name, string email, string phone, string cpf, string dataNascimento, List<Cursos> cursos)
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

            if (cursos == null || cursos.Count == 0)
                throw new Exception("Pelo menos um curso deve ser associado ao professor.");

            if (ListaProfessores.Any(p => p.CPF == cpf))
                throw new Exception("Professor já cadastrado com este CPF.");

            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = "P" + (ListaProfessores.Count + 1).ToString("D4");

            foreach (var curso in cursos)
            {
                if (curso.Professor != null)
                    throw new Exception($"O curso '{curso.Nome}' já possui um professor.");

                Cursos.Add(curso);
                curso.Professor = this;
            }


        }
    }
}
