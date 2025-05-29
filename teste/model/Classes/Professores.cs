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
        // Default constructor
        public Professores()
        {
        }
    }
    
}

