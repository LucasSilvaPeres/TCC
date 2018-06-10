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
            frmCadastroAtendimento frmatendimento = new frmCadastroAtendimento();
			frmatendimento.MdiParent = this;
			frmatendimento.Show();
			frmatendimento.Anchor = AnchorStyles.Bottom;

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

        private void tsmCadastrosPrincipais_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadPrincipais"] == null)
            {
                frmCadPrincipais frmCadastros = new frmCadPrincipais { MdiParent = this };
                frmCadastros.Show();
            }
        }

        private void tsmCadastroFornecimento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadFornecimento"] == null) 
            {
                frmCadFornecimento FrmCadFornecimento = new frmCadFornecimento { MdiParent = this };
                FrmCadFornecimento.Show();
            }

        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBackup"] == null)
            {
                frmBackup FrmBackup = new frmBackup();
                FrmBackup.Show();
            }
        }

	}
}
