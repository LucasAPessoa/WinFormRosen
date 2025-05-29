using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.model.classes;

namespace teste.model.Abstractions
{
    public abstract class AbstractCursos
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

        public abstract void ExibirDados();
    }
}
