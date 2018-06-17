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
    public partial class frmCadFornecimento : Form
    {
        public frmCadFornecimento()
        {
            InitializeComponent();
        }

        private void fornecimentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecimentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrincipal);

        }

        private void frmCadFornecimento_Load(object sender, EventArgs e)
        {
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Produto'. Você pode movê-la ou removê-la conforme necessário.
			this.produtoTableAdapter.Fill(this.dsPrincipal.Produto);
			// TODO: This line of code loads data into the 'dsPrincipal.Produtos_Fornecimento' table. You can move, or remove it, as needed.
			this.produtos_FornecimentoTableAdapter.Fill(this.dsPrincipal.Produtos_Fornecimento);
            // TODO: This line of code loads data into the 'dsPrincipal.Fornecimento' table. You can move, or remove it, as needed.
            this.fornecimentoTableAdapter.Fill(this.dsPrincipal.Fornecimento);

        }

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			foreach (Control item in pnlCampos.Controls)
			{
				if (item is TextBox)
				{
					(item as TextBox).Clear();
				}
				
				if (item is DateTimePicker)
				{
					dtpDataFornecimento.Value = DateTime.Now;
				}
			}
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			DateTime datainfo = DateTime.Now;
			Fornecimento fornecimento= new Fornecimento(int.Parse(txtIdFornecedor.Text), dtpDataFornecimento.Value);
			FornecimentoTableAdapter fta = new FornecimentoTableAdapter();
			fta.InsertFornecimento(fornecimento.IdFornecedor, fornecimento.DataFornecimento);
			Produto produto = new Produto(int.Parse(txtQuantidade.Text), txtProduto.Text);
			ProdutoTableAdapter pta = new ProdutoTableAdapter();
			pta.UpdateProdutoFornecimento(produto.EstoqueProduto, produto.NomeProduto);
			TableRefresh();
		}
		private void TableRefresh()
		{
			fornecimentoTableAdapter.Fill(this.dsPrincipal.Fornecimento);
			produtoTableAdapter.Fill(this.dsPrincipal.Produto);
			dgvFornecimento.Refresh();
			dgvProduto.Refresh();
		}

		private void txtCadProduto_Click(object sender, EventArgs e)
		{
			frmCadastrarProdutos frmcadp = new frmCadastrarProdutos();

			if (Application.OpenForms["frmCadastrarProdutos"] == null)
			{
				frmcadp.Show();
				frmcadp.BringToFront();
			}
			else
			{
				frmcadp.BringToFront();
			}
		}
	}
}
