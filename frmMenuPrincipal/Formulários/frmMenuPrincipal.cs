using frmMenuPrincipal.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal
{
	public partial class frmMenuPrincipal : Form
	{
		public frmMenuPrincipal()
		{
			InitializeComponent();
		}

		private void frmMenuPrincipal_Load(object sender, EventArgs e)
		{
			tslUsuario.Text += Properties.Settings.Default.NomeUsuarioLogado.ToUpper();

		}

		private void tsbtnSair_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NomeUsuarioLogado = "";
			Properties.Settings.Default.NivelUsuarioLogado = 0;
			frmLogin frmlogin = new frmLogin();
			frmlogin.Show();
			Hide();
		}

		private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			frmLogin frmlogin = new frmLogin();
			frmlogin.Show();

		}
		

		private void btnCliente_Click(object sender, EventArgs e)
		{
			tpLista.Text = "Clientes";
		}

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			tpLista.Text = "Funcionários";

		}

		private void btnFornecedor_Click(object sender, EventArgs e)
		{
			tpLista.Text = "Fornecedores";

		}

		private void btnServico_Click(object sender, EventArgs e)
		{
			tpLista.Text = "Serviços";

		}

		private void btnProduto_Click(object sender, EventArgs e)
		{
			tpLista.Text = "Produtos";

		}
	}
}
