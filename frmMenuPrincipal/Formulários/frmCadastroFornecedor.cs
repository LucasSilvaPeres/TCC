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
	public partial class frmCadastroFornecedor : Form
	{
		public frmCadastroFornecedor()
		{
			InitializeComponent();
		}
		private void frmCadastroFornecedor_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
			this.fornecedorTableAdapter.Fill(this.dsPrincipal.Fornecedor);

		}
	}
}
