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
	public partial class frmCadastroAtendimento : Form
	{
		public frmCadastroAtendimento()
		{
			InitializeComponent();
		}

		private void atendimentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.atendimentoBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dsPrincipal);

		}

		private void frmCadastroAtendimento_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Servico'. Você pode movê-la ou removê-la conforme necessário.
			this.servicoTableAdapter.Fill(this.dsPrincipal.Servico);
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Produto'. Você pode movê-la ou removê-la conforme necessário.
			this.produtoTableAdapter.Fill(this.dsPrincipal.Produto);
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Atendimento'. Você pode movê-la ou removê-la conforme necessário.
			this.atendimentoTableAdapter.Fill(this.dsPrincipal.Atendimento);
			//WindowState = FormWindowState.Maximized;
			//WindowState = FormWindowState.Normal;
			//WindowState = FormWindowState.Maximized;
		}

	}
}
