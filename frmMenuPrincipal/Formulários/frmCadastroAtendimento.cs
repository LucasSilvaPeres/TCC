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
	public partial class frmCadastroAtendimento : Form
	{
		public frmCadastroAtendimento()
		{
			InitializeComponent();
		}

		private void atendimentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
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
		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				try
				{
					DateTime datainfo = DateTime.Now;

					Atendimento atendimento = new Atendimento(int.Parse(txtIdCliente.Text), datainfo, int.Parse(txtPreco.Text));
					AtendimentoTableAdapter ata = new AtendimentoTableAdapter();
					ata.InsertAtendimento(atendimento.DataAtendimento, atendimento.PrecoAtendimento, atendimento.IdCliente);

					//Serviços_Atendimento serviços_Atendimento =  new Serviços_Atendimento

					TableRefresh();
				}catch(Exception ex)
				{
					throw ex;
				}
			}

		}
		private void TableRefresh()
		{
			atendimentoTableAdapter.Fill(dsPrincipal.Atendimento);
			dgvAtendimento.Refresh();
		}

		private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				txtListaProdutos.Text += "\n" + cmbProdutos.Text;
				cmbProdutos.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void cmbServicos_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ServicoTableAdapter sta = new ServicoTableAdapter();
				int precoServico = int.Parse(sta.FillBy(cmbServicos.Text));
				int precoAtual = int.Parse(txtPreco.Text);
				txtPreco.Text = (precoAtual + precoServico).ToString();
				txtListaServicos.Text += "\n" + cmbServicos.Text;
				cmbServicos.SelectedIndex = 0;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{

		}
	}
}
