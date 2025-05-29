using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.model.Abstractions;
using teste.model.Interfaces;

namespace teste.model.classes
{
    public class Alunos : AbstractPessoa
    {

        public static List<Alunos> ListaAlunos {get; set;} = new List<Alunos>();

        // Default constructor
        public Alunos()
        {
        }

        public Alunos(string name, string email, string phone, string cpf, string dataNascimento)
        {
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = Guid.NewGuid();
        }

    
    }
}
