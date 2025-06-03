using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.model.Interfaces
{
    public interface IPessoa
    {
        string Name { get; set;  }
        string Email { get; set;  }
        string Phone { get; set;  }
        string CPF { get; set;  }
        string DataNascimento { get; set;  }
        string Matricula { get; set; }
    }
}
