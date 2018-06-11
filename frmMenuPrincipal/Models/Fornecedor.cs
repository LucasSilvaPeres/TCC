using frmMenuPrincipal.Util;
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
			emailFornecedor, enderecoFornecedor, bairroFornecedor, identidadeFornecedor;
		private DateTime dataInfo;

        public string NomeFornecedor
        {
            get
            {
                return nomeFornecedor;
            }

            set
            {
                nomeFornecedor = value;
            }
        }

        public string TelefoneFornecedor
        {
            get
            {
                return telefoneFornecedor;
            }

            set
            {
                telefoneFornecedor = value;
            }
        }

        public string EmailFornecedor
        {
            get
            {
                return emailFornecedor;
            }

            set
            {
                emailFornecedor = value;
            }
        }

        public string EnderecoFornecedor
        {
            get
            {
                return enderecoFornecedor;
            }

            set
            {
                enderecoFornecedor = value;
            }
        }

        public string BairroFornecedor
        {
            get
            {
                return bairroFornecedor;
            }

            set
            {
                bairroFornecedor = value;
            }
        }

        public string IdentidadeFornecedor
        {
            get
            {
                return identidadeFornecedor;
            }

            set
            {
                if (ValidarIdentidade.Validar(value))
                {
                    identidadeFornecedor = value;
                }
                else
                {
                    throw new Exception("Identidade Inválida");

                }
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

        public Fornecedor(string nomeFornecedor, string telefoneFornecedor,
			string emailFornecedor, string enderecoFornecedor, string bairroFornecedor, string identidadeFornedor, DateTime dataInfo)
		{
			NomeFornecedor = nomeFornecedor;
			TelefoneFornecedor = telefoneFornecedor;
			EmailFornecedor = emailFornecedor;
			EnderecoFornecedor = enderecoFornecedor;
			BairroFornecedor = bairroFornecedor;
			IdentidadeFornecedor = identidadeFornedor;
			DataInfo = dataInfo;
		}

		//public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
		//public string TelefoneFornecedor { get => telefoneFornecedor; set => telefoneFornecedor = value; }
		//public string EmailFornecedor { get => emailFornecedor; set => emailFornecedor = value; }
		//public string EnderecoFornecedor { get => enderecoFornecedor; set => enderecoFornecedor = value; }
		//public string BairroFornecedor { get => bairroFornecedor; set => bairroFornecedor = value; }
		//public string IdentidadeFornedor { get => identidadeFornedor; set => identidadeFornedor = value; }
		//public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
