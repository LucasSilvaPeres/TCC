using frmMenuPrincipal.Docs;
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
            //frmcad.MdiParent = this;
            //frmcad.Show();

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
                frmCadPrincipais frmCadastros = new frmCadPrincipais ();
                frmCadastros.Show();
				frmCadastros.BringToFront();

			}
        }

        private void tsmCadastroFornecimento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadFornecimento"] == null) 
            {
                frmCadFornecimento FrmCadFornecimento = new frmCadFornecimento ();
                FrmCadFornecimento.Show();
				FrmCadFornecimento.BringToFront();
            }

        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBackup"] == null)
            {
                frmBackup FrmBackup = new frmBackup();
                FrmBackup.Show();
				FrmBackup.BringToFront();

			}
		}

		private void timerHora_Tick(object sender, EventArgs e)
		{
			tslHora.Text = DateTime.Now.ToString();
            
        }

		private void btnCliente_Click(object sender, EventArgs e)
		{
			frmCadastroClientes frmcadc = new frmCadastroClientes();

			if (Application.OpenForms["frmCadastroClientes"] == null)
			{
				frmcadc.Show();
				//panel2.Visible = false;
				frmcadc.BringToFront();

			}
			else
			{
				frmcadc.BringToFront();
			}

		}

		private void btnServico_Click(object sender, EventArgs e)
		{
			frmCadastroServico frmcads = new frmCadastroServico();

			if (Application.OpenForms["frmCadastroServico"] == null)
			{
				frmcads.Show();
				//panel2.Visible = false;
				frmcads.BringToFront();

			}
			else
			{
				frmcads.BringToFront();
			}
		}

		private void btnProduto_Click(object sender, EventArgs e)
		{
			frmCadastrarProdutos frmcadp = new frmCadastrarProdutos();

			if (Application.OpenForms["frmCadastrarProdutos"] == null)
			{
				frmcadp.Show();
				//panel2.Visible = false;
				frmcadp.BringToFront();

			}
			else
			{
				frmcadp.BringToFront();
			}
		}

		private void btnAtendimento_Click(object sender, EventArgs e)
		{
			frmCadastroAtendimento frmcada = new frmCadastroAtendimento();

			if (Application.OpenForms["frmCadastroAtendimento"] == null)
			{
				frmcada.Show();
				//panel2.Visible = false;
				frmcada.BringToFront();

			}
			else
			{
				frmcada.BringToFront();
			}

		}

		private void btnFornecimento_Click(object sender, EventArgs e)
		{
			frmCadFornecimento FrmCadFornecimento = new frmCadFornecimento();

			if (Application.OpenForms["frmCadFornecimento"] == null)
			{
				FrmCadFornecimento.Show();
				//panel2.Visible = false;
				FrmCadFornecimento.BringToFront();

			}
			else
			{
				FrmCadFornecimento.BringToFront();
			}
		}

		private void btnFornecedor_Click(object sender, EventArgs e)
		{
			frmCadastroFornecedor frmcadf = new frmCadastroFornecedor();

			if (Application.OpenForms["frmCadastroFornecedor"] == null)
			{
				frmcadf.Show();
				//panel2.Visible = false;
				frmcadf.BringToFront();

			}
			else
			{
				frmcadf.BringToFront();
			}
		}

		private void tsmCadastroFuncionario_Click(object sender, EventArgs e)
		{
			frmCadastroFuncionários frmcadf = new frmCadastroFuncionários();

			if (Application.OpenForms["frmCadastroFuncionários"] == null)
			{
				frmcadf.Show();
				//panel2.Visible = false;
				frmcadf.BringToFront();

			}
			else
			{
				frmcadf.BringToFront();
			}
		}
		public void Servico()
        {
			frmCadastroServico frmcads = new frmCadastroServico();

			if (Application.OpenForms["frmCadastrarServico"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Cliente()
        {
			frmCadastroClientes frmcads = new frmCadastroClientes();

			if (Application.OpenForms["frmCadastrarClientes"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }

        }
        public void Fornecimento()
        {
			frmCadFornecimento frmcads = new frmCadFornecimento();

			if (Application.OpenForms["frmCadFornecimento"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }

        }
        public void Funcionario()
        {
			frmCadastroFuncionários frmcads = new frmCadastroFuncionários();

			if (Application.OpenForms["frmCadastroFuncionários"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Produto()
        {
			frmCadastrarProdutos frmcads = new frmCadastrarProdutos();

			if (Application.OpenForms["frmCadastrarProdutos"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Fornecedor()
        {
			frmCadastroFornecedor frmcads = new frmCadastroFornecedor();

			if (Application.OpenForms["frmCadastroFornecedor"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }
        public void Atendimento()
        {
			frmCadastroAtendimento frmcads = new frmCadastroAtendimento();

			if (Application.OpenForms["frmCadastroAtendimento"] == null)
            {
                frmcads.Show();
                //panel2.Visible = false;
                frmcad.Hide();

            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
