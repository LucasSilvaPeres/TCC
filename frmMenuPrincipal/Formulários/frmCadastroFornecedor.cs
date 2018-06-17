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
	public partial class frmCadastroFornecedor : Form
	{
		public frmCadastroFornecedor()
		{
			InitializeComponent();
		}
		private void frmCadastroFornecedor_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
			this.fornecedorTableAdapter.Fill(this.dsPrincipal.Fornecedor);
			rbCNPJ.Checked = true;
		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Tem certeza que deseja limpar os campos?", "Limpar Campos",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
			}
			txtNome.Focus();
			rbCNPJ.Checked = true;
		}

		private void rbCPF_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCPF.Checked)
			{
				txtIdentidade.Mask = "999,999,999-99";
				txtIdentidade.Size = new Size(82, 20);
			}
			else
			{
				txtIdentidade.Mask = "99,999,999/9999-99";
				txtIdentidade.Size = new Size(105, 20);
			}
		}
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
			try
			{
				if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					DateTime datainfo = DateTime.Now;
					Fornecedor fornecedor = new Fornecedor(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtEndereco.Text, txtIdentidade.Text, datainfo);
					FornecedorTableAdapter sta = new FornecedorTableAdapter();
					sta.Insert(fornecedor.NomeFornecedor, fornecedor.EnderecoFornecedor, fornecedor.IdentidadeFornecedor, fornecedor.TelefoneFornecedor, fornecedor.EmailFornecedor, fornecedor.DataInfo);
					TableRefresh();
					LimparCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}
        private void TableRefresh()
        {
            fornecedorTableAdapter.Fill(this.dsPrincipal.Fornecedor);
            dgvBancoForm.Refresh();
        }
    }
}
