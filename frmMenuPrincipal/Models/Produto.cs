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

        public int IdFornecedor
        {
            get
            {
                return idFornecedor;
            }

            set
            {
                idFornecedor = value;
            }
        }

        public int EstoqueProduto
        {
            get
            {
                return estoqueProduto;
            }

            set
            {
                estoqueProduto = value;
            }
        }

        public string NomeProduto
        {
            get
            {
                return nomeProduto;
            }

            set
            {
                nomeProduto = value;
            }
        }

        public DateTime DataInfo
        {
            get
            {
                return dataInfo;
            }

            set
            {
                dataInfo = value;
            }
        }

        public Produto(int idFornecedor, int estoqueProduto, string nomeProduto, DateTime dataInfo)
		{
			IdFornecedor = idFornecedor;
			EstoqueProduto = estoqueProduto;
			NomeProduto = nomeProduto;
			DataInfo = dataInfo;
		}
		public Produto(int estoqueProduto, string nomeProduto)
		{
			EstoqueProduto = estoqueProduto;
			NomeProduto = nomeProduto;
		}
		//public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
		//public int EstoqueProduto { get => estoqueProduto; set => estoqueProduto = value; }
		//public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
		//public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
