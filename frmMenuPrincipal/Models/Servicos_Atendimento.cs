using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Servicos_Atendimento
	{
		int idServico, idAtendimento;

		//public int IdServico { get => idServico; set => idServico = value; }
		//public int IdAtendimento { get => idAtendimento; set => idAtendimento = value; }

		public int IdServico
		{
			get
			{
				return idServico;
			}

			set
			{
				idServico = value;
			}
		}
		public int IdAtendimento
		{
			get
			{
				return idAtendimento;
			}

			set
			{
				idAtendimento = value;
			}
		}

		public Servicos_Atendimento(int idServico, int idAtendimento)
		{
			IdServico = idServico;
			IdAtendimento = idAtendimento;
		}
	}
}
