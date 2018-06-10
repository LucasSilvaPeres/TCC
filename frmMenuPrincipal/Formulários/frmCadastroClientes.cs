using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal.Formulários
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

		private void frmCadastroClientes_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.clienteTableAdapter.Fill(this.dsPrincipal.Cliente);

		}
	}
}
