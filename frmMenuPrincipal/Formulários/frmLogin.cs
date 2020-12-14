﻿using frmMenuPrincipal.Dados;
using frmMenuPrincipal.Dados.dsPrincipalTableAdapters;
using MaterialSkin.Controls;
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
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
  
        }
		int vErros = 0;
		private bool CaixasOK()
		{
			switch (masktxtSenha.Text)
			{
				case "":
					errErro.SetError(masktxtSenha, "Informar a Senha");
					return false;
				default:
					errErro.SetError(masktxtSenha, "");
					break;
			}
			return true;
		}
        //private void Login()
        //{
        //        //Enquanto não temos o banco de dados
                
        //        if (txtUsuario.Text.ToUpper() != "EU" || masktxtSenha.Text != "123")
        //        {
        //            MessageBox.Show("Usuário ou Senha inválidos");
        //            vErros++;
        //            if (vErros == 3)
        //            {
        //                MessageBox.Show("Número de Tentativas esgotado...");
        //                Close();
        //            }
        //        }
        //        else
        //        {
        //            Properties.Settings.Default.NivelUsuarioLogado = 1;
        //            Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
        //            frmMenuPrincipal frmMP = new frmMenuPrincipal();
        //            frmMP.Show();
        //            Hide();
        //        }
        //}

		private void Login()
		{
			if (CaixasOK())
			{
				if (masktxtSenha.Text != "123")
				{
					MessageBox.Show("Senha inválida");
					vErros++;
					if (vErros == 3)
					{
						MessageBox.Show("Número de Tentativas esgotado...");
						Close();
					}
				}
				else
				{
					Properties.Settings.Default.NivelUsuarioLogado = 1;
					frmMenuPrincip frmMP = new frmMenuPrincip();
					frmMP.Show();
					Hide();
				}

			}
		}
        private void btnOK_Click(object sender, EventArgs e)
        {
			Login();
        }

		private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
		{
			if(cbMostrarSenha.Checked == true) masktxtSenha.UseSystemPasswordChar = false;
			else masktxtSenha.UseSystemPasswordChar = true;
		}
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
		private void masktxtSenha_Enter(object sender, EventArgs e)
		{
			Login();
		}
		private void frmLogin_Enter(object sender, EventArgs e)
		{
			Login();
		}
		private void Login_Enter(object sender, EventArgs e)
		{
			Login();
		}
	}
}
