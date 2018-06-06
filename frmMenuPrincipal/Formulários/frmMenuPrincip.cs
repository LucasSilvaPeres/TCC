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
	public partial class frmMenuPrincip : Form
	{
		public frmMenuPrincip()
		{
			InitializeComponent();
		}

		private void frmMenuPrincipal_Load(object sender, EventArgs e)
		{
            frmCadastrosPrincipais frmcadastros = new frmCadastrosPrincipais();
            frmcadastros.MdiParent = this;
            frmcadastros.Show();
            frmcadastros.Anchor = AnchorStyles.Bottom;

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
			Properties.Settings.Default.NomeUsuarioLogado = "";
			Properties.Settings.Default.NivelUsuarioLogado = 0;
			frmLogin frmlogin = new frmLogin();
			frmlogin.Show();
			Hide();
		}
		

		
	}
}
