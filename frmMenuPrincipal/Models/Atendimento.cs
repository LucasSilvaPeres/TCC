using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Atendimento
	{
		private int idCliente;
		private DateTime dataAtendimento;
		private decimal precoAtendimento;

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public DateTime DataAtendimento
        {
            get
            {
                return dataAtendimento;
            }

            set
            {
                dataAtendimento = value;
            }
        }

        public decimal PrecoAtendimento
        {
            get
            {
                return precoAtendimento;
            }

            set
            {
                precoAtendimento = value;
            }
        }

        public Atendimento(int idCliente, DateTime dataAtendimento, decimal precoAtendimento)
		{
			this.IdCliente = idCliente;
			this.DataAtendimento = dataAtendimento;
			this.PrecoAtendimento = precoAtendimento;
		}

		//public int IdServico { get => idServico; set => idServico = value; }
		//public DateTime DataAtendimento { get => dataAtendimento; set => dataAtendimento = value; }
		//public decimal PrecoAtendimento { get => precoAtendimento; set => precoAtendimento = value; }
	}
}
