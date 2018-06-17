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
    public partial class frmCadastrarProdutos : Form
    {
        public frmCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dsPrincipal);

        }

        private void frmCadastrarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dsPrincipal.Produto);

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Tem certeza que deseja limpar os campos?", "Limpar Campos",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				LimparCampos();
			}
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Tem certeza que deseja confirmar os dados?", "Confirmar Dados",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				DateTime datainfo = DateTime.Now;
				Produto produto = new Produto(int.Parse(txtIdFornecedor.Text), int.Parse(txtEstoque.Text), txtNome.Text, datainfo);
				ProdutoTableAdapter pta = new ProdutoTableAdapter();
				pta.Insert(produto.IdFornecedor, produto.NomeProduto, produto.EstoqueProduto, produto.DataInfo);
				TableRefresh();
				LimparCampos();
			}
        }

        private void TableRefresh()
        {
            produtoTableAdapter.Fill(dsPrincipal.Produto);
            dgvProduto.Refresh();
        }

		private void LimparCampos()
		{
			
				foreach (Control item in pnlCampos.Controls)
				{
					if (item is TextBox)
					{
						(item as TextBox).Clear();
					}
				}
				txtNome.Focus();
			
		}
    }
}
