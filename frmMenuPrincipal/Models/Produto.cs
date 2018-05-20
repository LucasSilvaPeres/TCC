using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Produto
	{
		private int idFornecedor, estoqueProduto;
		private string nomeProduto;
		private DateTime dataInfo;

		public Produto(int idFornecedor, int estoqueProduto, string nomeProduto, DateTime dataInfo)
		{
			IdFornecedor = idFornecedor;
			EstoqueProduto = estoqueProduto;
			NomeProduto = nomeProduto;
			DataInfo = dataInfo;
		}

		public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
		public int EstoqueProduto { get => estoqueProduto; set => estoqueProduto = value; }
		public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
		public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
