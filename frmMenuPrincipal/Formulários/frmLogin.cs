using frmMenuPrincipal.Dados;
using frmMenuPrincipal.Dados.dsPrincipalTableAdapters;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
		int vErros = 0;
		private bool CaixasOK()
		{
			if (txtUsuario.Text == "")
			{
				errErro.SetError(txtUsuario, "Informar o usuário");
				return false;
			}
			else
			{
				errErro.SetError(txtUsuario, "");
			}
			if (masktxtSenha.Text == "")
			{
				errErro.SetError(masktxtSenha, "Informar a Senha");
				return false;
			}
			else
			{
				errErro.SetError(masktxtSenha, "");
			}
			return true;
		}

		private void btnOK_Click(object sender, EventArgs e)
        {
			if (CaixasOK())
			{
				dsPrincipal.UsuarioDataTable dtUsuario;
				UsuarioTableAdapter usuarioTA = new UsuarioTableAdapter();
				dtUsuario = usuarioTA.GetDataNivelUsuario(txtUsuario.Text, masktxtSenha.Text);
				if (dtUsuario.Rows.Count == 0)
				{
					MessageBox.Show("Usuário ou Senha inválidos");
					vErros++;
					if (vErros == 3)
					{
						MessageBox.Show("Número de Tentativas esgotado...");
						this.Close();
					}
				}
				else
				{
					Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
					Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
					Show();
					//Hide();
				}
			}
		}

		private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
		{
			if(cbMostrarSenha.Checked == true) masktxtSenha.UseSystemPasswordChar = false;
			else masktxtSenha.UseSystemPasswordChar = true;
		}
		
	}
}
