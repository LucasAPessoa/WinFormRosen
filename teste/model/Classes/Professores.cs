using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Matricula = (ListaProfessores.Count +1).ToString();

            if (!ListaProfessores.Contains(this))
            {
                ListaProfessores.Add(this);
                curso.Professor = this;    
            }
            else
            {
                throw new Exception("Professor já cadastrado.");
            }
        }
    }
    
}

