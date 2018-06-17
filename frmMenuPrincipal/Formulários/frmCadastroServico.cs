using frmMenuPrincipal.Dados.dsPrincipalTableAdapters;
using frmMenuPrincipal.Models;
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
	public partial class frmCadastroServico : Form
	{
		public frmCadastroServico()
		{
			InitializeComponent();
		}

		private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.tableAdapterManager.UpdateAll(this.dsPrincipal);

		}

		private void frmCadastroServico_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dsPrincipal.Servico' table. You can move, or remove it, as needed.
			this.servicoTableAdapter.Fill(this.dsPrincipal.Servico);

		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Tem certeza que deseja limpar os campos?", "Limpar Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					LimparCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					DateTime datainfo = DateTime.Now;
					Serviço servico = new Serviço(txtServico.Text, txtPreco.Text, datainfo);
					ServicoTableAdapter sta = new ServicoTableAdapter();
					sta.Insert(servico.NomeServico, servico.PrecoServico, servico.DataInfo);
					TableRefresh();
					LimparCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void LimparCampos()
		{
			foreach (Control item in pnlCampos.Controls)
			{
				if (item is TextBox)
				{
					(item as TextBox).Clear();
				}
				if(item is MaskedTextBox)
				{
					(item as MaskedTextBox).Clear();
				}
			}
			txtServico.Focus();
		}

		private void TableRefresh()
		{
			servicoTableAdapter.Fill(this.dsPrincipal.Servico);
			dgvBancoForm.Refresh();
		}
	}
}
