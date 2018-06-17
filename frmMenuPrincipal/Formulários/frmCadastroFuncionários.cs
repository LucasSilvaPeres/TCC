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
	public partial class frmCadastroFuncionários : Form
	{
		public frmCadastroFuncionários()
		{
			InitializeComponent();
		}

		private void frmCadastroFuncionários_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.dsPrincipal.Funcionario);

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

		private void LimparCampos()
		{
			foreach (Control item in pnlCampos.Controls)
			{
				if (item is TextBox)
				{
					(item as TextBox).Clear();
				}
				if (item is MaskedTextBox)
				{
					(item as MaskedTextBox).Clear();
				}
				if (item is DateTimePicker)
				{
					dtpDataNascimento.Value = DateTime.Now;
				}
			}
			txtNome.Focus();
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
        {
			try
			{
				if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					DateTime datainfo = DateTime.Now;
					Funcionario funcionario = new Funcionario(txtNome.Text, txtIdentidade.Text, txtCelular.Text,
						txtTelefone.Text, txtBairro.Text, txtEndereco.Text, decimal.Parse(txtSalario.Text), dtpDataNascimento.Value, datainfo);
					FuncionarioTableAdapter sta = new FuncionarioTableAdapter();
					sta.InsertFuncionario(funcionario.TelefoneFuncionario, funcionario.EnderecoFuncionario, funcionario.NomeFuncionario, funcionario.BairroFuncionario, funcionario.CelularFuncionario,
						funcionario.PagamentoFuncionario, funcionario.IdentidadeFuncionario, funcionario.NascFuncionario.ToString(), funcionario.Datainfo);
					TableRefresh();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}
        private void TableRefresh()
        {
            funcionarioTableAdapter.Fill(this.dsPrincipal.Funcionario);
            dgvBancoForm.Refresh();
        }
    }
}
