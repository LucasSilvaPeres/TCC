using frmMenuPrincipal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Funcionario
	{
		private string nomeFuncionario, identidadeFuncionario, celularFuncionario, telefoneFuncionario,
			bairroFuncionario, enderecoFuncionario;
		private decimal pagamentoFuncionario;

		public Funcionario(string nomeFuncionario, string identidadeFuncionario, string celularFuncionario,
			string telefoneFuncionario, 
			string bairroFuncionario, string enderecoFuncionario, decimal pagamentoFuncionario)
		{
			NomeFuncionario = nomeFuncionario;
			IdentidadeFuncionario = identidadeFuncionario;
			CelularFuncionario = celularFuncionario;
			TelefoneFuncionario = telefoneFuncionario;
			BairroFuncionario = bairroFuncionario;
			EnderecoFuncionario = enderecoFuncionario;
			PagamentoFuncionario = pagamentoFuncionario;
		}

        public string BairroFuncionario
        {
            get
            {
                return bairroFuncionario;
            }

            set
            {
                bairroFuncionario = value;
            }
        }

        public string CelularFuncionario
        {
            get
            {
                return celularFuncionario;
            }

            set
            {
                celularFuncionario = value;
            }
        }

        public string EnderecoFuncionario
        {
            get
            {
                return enderecoFuncionario;
            }

            set
            {
                enderecoFuncionario = value;
            }
        }

        public string IdentidadeFuncionario
        {
            get
            {
                return identidadeFuncionario;
            }

            set
            {
                if (ValidarIdentidade.Validar(value))
                {
                    identidadeFuncionario = value;
                }
                else
                {
                    throw new Exception("Identidade Inválida");
                }
            }
        }

        public string NomeFuncionario
        {
            get
            {
                return nomeFuncionario;
            }

            set
            {
                nomeFuncionario = value;
            }
        }

        public decimal PagamentoFuncionario
        {
            get
            {
                return pagamentoFuncionario;
            }

            set
            {
                pagamentoFuncionario = value;
            }
        }

        public string TelefoneFuncionario
        {
            get
            {
                return telefoneFuncionario;
            }

            set
            {
                telefoneFuncionario = value;
            }
        }

        //public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        //public string IdentidadeFuncionario { get => identidadeFuncionario; set => identidadeFuncionario = value; }
        //public string CelularFuncionario { get => celularFuncionario; set => celularFuncionario = value; }
        //public string TelefoneFuncionario { get => telefoneFuncionario; set => telefoneFuncionario = value; }
        //public string BairroFuncionario { get => bairroFuncionario; set => bairroFuncionario = value; }
        //public string EnderecoFuncionario { get => enderecoFuncionario; set => enderecoFuncionario = value; }
        //public decimal PagamentoFuncionario { get => pagamentoFuncionario; set => pagamentoFuncionario = value; }
    }
}
