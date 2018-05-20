using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Fornecedor
	{
		private string nomeFornecedor, telefoneFornecedor,
			emailFornecedor, enderecoFornecedor, bairroFornecedor, identidadeFornedor;
		private DateTime dataInfo;

		public Fornecedor(string nomeFornecedor, string telefoneFornecedor,
			string emailFornecedor, string enderecoFornecedor, string bairroFornecedor, string identidadeFornedor, DateTime dataInfo)
		{
			NomeFornecedor = nomeFornecedor;
			TelefoneFornecedor = telefoneFornecedor;
			EmailFornecedor = emailFornecedor;
			EnderecoFornecedor = enderecoFornecedor;
			BairroFornecedor = bairroFornecedor;
			IdentidadeFornedor = identidadeFornedor;
			DataInfo = dataInfo;
		}

		public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
		public string TelefoneFornecedor { get => telefoneFornecedor; set => telefoneFornecedor = value; }
		public string EmailFornecedor { get => emailFornecedor; set => emailFornecedor = value; }
		public string EnderecoFornecedor { get => enderecoFornecedor; set => enderecoFornecedor = value; }
		public string BairroFornecedor { get => bairroFornecedor; set => bairroFornecedor = value; }
		public string IdentidadeFornedor { get => identidadeFornedor; set => identidadeFornedor = value; }
		public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
