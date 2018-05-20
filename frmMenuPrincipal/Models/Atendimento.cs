using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Atendimento
	{
		private int idServico;
		private DateTime dataAtendimento;
		private decimal precoAtendimento;

		public Atendimento(int idServico, DateTime dataAtendimento, decimal precoAtendimento)
		{
			this.IdServico = idServico;
			this.DataAtendimento = dataAtendimento;
			this.PrecoAtendimento = precoAtendimento;
		}

		public int IdServico { get => idServico; set => idServico = value; }
		public DateTime DataAtendimento { get => dataAtendimento; set => dataAtendimento = value; }
		public decimal PrecoAtendimento { get => precoAtendimento; set => precoAtendimento = value; }
	}
}
