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
    public class Professores: AbstractPessoa
    {
        
        public static List<Professores> ListaProfessores { get; set; } = new List<Professores>();

        public Professores()
        {
        }

        public Professores(string name, string email, string phone, string cpf, string dataNascimento, Cursos curso)
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

            if (curso == null)
                throw new Exception("O curso não pode ser nulo.");

            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = (ListaProfessores.Count + 1).ToString("D4");

            if (ListaProfessores.Any(p => p.CPF == cpf))
                throw new Exception("Professor já cadastrado com este CPF.");

            ListaProfessores.Add(this);
            curso.Professor = this;
        }


    }

}

