using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Clientes
	{
		private string nomeCliente, telefoneCliente, emailCliente, enderecoCliente, bairroCliente, identidadeCliente,
			celularCliente;
		private DateTime dataInfo;

        public string NomeCliente
        {
            get
            {
                return nomeCliente;
            }

            set
            {
                nomeCliente = value;
            }
        }

        public string TelefoneCliente
        {
            get
            {
                return telefoneCliente;
            }

            set
            {
                telefoneCliente = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return emailCliente;
            }

            set
            {
                emailCliente = value;
            }
        }

        public string EnderecoCliente
        {
            get
            {
                return enderecoCliente;
            }

            set
            {
                enderecoCliente = value;
            }
        }

        public string BairroCliente
        {
            get
            {
                return bairroCliente;
            }

            set
            {
                bairroCliente = value;
            }
        }

        public string IdentidadeCliente
        {
            get
            {
                return identidadeCliente;
            }

            set
            {
                identidadeCliente = value;
            }
        }

        public string CelularCliente
        {
            get
            {
                return celularCliente;
            }

            set
            {
                celularCliente = value;
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

        public Clientes(string nomeCliente, string telefoneCliente, string emailCliente,
			string enderecoCliente, string bairroCliente, string identidadeCliente, string celularCliente, DateTime dataInfo)
		{
			NomeCliente = nomeCliente;
			TelefoneCliente = telefoneCliente;
			EmailCliente = emailCliente;
			EnderecoCliente = enderecoCliente;
			BairroCliente = bairroCliente;
			IdentidadeCliente = identidadeCliente;
			CelularCliente = celularCliente;
			DataInfo = dataInfo;
		}

		//public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
		//public string TelefoneCliente { get => telefoneCliente; set => telefoneCliente = value; }
		//public string EmailCliente { get => emailCliente; set => emailCliente = value; }
		//public string EnderecoCliente { get => enderecoCliente; set => enderecoCliente = value; }
		//public string BairroCliente { get => bairroCliente; set => bairroCliente = value; }
		//public string IdentidadeCliente { get => identidadeCliente; set => identidadeCliente = value; }
		//public string CelularCliente { get => celularCliente; set => celularCliente = value; }
		//public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
