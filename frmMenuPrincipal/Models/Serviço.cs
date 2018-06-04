using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuPrincipal.Models
{
	class Serviço
	{
		private string nomeServico, precoServico;
		private DateTime dataInfo;

        public string NomeServico
        {
            get
            {
                return nomeServico;
            }

            set
            {
                nomeServico = value;
            }
        }

        public string PrecoServico
        {
            get
            {
                return precoServico;
            }

            set
            {
                precoServico = value;
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

        public Serviço(string nomeServico, string precoServico, DateTime dataInfo)
		{
			this.NomeServico = nomeServico;
			this.PrecoServico = precoServico;
			this.DataInfo = dataInfo;
		}

		//public string NomeServico { get => nomeServico; set => nomeServico = value; }
		//public string PrecoServico { get => precoServico; set => precoServico = value; }
		//public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
	}
}
