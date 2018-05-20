using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Fornecimento
	{
		private int idFornecedor;
		private DateTime dataFornecimento;

		public Fornecimento(int idFornecedor, DateTime dataFornecimento)
		{
			IdFornecedor = idFornecedor;
			DataFornecimento = dataFornecimento;
		}

		public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
		public DateTime DataFornecimento { get => dataFornecimento; set => dataFornecimento = value; }
	}
}
