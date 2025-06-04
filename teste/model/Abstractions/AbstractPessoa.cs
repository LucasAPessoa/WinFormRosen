using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.model.classes;
using teste.model.Interfaces;

namespace teste.model.Abstractions
{
	public abstract class AbstractPessoa: IPessoa
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string CPF { get; set; }
		public string DataNascimento { get; set; }
		public string Matricula { get; set; }
		public AbstractPessoa() { }

		
	}
	
		
	}

