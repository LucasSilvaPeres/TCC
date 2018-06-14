using frmMenuPrincipal.Formulários;
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

namespace frmMenuPrincipal
{
	public partial class frmMenuPrincip : MaterialForm
	{
        frmCadPrincipais frmcad = new frmCadPrincipais();

        public frmMenuPrincip()
		{
			InitializeComponent();
           
        }
		private void frmMenuPrincipal_Load(object sender, EventArgs e)
		{
            frmcad.MdiParent = this;
            frmcad.Show();

            //frmatendimento.Anchor = AnchorStyles.Bottom;
            tslHora.Text = DateTime.Now.ToString();
			timerHora.Enabled = true;
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

		private void timerHora_Tick(object sender, EventArgs e)
		{
			tslHora.Text = DateTime.Now.ToString();
            //if (Application.OpenForms["frmBackup"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarProdutos"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarAtendimento"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarFornecimento"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarFornecedor"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarServico"] != null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarClientes"] == null)
            //{
            //    panel2.Visible = true;
            //}
            //if (Application.OpenForms["frmCadastrarFuncionários"] == null)
            //{
            //    panel2.Visible = true;
            //}
        }

        //private void btnCliente_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastrarClientes"] == null)
        //    {
        //        frmCadastroClientes frmcadc = new frmCadastroClientes { MdiParent = this };
        //        frmcadc.Show();
        //        //panel2.Visible = false;
        //    }

        //}

        //private void btnServico_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastrarServico"] == null)
        //    {
        //        frmCadastroServico frmcads = new frmCadastroServico { MdiParent = this };
        //        frmcads.Show();
        //        //panel2.Visible = false;
        //    }
        //}

        //private void btnProduto_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastrarProdutos"] == null)
        //    {
        //        frmCadastrarProdutos frmcadp = new frmCadastrarProdutos { MdiParent = this };
        //        frmcadp.Show();
        //        //panel2.Visible = false;
        //    }

        //}

        //private void btnAtendimento_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastroAtendimento"] == null)
        //    {
        //        frmCadastroAtendimento frmcada = new frmCadastroAtendimento { MdiParent = this };
        //        frmcada.Show();
        //        //panel2.Visible = false;
        //    }

        //}

        //private void btnFornecimento_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadFornecimento"] == null)
        //    {
        //        frmCadFornecimento FrmCadFornecimento = new frmCadFornecimento { MdiParent = this };
        //        FrmCadFornecimento.Show();
        //        //panel2.Visible = false;
        //    }
        //}

        //private void btnFornecedor_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastroFornecedor"] == null)
        //    {
        //        frmCadastroFornecedor frmcadf = new frmCadastroFornecedor { MdiParent = this };
        //        frmcadf.Show();
        //        //panel2.Visible = false;
        //    }

        //}

        //private void tsmCadastroFuncionario_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["frmCadastroFuncionários"] == null)
        //    {
        //        frmCadastroFuncionários frmcadf = new frmCadastroFuncionários { MdiParent = this };
        //        frmcadf.Show();
        //        //panel2.Visible = false;
        //    }
        //}
        public void Servico()
        {
            if (Application.OpenForms["frmCadastrarServico"] == null)
            {
                frmCadastroServico frmcads = new frmCadastroServico ();
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Cliente()
        {
            if (Application.OpenForms["frmCadastrarClientes"] == null)
            {
                frmCadastroClientes frmcads = new frmCadastroClientes { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }

        }
        public void Fornecimento()
        {
            if (Application.OpenForms["frmCadFornecimento"] == null)
            {
                frmCadFornecimento frmcads = new frmCadFornecimento { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }

        }
        public void Funcionario()
        {
            if (Application.OpenForms["frmCadastroFuncionários"] == null)
            {
                frmCadastroFuncionários frmcads = new frmCadastroFuncionários { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Produto()
        {
            if (Application.OpenForms["frmCadastrarProdutos"] == null)
            {
                frmCadastrarProdutos frmcads = new frmCadastrarProdutos { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Fornecedor()
        {
            if (Application.OpenForms["frmCadastroFornecedor"] == null)
            {
                frmCadastroFornecedor frmcads = new frmCadastroFornecedor { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Atendimento()
        {
            if (Application.OpenForms["frmCadastroAtendimento"] == null)
            {
                frmCadastroAtendimento frmcads = new frmCadastroAtendimento { MdiParent = this };
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
    }
}
