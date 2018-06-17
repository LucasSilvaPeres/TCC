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
			try
			{


				if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{

					DateTime datainfo = DateTime.Now;

					Atendimento atendimento = new Atendimento(int.Parse(txtIdCliente.Text), datainfo, int.Parse(txtPreco.Text));
					AtendimentoTableAdapter ata = new AtendimentoTableAdapter();
					ata.InsertAtendimento(atendimento.DataAtendimento, atendimento.PrecoAtendimento, atendimento.IdCliente);

					//Serviços_Atendimento serviços_Atendimento =  new Serviços_Atendimento

					TableRefresh();
					LimparCampos();



				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

		}
		private void TableRefresh()
		{
			try
			{
				atendimentoTableAdapter.Fill(dsPrincipal.Atendimento);
				dgvAtendimento.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

			}
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
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

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
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja limpar os campos?", "Limpar Campos",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				LimparCampos();
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
				if(item is ComboBox)
				{
					(item as ComboBox).SelectedIndex = 0;
				}
				if(item is MaskedTextBox)
				{
					(item as MaskedTextBox).Clear();
				}
			}
			txtIdCliente.Focus();

		}
	}
}
